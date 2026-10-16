using Microsoft.Data.Sqlite;
using RetailInventoryApp.Data;
using RetailInventoryApp.Models;

namespace RetailInventoryApp.Services
{
    public class SaleRepository
    {
        public void AddSale(Sale sale)
        {
            using var connection = DatabaseHelper.GetConnection();

            connection.Open();

            string query = @"
            INSERT INTO Sales
            (ProductId, ProductName, Quantity, UnitPrice, TotalAmount, SaleDate)
            VALUES
            (@ProductId, @ProductName, @Quantity, @UnitPrice, @TotalAmount, @SaleDate)";

            SqliteCommand command = new(query, connection);

            command.Parameters.AddWithValue("@ProductId", sale.ProductId);
            command.Parameters.AddWithValue("@ProductName", sale.ProductName);
            command.Parameters.AddWithValue("@Quantity", sale.Quantity);
            command.Parameters.AddWithValue("@UnitPrice", sale.UnitPrice);
            command.Parameters.AddWithValue("@TotalAmount", sale.TotalAmount);
            command.Parameters.AddWithValue("@SaleDate", sale.SaleDate.ToString("yyyy-MM-dd HH:mm:ss"));

            command.ExecuteNonQuery();
        }

        public List<Sale> GetAllSales()
        {
            List<Sale> sales = new();

            using var connection = DatabaseHelper.GetConnection();

            connection.Open();

            string query = "SELECT * FROM Sales ORDER BY Id DESC";

            SqliteCommand command = new(query, connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                sales.Add(new Sale
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    ProductId = Convert.ToInt32(reader["ProductId"]),
                    ProductName = reader["ProductName"].ToString()!,
                    Quantity = Convert.ToInt32(reader["Quantity"]),
                    UnitPrice = Convert.ToDouble(reader["UnitPrice"]),
                    TotalAmount = Convert.ToDouble(reader["TotalAmount"]),
                    SaleDate = DateTime.Parse(reader["SaleDate"].ToString()!)
                });
            }

            return sales;
        }
    }
}