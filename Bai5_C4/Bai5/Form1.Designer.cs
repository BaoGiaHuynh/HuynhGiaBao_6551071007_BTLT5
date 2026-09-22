namespace Bai5
{
    partial class Parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent));
            frmParent = new FileSystemWatcher();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            tsmDonHangMoi = new ToolStripMenuItem();
            tsmThoat = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            tsmCascade = new ToolStripMenuItem();
            tsmTileHorizontal = new ToolStripMenuItem();
            tsmTileVertical = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            tsbDonHangMoi = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblSoDon = new ToolStripStatusLabel();
            lblGio = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)frmParent).BeginInit();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // frmParent
            // 
            frmParent.EnableRaisingEvents = true;
            frmParent.SynchronizingObject = this;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, cascadeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmDonHangMoi, tsmThoat });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // tsmDonHangMoi
            // 
            tsmDonHangMoi.Name = "tsmDonHangMoi";
            tsmDonHangMoi.Size = new Size(224, 26);
            tsmDonHangMoi.Text = "Đơn hang mới";
            tsmDonHangMoi.Click += tsmDonHangMoi_Click;
            // 
            // tsmThoat
            // 
            tsmThoat.Name = "tsmThoat";
            tsmThoat.Size = new Size(224, 26);
            tsmThoat.Text = "Thoát";
            tsmThoat.Click += tsmThoat_Click;
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmCascade, tsmTileHorizontal, tsmTileVertical });
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(78, 24);
            cascadeToolStripMenuItem.Text = "Window";
            cascadeToolStripMenuItem.Click += cascadeToolStripMenuItem_Click;
            // 
            // tsmCascade
            // 
            tsmCascade.Name = "tsmCascade";
            tsmCascade.Size = new Size(224, 26);
            tsmCascade.Text = "Cascade";
            tsmCascade.Click += tsmCascade_Click;
            // 
            // tsmTileHorizontal
            // 
            tsmTileHorizontal.Name = "tsmTileHorizontal";
            tsmTileHorizontal.Size = new Size(224, 26);
            tsmTileHorizontal.Text = "Tile Horizontal";
            tsmTileHorizontal.Click += tsmTileHorizontal_Click;
            // 
            // tsmTileVertical
            // 
            tsmTileVertical.Name = "tsmTileVertical";
            tsmTileVertical.Size = new Size(224, 26);
            tsmTileVertical.Text = "Tile Vertical";
            tsmTileVertical.Click += tsmTileVertical_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbDonHangMoi });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsbDonHangMoi
            // 
            tsbDonHangMoi.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbDonHangMoi.Image = (Image)resources.GetObject("tsbDonHangMoi.Image");
            tsbDonHangMoi.ImageTransparentColor = Color.Magenta;
            tsbDonHangMoi.Name = "tsbDonHangMoi";
            tsbDonHangMoi.Size = new Size(29, 24);
            tsbDonHangMoi.Text = "Đơn hàng mới";
            tsbDonHangMoi.Click += tsbDonHangMoi_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblSoDon, lblGio });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblSoDon
            // 
            lblSoDon.Name = "lblSoDon";
            lblSoDon.Size = new Size(71, 20);
            lblSoDon.Text = "Số đơn: 0";
            lblSoDon.Click += lblSoDon_Click;
            // 
            // lblGio
            // 
            lblGio.Name = "lblGio";
            lblGio.Size = new Size(63, 20);
            lblGio.Text = "00:00:00";
            lblGio.Click += lblGio_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // 
            // Parent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Parent";
            Text = "Form1";
            Load += Parent_Load;
            ((System.ComponentModel.ISupportInitialize)frmParent).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher frmParent;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem tsmDonHangMoi;
        private ToolStripMenuItem tsmThoat;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem tsmCascade;
        private ToolStripMenuItem tsmTileHorizontal;
        private ToolStripMenuItem tsmTileVertical;
        private ToolStrip toolStrip1;
        private ToolStripButton tsbDonHangMoi;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblSoDon;
        private ToolStripStatusLabel lblGio;
        private System.Windows.Forms.Timer timer1;
    }
}
