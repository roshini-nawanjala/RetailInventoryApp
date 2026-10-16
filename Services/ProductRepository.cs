using Microsoft.Data.Sqlite;
using RetailInventoryApp.Models;

namespace RetailInventoryApp.Services
{
    public class ProductRepository
    {
        private readonly string connectionString =
            "Data Source=RetailInventory.db";

        public void AddProduct(Product product)
        {
            using var connection = new SqliteConnection(connectionString);

            connection.Open();

            string query = @"
                INSERT INTO Products
                (ProductName, Price, StockQuantity)
                VALUES
                (@ProductName, @Price, @StockQuantity)";

            using var command = new SqliteCommand(query, connection);

            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@StockQuantity", product.StockQuantity);

            command.ExecuteNonQuery();
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new();

            using var connection = new SqliteConnection(connectionString);

            connection.Open();

            string query = "SELECT * FROM Products";

            using var command = new SqliteCommand(query, connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                products.Add(new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    ProductName = reader["ProductName"].ToString()!,
                    Price = Convert.ToDouble(reader["Price"]),
                    StockQuantity = Convert.ToInt32(reader["StockQuantity"])
                });
            }

            return products;
        }

        public Product? GetProductByName(string productName)
        {
            using var connection = new SqliteConnection(connectionString);

            connection.Open();

            string query =
                "SELECT * FROM Products WHERE ProductName = @ProductName";

            using var command = new SqliteCommand(query, connection);

            command.Parameters.AddWithValue("@ProductName", productName);

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    ProductName = reader["ProductName"].ToString()!,
                    Price = Convert.ToDouble(reader["Price"]),
                    StockQuantity = Convert.ToInt32(reader["StockQuantity"])
                };
            }

            return null;
        }

        public void UpdateProduct(Product product)
        {
            using var connection = new SqliteConnection(connectionString);

            connection.Open();

            string query = @"
                UPDATE Products
                SET ProductName=@name,
                    Price=@price,
                    StockQuantity=@stock
                WHERE Id=@id";

            using var command = new SqliteCommand(query, connection);

            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@name", product.ProductName);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@stock", product.StockQuantity);

            command.ExecuteNonQuery();
        }

        public void DeleteProduct(int id)
        {
            using var connection = new SqliteConnection(connectionString);

            connection.Open();

            string query = "DELETE FROM Products WHERE Id=@id";

            using var command = new SqliteCommand(query, connection);

            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
        }

        public void UpdateStock(int productId, int newStock)
        {
            using var connection = new SqliteConnection(connectionString);

            connection.Open();

            string query =
                "UPDATE Products SET StockQuantity=@stock WHERE Id=@id";

            using var command = new SqliteCommand(query, connection);

            command.Parameters.AddWithValue("@stock", newStock);
            command.Parameters.AddWithValue("@id", productId);

            command.ExecuteNonQuery();
        }
    }
}