using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai2_C5
{
    public partial class Form1 : Form
    {
        // Khai báo biến lưu trạng thái vẽ và tọa độ
        private bool isDrawing = false;
        private Point lastPoint;

        public Form1()
        {
            InitializeComponent();

            // Đăng ký các sự kiện chuột cho bảng vẽ (pnlCanvas)
            pnlCanvas.MouseDown += pnlCanvas_MouseDown;
            pnlCanvas.MouseMove += pnlCanvas_MouseMove;
            pnlCanvas.MouseUp += pnlCanvas_MouseUp;
            pnlCanvas.MouseClick += pnlCanvas_MouseClick;
        }

        // 1. Xử lý khi nhấn giữ chuột trái để bắt đầu vẽ
        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
                HienThiTrangThai(e.X, e.Y);
            }
        }

        // 2. Xử lý khi kéo chuột để vẽ liên tục
        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            HienThiTrangThai(e.X, e.Y); // Luôn cập nhật tọa độ

            if (isDrawing)
            {
                using (Graphics g = pnlCanvas.CreateGraphics())
                {
                    using (Pen pen = new Pen(Color.Black, 2f)) // Bút màu đen, nét 2px
                    {
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        g.DrawLine(pen, lastPoint, e.Location);
                    }
                }
                lastPoint = e.Location; // Cập nhật lại điểm cuối
            }
        }

        // 3. Xử lý khi nhả chuột
        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                HienThiTrangThai(e.X, e.Y);
            }
        }

        // 4. Xử lý nhấn chuột phải để xóa bảng
        private void pnlCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                pnlCanvas.Invalidate(); // Xóa sạch các nét vẽ trên Panel
            }
        }

        // 5. Hàm cập nhật chữ trên Label trạng thái
        private void HienThiTrangThai(int x, int y)
        {
            if (isDrawing)
            {
                lblViTri.Text = $"Đang vẽ... | Tọa độ: ({x}, {y})";
            }
            else
            {
                lblViTri.Text = $"Sẵn sàng | Tọa độ: ({x}, {y})";
            }
        }

        // --- CÁC HÀM TRỐNG GIỮ NGUYÊN ĐỂ KHÔNG LỖI GIAO DIỆN DESIGN ---
        private void lblViTri_Click(object sender, EventArgs e)
        {

        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}