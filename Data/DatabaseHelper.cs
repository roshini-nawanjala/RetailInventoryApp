using Microsoft.Data.Sqlite;

namespace RetailInventoryApp.Data
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
            "Data Source=RetailInventory.db";

        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            using var connection = GetConnection();

            connection.Open();

            // Products Table
            string productsTable = @"
            CREATE TABLE IF NOT EXISTS Products (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                ProductName TEXT NOT NULL,
                Price REAL NOT NULL,
                StockQuantity INTEGER NOT NULL
            );";

            SqliteCommand productCommand = new(productsTable, connection);
            productCommand.ExecuteNonQuery();

            // Sales Table
            string salesTable = @"
            CREATE TABLE IF NOT EXISTS Sales (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                ProductId INTEGER NOT NULL,
                ProductName TEXT NOT NULL,
                Quantity INTEGER NOT NULL,
                UnitPrice REAL NOT NULL,
                TotalAmount REAL NOT NULL,
                SaleDate TEXT NOT NULL
            );";

            SqliteCommand salesCommand = new(salesTable, connection);
            salesCommand.ExecuteNonQuery();
        }
    }
}