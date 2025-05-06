using MusicAtoutV1_Doan_Khanh.Models;

namespace MusicAtoutV1_Doan_Khanh
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ModelProjet.init();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FCompositeurNation());
            //Application.Run(new FOeuvre());
            //Application.Run(new FCompositeurStyle());
            Application.Run(new FConnexion());
        }
    }
}