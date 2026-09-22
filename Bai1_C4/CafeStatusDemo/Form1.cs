using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeStatusDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Không cần viết code ở đây cho bài này
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Không cần viết code ở đây cho bài này
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            // Không cần viết code ở đây cho bài này
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 1. Cập nhật giờ
            lblGioHienTai.Text = DateTime.Now.ToString("HH:mm:ss");

            // 2. Code này BẮT BUỘC nằm trong timer1_Tick
            int gioHienTai = DateTime.Now.Hour;
            if (gioHienTai >= 6 && gioHienTai < 22)
            {
                lblTrangThai.Text = "Đang mở cửa";
                lblTrangThai.ForeColor = Color.Green;
            }
            else
            {
                lblTrangThai.Text = "Đã đóng cửa";
                lblTrangThai.ForeColor = Color.Red;
            }
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Click vào menu cha "Hệ thống" không cần xử lý, chỉ cần xử lý các menu con bên trong
        }

        private void đổiMàuNềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mở hộp thoại chọn màu
            ColorDialog colorDialog = new ColorDialog();

            // Nếu người dùng chọn màu và bấm OK thì gán màu đó cho nền của Form
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog.Color;
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Đóng chương trình
            Application.Exit();
        }

        private void lblTrangThai_Click(object sender, EventArgs e)
        {

        }
    }
}