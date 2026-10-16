namespace RetailInventoryApp.Forms
{
    partial class ProductsForm
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
            pnlProductDetails = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtStockQty = new TextBox();
            label3 = new Label();
            txtPrice = new TextBox();
            label2 = new Label();
            txtProductName = new TextBox();
            label1 = new Label();
            lblTitle = new Label();
            pnlProductList = new Panel();
            dgvProducts = new DataGridView();
            label4 = new Label();
            pnlProductDetails.SuspendLayout();
            pnlProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlProductDetails
            // 
            pnlProductDetails.BorderStyle = BorderStyle.FixedSingle;
            pnlProductDetails.Controls.Add(btnDelete);
            pnlProductDetails.Controls.Add(btnUpdate);
            pnlProductDetails.Controls.Add(btnAdd);
            pnlProductDetails.Controls.Add(txtStockQty);
            pnlProductDetails.Controls.Add(label3);
            pnlProductDetails.Controls.Add(txtPrice);
            pnlProductDetails.Controls.Add(label2);
            pnlProductDetails.Controls.Add(txtProductName);
            pnlProductDetails.Controls.Add(label1);
            pnlProductDetails.Controls.Add(lblTitle);
            pnlProductDetails.Dock = DockStyle.Left;
            pnlProductDetails.Location = new Point(15, 15);
            pnlProductDetails.Name = "pnlProductDetails";
            pnlProductDetails.Padding = new Padding(20);
            pnlProductDetails.Size = new Size(320, 581);
            pnlProductDetails.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(215, 330);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 35);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(120, 330);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(85, 35);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 330);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 35);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStockQty
            // 
            txtStockQty.Location = new Point(20, 255);
            txtStockQty.Name = "txtStockQty";
            txtStockQty.Size = new Size(280, 23);
            txtStockQty.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 230);
            label3.Name = "label3";
            label3.Size = new Size(91, 17);
            label3.TabIndex = 5;
            label3.Text = "Stock Quantity";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(20, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(280, 23);
            txtPrice.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 155);
            label2.Name = "label2";
            label2.Size = new Size(36, 17);
            label2.TabIndex = 3;
            label2.Text = "Price";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(20, 105);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(280, 23);
            txtProductName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 80);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 1;
            label1.Text = "Product Name";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(80, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(148, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Product Details";
            // 
            // pnlProductList
            // 
            pnlProductList.BorderStyle = BorderStyle.FixedSingle;
            pnlProductList.Controls.Add(dgvProducts);
            pnlProductList.Controls.Add(label4);
            pnlProductList.Dock = DockStyle.Fill;
            pnlProductList.Location = new Point(335, 15);
            pnlProductList.Name = "pnlProductList";
            pnlProductList.Padding = new Padding(20);
            pnlProductList.Size = new Size(734, 581);
            pnlProductList.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeColumns = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(20, 70);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(680, 500);
            dgvProducts.TabIndex = 1;
            dgvProducts.CellClick += dgvProducts_CellClick;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 20);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 0;
            label4.Text = "Product List";
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1084, 611);
            Controls.Add(pnlProductList);
            Controls.Add(pnlProductDetails);
            Name = "ProductsForm";
            Padding = new Padding(15);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Product Management";
            Load += ProductsForm_Load;
            pnlProductDetails.ResumeLayout(false);
            pnlProductDetails.PerformLayout();
            pnlProductList.ResumeLayout(false);
            pnlProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlProductDetails;
        private Panel pnlProductList;
        private Label lblTitle;
        private TextBox txtStockQty;
        private Label label3;
        private TextBox txtPrice;
        private Label label2;
        private TextBox txtProductName;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private DataGridView dgvProducts;
        private Label label4;
    }
}