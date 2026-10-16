using RetailInventoryApp.Data;

namespace RetailInventoryApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            DatabaseHelper.InitializeDatabase();

            Application.Run(new MainForm());
        }
    }
}