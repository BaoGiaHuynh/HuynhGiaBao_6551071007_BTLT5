namespace Bai5
{
    partial class frmDonHang
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
            txtTenSP = new TextBox();
            label1 = new Label();
            numSoLuong = new NumericUpDown();
            label2 = new Label();
            txtDonGia = new TextBox();
            label3 = new Label();
            btnThem = new Button();
            lsvChiTiet = new ListView();
            lblTongTien = new Label();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            SuspendLayout();
            // 
            // txtTenSP
            // 
            txtTenSP.Location = new Point(202, 28);
            txtTenSP.Name = "txtTenSP";
            txtTenSP.Size = new Size(125, 27);
            txtTenSP.TabIndex = 0;
            txtTenSP.TextChanged += txtTenSP_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 35);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên sản phẩm";
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(202, 82);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(150, 27);
            numSoLuong.TabIndex = 2;
            numSoLuong.ValueChanged += numSoLuong_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 89);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 3;
            label2.Text = "Chọn số lượng";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(190, 140);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 4;
            txtDonGia.TextChanged += txtDonGia_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 147);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhập đơn giá";
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ActiveBorder;
            btnThem.Location = new Point(452, 69);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 6;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click_1;
            // 
            // lsvChiTiet
            // 
            lsvChiTiet.Location = new Point(71, 223);
            lsvChiTiet.Name = "lsvChiTiet";
            lsvChiTiet.Size = new Size(347, 215);
            lsvChiTiet.TabIndex = 7;
            lsvChiTiet.UseCompatibleStateImageBehavior = false;
            lsvChiTiet.SelectedIndexChanged += lsvChiTiet_SelectedIndexChanged;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(548, 325);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(72, 20);
            lblTongTien.TabIndex = 8;
            lblTongTien.Text = "Tổng tiền";
            lblTongTien.Click += lblTongTien_Click;
            // 
            // frmDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTongTien);
            Controls.Add(lsvChiTiet);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(txtDonGia);
            Controls.Add(label2);
            Controls.Add(numSoLuong);
            Controls.Add(label1);
            Controls.Add(txtTenSP);
            Name = "frmDonHang";
            Text = "frmDonHang";
            Load += frmDonHang_Load;
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTenSP;
        private Label label1;
        private NumericUpDown numSoLuong;
        private Label label2;
        private TextBox txtDonGia;
        private Label label3;
        private Button btnThem;
        private ListView lsvChiTiet;
        private Label lblTongTien;
    }
}