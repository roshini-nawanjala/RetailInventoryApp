using System;
using System.Windows.Forms;
using RetailInventoryApp.Models;
using RetailInventoryApp.Services;

namespace RetailInventoryApp.Forms
{
    public partial class ProductsForm : Form
    {
        private ProductRepository repository = new ProductRepository();

        private int selectedProductId = 0;

        public ProductsForm()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter product name.");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (!int.TryParse(txtStockQty.Text, out int stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Price must be greater than zero.");
                return;
            }

            if (stock < 0)
            {
                MessageBox.Show("Stock quantity cannot be negative.");
                return;
            }

            Product product = new Product
            {
                ProductName = txtProductName.Text,
                Price = price,
                StockQuantity = stock
            };

            repository.AddProduct(product);

            MessageBox.Show("Product added successfully!");

            LoadProducts();

            txtProductName.Clear();
            txtPrice.Clear();
            txtStockQty.Clear();

            txtProductName.Focus();
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = repository.GetAllProducts();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];

                selectedProductId = Convert.ToInt32(row.Cells["Id"].Value);

                txtProductName.Text = row.Cells["ProductName"].Value?.ToString();
                txtPrice.Text = row.Cells["Price"].Value?.ToString();
                txtStockQty.Text = row.Cells["StockQuantity"].Value?.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product first!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter product name.");
                return;
            }

            if (!double.TryParse(txtPrice.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (!int.TryParse(txtStockQty.Text, out int stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Price must be greater than zero.");
                return;
            }

            if (stock < 0)
            {
                MessageBox.Show("Stock quantity cannot be negative.");
                return;
            }

            Product product = new Product
            {
                Id = selectedProductId,
                ProductName = txtProductName.Text,
                Price = price,
                StockQuantity = stock
            };

            repository.UpdateProduct(product);

            MessageBox.Show("Product updated successfully!");

            LoadProducts();

            txtProductName.Clear();
            txtPrice.Clear();
            txtStockQty.Clear();

            selectedProductId = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product first!");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this product?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                repository.DeleteProduct(selectedProductId);

                MessageBox.Show("Product deleted successfully!");

                LoadProducts();

                txtProductName.Clear();
                txtPrice.Clear();
                txtStockQty.Clear();

                selectedProductId = 0;
            }
        }
    }
}