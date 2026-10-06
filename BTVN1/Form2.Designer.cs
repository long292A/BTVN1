namespace BTVN1
{
    partial class frmNhanVien
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMSNV = new TextBox();
            txtTen = new TextBox();
            txtLuong = new TextBox();
            btnDongY = new Button();
            btnBoQua = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 31);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "MSNV:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 78);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 0;
            label2.Text = "Tên nhân viên:";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 129);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 0;
            label3.Text = "Lương cơ bản:";
            label3.Click += label1_Click;
            // 
            // txtMSNV
            // 
            txtMSNV.Location = new Point(144, 32);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(212, 27);
            txtMSNV.TabIndex = 1;
            txtMSNV.TextChanged += textBox1_TextChanged;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(144, 78);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(212, 27);
            txtTen.TabIndex = 2;
            // 
            // txtLuong
            // 
            txtLuong.Location = new Point(144, 129);
            txtLuong.Name = "txtLuong";
            txtLuong.Size = new Size(212, 27);
            txtLuong.TabIndex = 3;
            // 
            // btnDongY
            // 
            btnDongY.Location = new Point(110, 247);
            btnDongY.Name = "btnDongY";
            btnDongY.Size = new Size(94, 29);
            btnDongY.TabIndex = 4;
            btnDongY.Text = "Đồng ý";
            btnDongY.UseVisualStyleBackColor = true;
            btnDongY.Click += btnDongY_Click;
            // 
            // btnBoQua
            // 
            btnBoQua.Location = new Point(309, 247);
            btnBoQua.Name = "btnBoQua";
            btnBoQua.Size = new Size(94, 29);
            btnBoQua.TabIndex = 4;
            btnBoQua.Text = "Bỏ qua";
            btnBoQua.UseVisualStyleBackColor = true;
            btnBoQua.Click += btnBoQua_Click;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBoQua);
            Controls.Add(btnDongY);
            Controls.Add(txtLuong);
            Controls.Add(txtTen);
            Controls.Add(txtMSNV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNhanVien";
            Text = "Nhân Viên";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMSNV;
        private TextBox txtTen;
        private TextBox txtLuong;
        private Button btnDongY;
        private Button btnBoQua;
    }
}