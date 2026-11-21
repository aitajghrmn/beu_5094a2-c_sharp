using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using UniversityEventsAPI.Models;

namespace UniversityEventsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventsController : ControllerBase
    {
        // İlkin mərhələ: məlumatlar verilənlər bazasında deyil, yaddaşdakı List<Event> daxilində saxlanılır.
        private static readonly List<Event> _events = new();
        private static readonly object _lock = new();
        private static int _nextId = 1;

        // ---------------------------------------------------------------
        // GET /api/events
        // Əlavə filtrlər (hamısı ixtiyaridir):
        //   ?search=conference        -> adına görə axtarış
        //   ?city=Baku                -> yerləşdiyi şəhərə (location) görə filtr
        //   ?upcoming=true            -> yalnız gələcək tədbirlər
        //   ?large=true               -> iştirakçı sayı 100-dən çox olanlar
        //   ?sortBy=date&desc=false   -> tarixə görə sıralama (asc/desc)
        // ---------------------------------------------------------------
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Event>), StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Event>> GetAll(
            [FromQuery] string? search,
            [FromQuery] string? city,
            [FromQuery] bool upcoming = false,
            [FromQuery] bool large = false,
            [FromQuery] string? sortBy = null,
            [FromQuery] bool desc = false)
        {
            return Ok(Query(search, city, upcoming, large, sortBy, desc));
        }

        // ---------------------------------------------------------------
        // GET /api/events/export  (eyni filtrləri qəbul edir)
        // Tədbirləri events.json faylı kimi yükləyir.
        // ---------------------------------------------------------------
        [HttpGet("export")]
        [ProducesResponseType(typeof(FileContentResult), StatusCodes.Status200OK)]
        public IActionResult Export(
            [FromQuery] string? search,
            [FromQuery] string? city,
            [FromQuery] bool upcoming = false,
            [FromQuery] bool large = false,
            [FromQuery] string? sortBy = null,
            [FromQuery] bool desc = false)
        {
            var data = Query(search, city, upcoming, large, sortBy, desc);
            var bytes = JsonSerializer.SerializeToUtf8Bytes(data, new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return File(bytes, "application/json", "events.json");
        }

        // GET /api/events/{id}
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(Event), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Event> GetById(int id)
        {
            lock (_lock)
            {
                var ev = _events.FirstOrDefault(e => e.Id == id);
                if (ev == null)
                    return NotFound(new { message = $"ID={id} olan tədbir tapılmadı." });

                return Ok(ev);
            }
        }

        // POST /api/events
        [HttpPost]
        [ProducesResponseType(typeof(Event), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Event> Create([FromBody] Event? newEvent)
        {
            var errors = Validate(newEvent);
            if (errors.Count > 0)
                return BadRequest(new { errors });

            lock (_lock)
            {
                var ev = new Event
                {
                    Id = _nextId++,
                    Name = newEvent!.Name.Trim(),
                    Description = newEvent.Description,
                    Location = newEvent.Location,
                    EventDate = newEvent.EventDate,
                    MaxParticipants = newEvent.MaxParticipants
                };
                _events.Add(ev);

                return CreatedAtAction(nameof(GetById), new { id = ev.Id }, ev);
            }
        }

        // PUT /api/events/{id}
        [HttpPut("{id:int}")]
        [ProducesResponseType(typeof(Event), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Event> Update(int id, [FromBody] Event? updatedEvent)
        {
            lock (_lock)
            {
                var existing = _events.FirstOrDefault(e => e.Id == id);
                if (existing == null)
                    return NotFound(new { message = $"ID={id} olan tədbir tapılmadı." });

                var errors = Validate(updatedEvent);
                if (errors.Count > 0)
                    return BadRequest(new { errors });

                existing.Name = updatedEvent!.Name.Trim();
                existing.Description = updatedEvent.Description;
                existing.Location = updatedEvent.Location;
                existing.EventDate = updatedEvent.EventDate;
                existing.MaxParticipants = updatedEvent.MaxParticipants;

                return Ok(existing);
            }
        }

        // DELETE /api/events/{id}
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            lock (_lock)
            {
                var existing = _events.FirstOrDefault(e => e.Id == id);
                if (existing == null)
                    return NotFound(new { message = $"ID={id} olan tədbir tapılmadı." });

                _events.Remove(existing);
                return NoContent();
            }
        }

        // ---------------------------------------------------------------
        // Köməkçi metodlar
        // ---------------------------------------------------------------

        private static List<string> Validate(Event? ev)
        {
            var errors = new List<string>();

            if (ev == null)
            {
                errors.Add("Sorğunun body hissəsi boşdur və ya yanlış formatdadır.");
                return errors;
            }

            if (string.IsNullOrWhiteSpace(ev.Name))
                errors.Add("Tədbirin adı boş ola bilməz.");

            if (ev.EventDate == default)
                errors.Add("Tədbirin tarixi göndərilməlidir.");
            else if (ev.EventDate < DateTime.Now)
                errors.Add("Tədbirin tarixi keçmiş tarix ola bilməz.");

            if (ev.MaxParticipants < 1)
                errors.Add("İştirakçı sayı 1-dən az ola bilməz.");

            return errors;
        }

        private static List<Event> Query(string? search, string? city, bool upcoming, bool large, string? sortBy, bool desc)
        {
            lock (_lock)
            {
                IEnumerable<Event> query = _events;

                // 1. Adına görə axtarış
                if (!string.IsNullOrWhiteSpace(search))
                    query = query.Where(e => e.Name.Contains(search.Trim(), StringComparison.OrdinalIgnoreCase));

                // 4. Şəhərə (location) görə filtr
                if (!string.IsNullOrWhiteSpace(city))
                    query = query.Where(e => e.Location.Contains(city.Trim(), StringComparison.OrdinalIgnoreCase));

                // 3. Yalnız gələcək tədbirlər
                if (upcoming)
                    query = query.Where(e => e.EventDate > DateTime.Now);

                // 5. İştirakçı sayı 100-dən çox olanlar
                if (large)
                    query = query.Where(e => e.MaxParticipants > 100);

                // 2. Tarixə görə sıralama
                if (string.Equals(sortBy, "date", StringComparison.OrdinalIgnoreCase))
                    query = desc ? query.OrderByDescending(e => e.EventDate) : query.OrderBy(e => e.EventDate);

                return query.ToList();
            }
        }
    }
}
