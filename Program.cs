namespace WindowsHooks
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
            Keycodes keycodes = new Keycodes();
            InputSimulator inputSimulator = new InputSimulator();
            MouseHooks mouseHooks = new MouseHooks();
            KeyboardHooks keyboardHooks = new KeyboardHooks();

            Application.Run(new Form1());
        }
    }
}