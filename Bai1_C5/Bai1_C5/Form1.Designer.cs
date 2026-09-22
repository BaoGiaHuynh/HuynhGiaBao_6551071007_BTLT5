namespace Bai1_C5
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
            txtMaSP = new TextBox();
            label1 = new Label();
            txtSoLuong = new TextBox();
            label2 = new Label();
            txtDonGia = new TextBox();
            label3 = new Label();
            btnThem = new Button();
            btnXoaTrang = new Button();
            lstKetQua = new ListBox();
            SuspendLayout();
            // 
            // txtMaSP
            // 
            txtMaSP.Location = new Point(182, 72);
            txtMaSP.Name = "txtMaSP";
            txtMaSP.Size = new Size(125, 27);
            txtMaSP.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 79);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã sp:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(525, 72);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 2;
            txtSoLuong.KeyPress += ChiNhapSo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(417, 79);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 3;
            label2.Text = "Số lượng:";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(182, 136);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(125, 27);
            txtDonGia.TabIndex = 4;
            txtDonGia.KeyPress += ChiNhapSo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 143);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 6;
            label3.Text = "Đơn giá:";
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ActiveBorder;
            btnThem.Location = new Point(417, 134);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 7;
            btnThem.Text = "Thêm (F2)";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = SystemColors.ActiveBorder;
            btnXoaTrang.Location = new Point(543, 134);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(137, 29);
            btnXoaTrang.TabIndex = 8;
            btnXoaTrang.Text = "Xóa trắng (F5)";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += btnXoaTrang_Click;
            // 
            // lstKetQua
            // 
            lstKetQua.FormattingEnabled = true;
            lstKetQua.Location = new Point(112, 217);
            lstKetQua.Name = "lstKetQua";
            lstKetQua.Size = new Size(600, 204);
            lstKetQua.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstKetQua);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnThem);
            Controls.Add(label3);
            Controls.Add(txtDonGia);
            Controls.Add(label2);
            Controls.Add(txtSoLuong);
            Controls.Add(label1);
            Controls.Add(txtMaSP);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaSP;
        private Label label1;
        private TextBox txtSoLuong;
        private Label label2;
        private TextBox txtDonGia;
        private Label label3;
        private Button btnThem;
        private Button btnXoaTrang;
        private ListBox lstKetQua;
    }
}