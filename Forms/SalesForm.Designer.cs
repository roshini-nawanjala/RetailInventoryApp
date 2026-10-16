namespace RetailInventoryApp.Forms
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblProduct = new Label();
            cmbProducts = new ComboBox();
            lblUnitPrice = new Label();
            txtUnitPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblTotalAmount = new Label();
            txtTotalAmount = new TextBox();
            btnSaveSale = new Button();
            pnlSales = new Panel();
            lblAvailableStock = new Label();
            dgvSales = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            pnlSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).BeginInit();
            SuspendLayout();
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Font = new Font("Segoe UI", 10F);
            lblProduct.Location = new Point(30, 30);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(57, 19);
            lblProduct.TabIndex = 0;
            lblProduct.Text = "Product";
            // 
            // cmbProducts
            // 
            cmbProducts.BackColor = SystemColors.Window;
            cmbProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducts.FormattingEnabled = true;
            cmbProducts.Location = new Point(180, 25);
            cmbProducts.Name = "cmbProducts";
            cmbProducts.Size = new Size(121, 25);
            cmbProducts.TabIndex = 1;
            cmbProducts.SelectedIndexChanged += cmbProducts_SelectedIndexChanged;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI", 10F);
            lblUnitPrice.Location = new Point(30, 80);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(68, 19);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "Unit Price";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BackColor = SystemColors.Window;
            txtUnitPrice.Location = new Point(180, 75);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(121, 25);
            txtUnitPrice.TabIndex = 3;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 10F);
            lblQuantity.Location = new Point(550, 30);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(93, 19);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Sold Quantity";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(700, 25);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(121, 25);
            txtQuantity.TabIndex = 5;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.BackColor = SystemColors.Control;
            lblTotalAmount.Font = new Font("Segoe UI", 10F);
            lblTotalAmount.Location = new Point(550, 80);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(92, 19);
            lblTotalAmount.TabIndex = 6;
            lblTotalAmount.Text = "Total Amount";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BackColor = SystemColors.Window;
            txtTotalAmount.Location = new Point(700, 75);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(121, 25);
            txtTotalAmount.TabIndex = 7;
            // 
            // btnSaveSale
            // 
            btnSaveSale.BackColor = SystemColors.GradientInactiveCaption;
            btnSaveSale.Font = new Font("Segoe UI", 10F);
            btnSaveSale.Location = new Point(388, 153);
            btnSaveSale.Name = "btnSaveSale";
            btnSaveSale.Size = new Size(180, 45);
            btnSaveSale.TabIndex = 8;
            btnSaveSale.Text = "Save Sale";
            btnSaveSale.UseVisualStyleBackColor = false;
            btnSaveSale.Click += btnSaveSale_Click;
            // 
            // pnlSales
            // 
            pnlSales.BorderStyle = BorderStyle.FixedSingle;
            pnlSales.Controls.Add(lblAvailableStock);
            pnlSales.Controls.Add(lblProduct);
            pnlSales.Controls.Add(btnSaveSale);
            pnlSales.Controls.Add(cmbProducts);
            pnlSales.Controls.Add(txtQuantity);
            pnlSales.Controls.Add(txtTotalAmount);
            pnlSales.Controls.Add(lblQuantity);
            pnlSales.Controls.Add(lblUnitPrice);
            pnlSales.Controls.Add(lblTotalAmount);
            pnlSales.Controls.Add(txtUnitPrice);
            pnlSales.Location = new Point(93, 43);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(899, 220);
            pnlSales.TabIndex = 9;
            // 
            // lblAvailableStock
            // 
            lblAvailableStock.AutoSize = true;
            lblAvailableStock.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAvailableStock.Location = new Point(423, 120);
            lblAvailableStock.Name = "lblAvailableStock";
            lblAvailableStock.Size = new Size(121, 17);
            lblAvailableStock.TabIndex = 9;
            lblAvailableStock.Text = "Available Stock : 0";
            // 
            // dgvSales
            // 
            dgvSales.AllowUserToAddRows = false;
            dgvSales.AllowUserToDeleteRows = false;
            dgvSales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSales.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvSales.DefaultCellStyle = dataGridViewCellStyle4;
            dgvSales.Location = new Point(12, 339);
            dgvSales.MultiSelect = false;
            dgvSales.Name = "dgvSales";
            dgvSales.ReadOnly = true;
            dgvSales.RowHeadersVisible = false;
            dgvSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSales.Size = new Size(1048, 398);
            dgvSales.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 11;
            label1.Text = "SALES MANAGEMENT ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(432, 291);
            label2.Name = "label2";
            label2.Size = new Size(186, 25);
            label2.TabIndex = 12;
            label2.Text = "Transaction History";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 749);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSales);
            Controls.Add(pnlSales);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Management";
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProduct;
        private ComboBox cmbProducts;
        private Label lblUnitPrice;
        private TextBox txtUnitPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Label lblTotalAmount;
        private TextBox txtTotalAmount;
        private Button btnSaveSale;
        private Panel pnlSales;
        private DataGridView dgvSales;
        private Label label1;
        private Label lblAvailableStock;
        private Label label2;
    }
}