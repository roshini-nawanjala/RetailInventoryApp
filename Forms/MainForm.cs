using RetailInventoryApp.Forms;
using RetailInventoryApp.Services;
using System.Linq;
using System.Drawing;

namespace RetailInventoryApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoadLowStockCount();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnlProducts_Click(sender, e);
        }

        private void pnlProducts_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();

            LoadLowStockCount();
        }

        private void pnlSales_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.ShowDialog();

            LoadLowStockCount();
        }

        private void pnlStock_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.ShowDialog();

            LoadLowStockCount();
        }
        private void pnlTransactions_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.ShowDialog();

            LoadLowStockCount();
        }

        private ProductRepository productRepository = new ProductRepository();
        private SaleRepository saleRepository = new SaleRepository();

        private void LoadLowStockCount()
        {
            var products = productRepository.GetAllProducts();
            var sales = saleRepository.GetAllSales();

            int totalProducts = products.Count;
            int totalSales = sales.Count;
            int lowStockCount = products.Count(p => p.StockQuantity <= 5);

            lblTotalProducts.Text = totalProducts.ToString();
            lblTotalSales.Text = totalSales.ToString();
            lblLowStockCount.Text = lowStockCount.ToString();

            lblLowStock.Text =
                "⚠ Low Stock Products : " + lowStockCount;

            if (lowStockCount > 0)
            {
                lblLowStock.ForeColor = Color.Red;
            }
            else
            {
                lblLowStock.ForeColor = Color.Green;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pnlSales_Click(sender, e);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pnlStock_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pnlTransactions_Click(sender, e);
        }
    }
}