namespace BTVN1
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
            dgvNhanVien = new DataGridView();
            colMSNV = new DataGridViewTextBoxColumn();
            colTenNV = new DataGridViewTextBoxColumn();
            colLuongCB = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.BackgroundColor = Color.White;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Columns.AddRange(new DataGridViewColumn[] { colMSNV, colTenNV, colLuongCB });
            dgvNhanVien.Location = new Point(44, 41);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.Size = new Size(429, 188);
            dgvNhanVien.TabIndex = 0;
            // 
            // colMSNV
            // 
            colMSNV.HeaderText = "Mã Nhân Viên";
            colMSNV.MinimumWidth = 6;
            colMSNV.Name = "colMSNV";
            colMSNV.Width = 125;
            // 
            // colTenNV
            // 
            colTenNV.HeaderText = "Tên Nhân Viên";
            colTenNV.MinimumWidth = 6;
            colTenNV.Name = "colTenNV";
            colTenNV.Width = 125;
            // 
            // colLuongCB
            // 
            colLuongCB.HeaderText = "Lương Cơ Bản";
            colLuongCB.MinimumWidth = 6;
            colLuongCB.Name = "colLuongCB";
            colLuongCB.Width = 125;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(583, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(583, 101);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(583, 160);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(583, 222);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(94, 29);
            btnDong.TabIndex = 1;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDong);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvNhanVien);
            Name = "Form1";
            Text = "List View";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNhanVien;
        private DataGridViewTextBoxColumn colMSNV;
        private DataGridViewTextBoxColumn colTenNV;
        private DataGridViewTextBoxColumn colLuongCB;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnDong;
    }
}
