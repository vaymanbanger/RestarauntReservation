using RestarauntReservation.Forms;
using RestarauntReservation.Models;

namespace RestarauntReservation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using var context = new RestarauntContext();
            Application.Run(new StaffMenu());
        }
    }
}