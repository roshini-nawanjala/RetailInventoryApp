using System;
using System.Windows.Forms;
using RetailInventoryApp.Models;
using RetailInventoryApp.Services;
using System.Drawing;

namespace RetailInventoryApp.Forms
{
    public partial class SalesForm : Form
    {
        private ProductRepository productRepository = new ProductRepository();
        private SaleRepository saleRepository = new SaleRepository();

        public SalesForm()
        {
            InitializeComponent();

            LoadProducts();
            LoadSales();

            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
        }

        private void LoadProducts()
        {
            var products = productRepository.GetAllProducts();

            cmbProducts.DataSource = products;
            cmbProducts.DisplayMember = "ProductName";
            cmbProducts.ValueMember = "Id";
        }

        private void LoadSales()
        {
            dgvSales.AutoGenerateColumns = true;

            dgvSales.DataSource = null;
            dgvSales.DataSource = saleRepository.GetAllSales();

            dgvSales.Columns["Id"].HeaderText = "ID";
            dgvSales.Columns["ProductId"].Visible = false;

            dgvSales.Columns["ProductName"].HeaderText = "Product";
            dgvSales.Columns["Quantity"].HeaderText = "Sold Quantity";
            dgvSales.Columns["UnitPrice"].HeaderText = "Unit Price";
            dgvSales.Columns["TotalAmount"].HeaderText = "Total Amount";
            dgvSales.Columns["SaleDate"].HeaderText = "Sale Date";

            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.ReadOnly = true;
            dgvSales.AllowUserToAddRows = false;
        }

        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is Product product)
            {
                txtUnitPrice.Text = product.Price.ToString();

                lblAvailableStock.Text =
                    "Available Stock : " + product.StockQuantity;

                if (product.StockQuantity < 5)
                {
                    lblAvailableStock.ForeColor = Color.Red;
                }
                else
                {
                    lblAvailableStock.ForeColor = Color.Green;
                }

                CalculateTotal();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            if (cmbProducts.SelectedItem is Product product &&
                int.TryParse(txtQuantity.Text, out int quantity))
            {
                double total = product.Price * quantity;
                txtTotalAmount.Text = total.ToString();
            }
            else
            {
                txtTotalAmount.Clear();
            }
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            if (cmbProducts.SelectedItem is not Product product)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Enter a valid quantity.");
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            if (quantity > product.StockQuantity)
            {
                MessageBox.Show(
                    "Not enough stock available!",
                    "Stock Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Sale sale = new Sale
            {
                ProductId = product.Id,
                ProductName = product.ProductName,
                Quantity = quantity,
                UnitPrice = product.Price,
                TotalAmount = product.Price * quantity,
                SaleDate = DateTime.Now
            };

            // Save Sale
            saleRepository.AddSale(sale);

            // Update Stock
            int newStock = product.StockQuantity - quantity;
            productRepository.UpdateStock(product.Id, newStock);

            // Low Stock Alert
            if (newStock <= 5)
            {
                MessageBox.Show(
                    $"{product.ProductName} stock is running low!\nRemaining Stock: {newStock}",
                    "Low Stock Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            MessageBox.Show(
                "Sale saved successfully!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LoadSales();
            LoadProducts();

            Product? updatedProduct =
                productRepository.GetProductByName(product.ProductName);

            if (updatedProduct != null)
            {
                lblAvailableStock.Text =
                    "Available Stock : " + updatedProduct.StockQuantity;

                lblAvailableStock.ForeColor =
                    updatedProduct.StockQuantity <= 5
                    ? Color.Red
                    : Color.Green;
            }

            txtQuantity.Clear();
            txtTotalAmount.Clear();

            txtQuantity.Focus();
        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }
    }
}