var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// OpenAPI sənədi (/openapi/v1.json)
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    // Swagger UI: https://localhost:xxxx/swagger
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/openapi/v1.json", "UniversityEventsAPI v1");
        options.RoutePrefix = "swagger";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
