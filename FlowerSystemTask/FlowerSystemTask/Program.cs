using System;
using System.Windows.Forms;

namespace FlowerSystemTask
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tətbiq işə düşərkən xəta baş verdi:\n\n{ex.Message}\n\nƏtraflı:\n{ex.StackTrace}", 
                    "Sistem Xətası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}