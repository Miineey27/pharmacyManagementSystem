namespace pharmacy
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
<<<<<<< HEAD
            Application.Run(new Login());
=======
            Application.Run(new Dashboard());
>>>>>>> 03665c860a1a404eb87e9c6483237c50d29bb09e
        }
    }
}