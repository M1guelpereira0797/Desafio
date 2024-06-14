namespace Preentrega_Desafio_2
{
    internal static class Program
    {
        public static Form1 form1;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(form1 = new Form1());
        }
    }
}