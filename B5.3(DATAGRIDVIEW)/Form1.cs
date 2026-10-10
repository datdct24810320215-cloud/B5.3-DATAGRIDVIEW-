#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace B5._3_DATAGRIDVIEW_
{
    public partial class Form1 : Form
    {
        private readonly List<Product> _products = new List<Product>();
        private BindingSource _bindingSource = new BindingSource();
        private int _nextId = 1;

        public Form1()
        {
            InitializeComponent();

            // Wire events
            this.Load += Form1_Load;
            btnAdd.Click     += BtnAdd_Click;
            btnEdit.Click    += BtnEdit_Click;
            btnDelete.Click  += BtnDelete_Click;
            btnSearch.Click  += BtnSearch_Click;
            btnRefresh.Click += BtnRefresh_Click;
            txtSearch.KeyDown += TxtSearch_KeyDown;    // Enter to search
            dgvProducts.SelectionChanged += DgvProducts_SelectionChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Populate category ComboBox
            cboCategory.Items.Clear();
            cboCategory.Items.AddRange(new object[]
            {
                "Điện tử", "Gia dụng", "Thực phẩm", "Văn phòng phẩm", "Thời trang"
            });
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;

            // Bind DataGridView to BindingSource
            _bindingSource.DataSource = _products;
            dgvProducts.DataSource = _bindingSource;

            // Set column headers (Vietnamese)
            ConfigureColumns();

            // Seed some sample data
            _products.Add(new Product { ProductId = _nextId++, ProductName = "Laptop Dell", 
                UnitPrice = 15000000m, Quantity = 5, Category = "Điện tử" });
            _products.Add(new Product { ProductId = _nextId++, ProductName = "Nồi cơm điện", 
                UnitPrice = 850000m, Quantity = 12, Category = "Gia dụng" });
            _products.Add(new Product { ProductId = _nextId++, ProductName = "Sữa Vinamilk", 
                UnitPrice = 25000m, Quantity = 100, Category = "Thực phẩm" });

            RefreshGrid();
        }

        private void ConfigureColumns()
        {
            dgvProducts.AutoGenerateColumns = true;
            dgvProducts.Columns.Clear();
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn 
                { DataPropertyName = "ProductId",   HeaderText = "Mã SP",      FillWeight = 12 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn 
                { DataPropertyName = "ProductName", HeaderText = "Tên SP",     FillWeight = 30 });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn 
                { DataPropertyName = "UnitPrice",   HeaderText = "Đơn giá",    FillWeight = 20,
                  DefaultCellStyle = new DataGridViewCellStyle 
                    { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn 
                { DataPropertyName = "Quantity",    HeaderText = "Số lượng",   FillWeight = 12,
                  DefaultCellStyle = new DataGridViewCellStyle 
                    { Alignment = DataGridViewContentAlignment.MiddleRight } });
            dgvProducts.Columns.Add(new DataGridViewTextBoxColumn 
                { DataPropertyName = "Category",    HeaderText = "Danh mục",   FillWeight = 20 });
        }

        private void RefreshGrid()
        {
            _bindingSource.ResetBindings(false);
            dgvProducts.Refresh();
            lblStatus.Text = $"📦 Tổng số sản phẩm: {_products.Count}";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out string error))
            {
                MessageBox.Show(error, "Lỗi nhập liệu", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product p = new Product
            {
                ProductId = _nextId++,
                ProductName = txtProductName.Text.Trim(),
                UnitPrice = nudUnitPrice.Value,
                Quantity = (int)nudQuantity.Value,
                Category = cboCategory.SelectedItem?.ToString() ?? ""
            };
            _products.Add(p);
            RefreshGrid();
            ClearInputs();

            MessageBox.Show($"Đã thêm sản phẩm: {p.ProductName}", 
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa!", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product p = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (p == null) return;

            if (!ValidateInput(out string error))
            {
                MessageBox.Show(error, "Lỗi nhập liệu", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            p.ProductName = txtProductName.Text.Trim();
            p.UnitPrice   = nudUnitPrice.Value;
            p.Quantity    = (int)nudQuantity.Value;
            p.Category    = cboCategory.SelectedItem?.ToString() ?? "";

            RefreshGrid();
            MessageBox.Show("Đã cập nhật sản phẩm!", 
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa!", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product p = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (p == null) return;

            DialogResult r = MessageBox.Show(
                $"Bạn có chắc muốn xóa sản phẩm \"{p.ProductName}\"?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                _products.Remove(p);
                RefreshGrid();
                ClearInputs();
                MessageBox.Show("Đã xóa sản phẩm!", 
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm cần tìm!", 
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var matches = _products
                .Where(p => p.ProductName.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            if (matches.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy sản phẩm nào có tên chứa \"{keyword}\"!", 
                    "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Highlight matching rows
            dgvProducts.ClearSelection();
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                if (row.DataBoundItem is Product p && matches.Contains(p))
                {
                    row.Selected = true;
                }
            }

            MessageBox.Show($"Tìm thấy {matches.Count} sản phẩm khớp!", 
                "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnSearch_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ClearInputs();
            RefreshGrid();
            dgvProducts.ClearSelection();
        }

        private void DgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;
            Product p = dgvProducts.CurrentRow.DataBoundItem as Product;
            if (p == null) return;

            txtProductId.Text   = p.ProductId.ToString();
            txtProductName.Text = p.ProductName;
            try { nudUnitPrice.Value  = p.UnitPrice; } catch { nudUnitPrice.Value = 0; }
            try { nudQuantity.Value   = p.Quantity; } catch { nudQuantity.Value = 0; }
            if (cboCategory.Items.Contains(p.Category))
                cboCategory.SelectedItem = p.Category;
        }

        private bool ValidateInput(out string error)
        {
            error = null;
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                error = "Tên sản phẩm không được để trống!";
                txtProductName.Focus();
                return false;
            }
            if (nudUnitPrice.Value <= 0)
            {
                error = "Đơn giá phải lớn hơn 0!";
                nudUnitPrice.Focus();
                return false;
            }
            if (nudQuantity.Value <= 0)
            {
                error = "Số lượng phải lớn hơn 0!";
                nudQuantity.Focus();
                return false;
            }
            if (cboCategory.SelectedItem == null)
            {
                error = "Vui lòng chọn danh mục!";
                cboCategory.Focus();
                return false;
            }
            return true;
        }

        private void ClearInputs()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            nudUnitPrice.Value = 0;
            nudQuantity.Value = 0;
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            txtProductName.Focus();
        }
    }
}

