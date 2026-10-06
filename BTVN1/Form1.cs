using System;
using System.Windows.Forms;

namespace BTVN1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.IsEdit = false;

            if (f.ShowDialog() == DialogResult.OK)
            {
                // Kiểm tra trùng MSNV
                foreach (DataGridViewRow row in dgvNhanVien.Rows)
                {
                    if (row.Cells["colMSNV"].Value != null &&
                        row.Cells["colMSNV"].Value.ToString() == f.MSNV)
                    {
                        MessageBox.Show("MSNV đã tồn tại!");
                        return;
                    }
                }

                dgvNhanVien.Rows.Add(f.MSNV, f.TenNV, f.LuongCB);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!");
                return;
            }

            DataGridViewRow row = dgvNhanVien.CurrentRow;
            if (row == null || row.IsNewRow || row.Cells["colMSNV"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn dòng có dữ liệu để sửa!");
                return;
            }

            frmNhanVien f = new frmNhanVien();
            f.IsEdit = true;
            f.MSNV = row.Cells["colMSNV"].Value.ToString();
            f.TenNV = row.Cells["colTenNV"].Value.ToString();
            f.LuongCB = Convert.ToDecimal(row.Cells["colLuongCB"].Value);

            if (f.ShowDialog() == DialogResult.OK)
            {
                row.Cells["colTenNV"].Value = f.TenNV;
                row.Cells["colLuongCB"].Value = f.LuongCB;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa nhân viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                dgvNhanVien.Rows.Remove(dgvNhanVien.CurrentRow);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

