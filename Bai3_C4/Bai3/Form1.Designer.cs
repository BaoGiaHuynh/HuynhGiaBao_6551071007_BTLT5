namespace Bai3
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
            components = new System.ComponentModel.Container();
            txtCongViecMoi = new TextBox();
            btnThem = new Button();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            danhDauHoanThanhToolStripMenuItem = new ToolStripMenuItem();
            xoaCongViecNayToolStripMenuItem = new ToolStripMenuItem();
            xoaTatCaToolStripMenuItem = new ToolStripMenuItem();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new Point(227, 28);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(125, 27);
            txtCongViecMoi.TabIndex = 0;
            txtCongViecMoi.TextChanged += txtCongViecMoi_TextChanged;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.ActiveCaption;
            btnThem.Location = new Point(397, 28);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // lstCongViec
            // 
            lstCongViec.ContextMenuStrip = cmsCongViec;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(33, 63);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(700, 284);
            lstCongViec.TabIndex = 2;
            lstCongViec.SelectedIndexChanged += lstCongViec_SelectedIndexChanged;
            // 
            // cmsCongViec
            // 
            cmsCongViec.ImageScalingSize = new Size(20, 20);
            cmsCongViec.Items.AddRange(new ToolStripItem[] { danhDauHoanThanhToolStripMenuItem, xoaCongViecNayToolStripMenuItem, xoaTatCaToolStripMenuItem });
            cmsCongViec.Name = "contextMenuStrip1";
            cmsCongViec.Size = new Size(214, 104);
            cmsCongViec.Opening += cmsCongViec_Opening;
            // 
            // danhDauHoanThanhToolStripMenuItem
            // 
            danhDauHoanThanhToolStripMenuItem.Name = "danhDauHoanThanhToolStripMenuItem";
            danhDauHoanThanhToolStripMenuItem.Size = new Size(213, 24);
            danhDauHoanThanhToolStripMenuItem.Text = "Đánh dấu hoàn toàn";
            danhDauHoanThanhToolStripMenuItem.Click += danhDauHoanThanhToolStripMenuItem_Click_1;
            // 
            // xoaCongViecNayToolStripMenuItem
            // 
            xoaCongViecNayToolStripMenuItem.Name = "xoaCongViecNayToolStripMenuItem";
            xoaCongViecNayToolStripMenuItem.Size = new Size(213, 24);
            xoaCongViecNayToolStripMenuItem.Text = "Xóa công việc này";
            xoaCongViecNayToolStripMenuItem.Click += xoaCongViecNayToolStripMenuItem_Click_1;
            // 
            // xoaTatCaToolStripMenuItem
            // 
            xoaTatCaToolStripMenuItem.Name = "xoaTatCaToolStripMenuItem";
            xoaTatCaToolStripMenuItem.Size = new Size(213, 24);
            xoaTatCaToolStripMenuItem.Text = "Xóa tất cả";
            xoaTatCaToolStripMenuItem.Click += xoaTatCaToolStripMenuItem_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCongViec);
            Controls.Add(btnThem);
            Controls.Add(txtCongViecMoi);
            Name = "Form1";
            Text = "Form1";
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCongViecMoi;
        private Button btnThem;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem danhDauHoanThanhToolStripMenuItem;
        private ToolStripMenuItem xoaCongViecNayToolStripMenuItem;
        private ToolStripMenuItem xoaTatCaToolStripMenuItem;
    }
}
