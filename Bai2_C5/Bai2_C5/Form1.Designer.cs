namespace Bai2_C5
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
            pnlCanvas = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblViTri = new Label();
            pnlCanvas.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCanvas
            // 
            pnlCanvas.BackColor = SystemColors.Window;
            pnlCanvas.Controls.Add(lblViTri);
            pnlCanvas.Controls.Add(flowLayoutPanel1);
            pnlCanvas.Location = new Point(0, 0);
            pnlCanvas.Name = "pnlCanvas";
            pnlCanvas.Size = new Size(802, 448);
            pnlCanvas.TabIndex = 0;
            pnlCanvas.Paint += pnlCanvas_Paint;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(83, 51);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(10, 41);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // lblViTri
            // 
            lblViTri.AutoSize = true;
            lblViTri.Location = new Point(0, 0);
            lblViTri.Name = "lblViTri";
            lblViTri.Size = new Size(167, 20);
            lblViTri.TabIndex = 1;
            lblViTri.Text = "Sẵn sàng | Tọa độ: (0, 0)";
            lblViTri.Click += lblViTri_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlCanvas);
            Name = "Form1";
            Text = "Form1";
            pnlCanvas.ResumeLayout(false);
            pnlCanvas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCanvas;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblViTri;
    }
}
