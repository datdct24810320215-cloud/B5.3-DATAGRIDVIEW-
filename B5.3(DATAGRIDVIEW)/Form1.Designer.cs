namespace B5._3_DATAGRIDVIEW_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.nudUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.labelHint = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            // 
            // Form1
            // 
            this.SuspendLayout();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientSize = new System.Drawing.Size(1000, 640);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm - Bài 5.3";
            // 
            // grpProduct
            // 
            this.grpProduct.SuspendLayout();
            this.grpProduct.Location = new System.Drawing.Point(15, 15);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(420, 320);
            this.grpProduct.TabIndex = 0;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Thông tin sản phẩm";
            this.grpProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // 
            // Labels and inputs inside grpProduct
            // 
            // Label Mã SP
            var lblId = new System.Windows.Forms.Label();
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(15, 35);
            lblId.Name = "lblId";
            lblId.Size = new System.Drawing.Size(60, 23);
            lblId.Text = "Mã SP:";
            // txtProductId
            this.txtProductId.Location = new System.Drawing.Point(150, 32);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(250, 27);
            this.txtProductId.TabIndex = 0;
            this.txtProductId.ReadOnly = true;
            // Label Tên SP
            var lblName = new System.Windows.Forms.Label();
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(15, 75);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(63, 23);
            lblName.Text = "Tên SP:";
            // txtProductName
            this.txtProductName.Location = new System.Drawing.Point(150, 72);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(250, 27);
            this.txtProductName.TabIndex = 1;
            // Label Đơn giá
            var lblPrice = new System.Windows.Forms.Label();
            lblPrice.AutoSize = true;
            lblPrice.Location = new System.Drawing.Point(15, 115);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new System.Drawing.Size(109, 23);
            lblPrice.Text = "Đơn giá (VNĐ):";
            // nudUnitPrice
            this.nudUnitPrice.Location = new System.Drawing.Point(150, 112);
            this.nudUnitPrice.Name = "nudUnitPrice";
            this.nudUnitPrice.Size = new System.Drawing.Size(250, 27);
            this.nudUnitPrice.Minimum = 0;
            this.nudUnitPrice.Maximum = 1000000000;
            this.nudUnitPrice.DecimalPlaces = 0;
            this.nudUnitPrice.ThousandsSeparator = true;
            this.nudUnitPrice.TabIndex = 2;
            // Label Số lượng
            var lblQty = new System.Windows.Forms.Label();
            lblQty.AutoSize = true;
            lblQty.Location = new System.Drawing.Point(15, 155);
            lblQty.Name = "lblQty";
            lblQty.Size = new System.Drawing.Size(72, 23);
            lblQty.Text = "Số lượng:";
            // nudQuantity
            this.nudQuantity.Location = new System.Drawing.Point(150, 152);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(250, 27);
            this.nudQuantity.Minimum = 0;
            this.nudQuantity.Maximum = 1000000;
            this.nudQuantity.TabIndex = 3;
            // Label Danh mục
            var lblCat = new System.Windows.Forms.Label();
            lblCat.AutoSize = true;
            lblCat.Location = new System.Drawing.Point(15, 195);
            lblCat.Name = "lblCat";
            lblCat.Size = new System.Drawing.Size(84, 23);
            lblCat.Text = "Danh mục:";
            // cboCategory
            this.cboCategory.Location = new System.Drawing.Point(150, 192);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(250, 27);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.TabIndex = 4;
            // lblStatus
            this.lblStatus.Location = new System.Drawing.Point(15, 250);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(390, 30);
            this.lblStatus.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Text = "";
            // Add controls to grpProduct
            this.grpProduct.Controls.Add(lblId);
            this.grpProduct.Controls.Add(this.txtProductId);
            this.grpProduct.Controls.Add(lblName);
            this.grpProduct.Controls.Add(this.txtProductName);
            this.grpProduct.Controls.Add(lblPrice);
            this.grpProduct.Controls.Add(this.nudUnitPrice);
            this.grpProduct.Controls.Add(lblQty);
            this.grpProduct.Controls.Add(this.nudQuantity);
            this.grpProduct.Controls.Add(lblCat);
            this.grpProduct.Controls.Add(this.cboCategory);
            this.grpProduct.Controls.Add(this.lblStatus);
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            // 
            // grpActions
            // 
            this.grpActions.SuspendLayout();
            this.grpActions.Location = new System.Drawing.Point(15, 350);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(420, 250);
            this.grpActions.TabIndex = 1;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Chức năng";
            this.grpActions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(15, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 30);
            this.txtSearch.TabIndex = 5;
            // btnSearch
            this.btnSearch.Location = new System.Drawing.Point(325, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.BackColor = System.Drawing.Color.LightBlue;
            this.btnSearch.UseVisualStyleBackColor = true;
            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(15, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 45);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.UseVisualStyleBackColor = true;
            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(150, 80);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 45);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.BackColor = System.Drawing.Color.LightYellow;
            this.btnEdit.UseVisualStyleBackColor = true;
            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(285, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.BackColor = System.Drawing.Color.LightCoral;
            this.btnDelete.UseVisualStyleBackColor = true;
            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(15, 140);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(390, 45);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRefresh.UseVisualStyleBackColor = true;
            // labelHint
            this.labelHint.Location = new System.Drawing.Point(15, 200);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(390, 30);
            this.labelHint.ForeColor = System.Drawing.Color.DimGray;
            this.labelHint.Text = "💡 Click 1 dòng trên bảng để đổ dữ liệu lên các ô nhập liệu";
            // Add controls to grpActions
            this.grpActions.Controls.Add(this.txtSearch);
            this.grpActions.Controls.Add(this.btnSearch);
            this.grpActions.Controls.Add(this.btnAdd);
            this.grpActions.Controls.Add(this.btnEdit);
            this.grpActions.Controls.Add(this.btnDelete);
            this.grpActions.Controls.Add(this.btnRefresh);
            this.grpActions.Controls.Add(this.labelHint);
            this.grpActions.ResumeLayout(false);
            this.grpActions.PerformLayout();
            // 
            // dgvProducts
            // 
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.dgvProducts.Location = new System.Drawing.Point(450, 15);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(530, 585);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            // 
            // Add top-level controls to form
            // 
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.dgvProducts);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.NumericUpDown nudUnitPrice;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.DataGridView dgvProducts;
    }
}
