using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN1
{
    public partial class frmNhanVien : Form
    {
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public decimal LuongCB { get; set; }
        public bool IsEdit { get; set; }   // true = đang Sửa, false = đang Thêm

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtMSNV.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập MSNV!");
                txtMSNV.Focus();
                return;
            }
            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!");
                txtTen.Focus();
                return;
            }
            decimal luong;
            if (!decimal.TryParse(txtLuong.Text.Trim(), out luong) || luong < 0)
            {
                MessageBox.Show("Lương căn bản phải là số hợp lệ!");
                txtLuong.Focus();
                return;
            }

            // Gán dữ liệu vào thuộc tính để form chính lấy
            MSNV = txtMSNV.Text.Trim();
            TenNV = txtTen.Text.Trim();
            LuongCB = luong;

            this.DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
