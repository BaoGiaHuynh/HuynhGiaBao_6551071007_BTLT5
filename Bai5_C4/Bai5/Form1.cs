using System;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Parent : Form
    {
        private int donHangCount = 0; // Đếm số lượng đơn hàng đã tạo

        public Parent()
        {
            InitializeComponent();
        }

        // Hàm chung dùng để mở một Form đơn hàng mới
        private void TaoDonHangMoi()
        {
            donHangCount++;
            frmDonHang frm = new frmDonHang();
            frm.MdiParent = this; // Đặt Form cha
            frm.Text = $"Đơn hàng {donHangCount}";
            frm.Show();
            CapNhatSoDon();
        }

        // Hàm cập nhật số lượng đơn hàng đang mở lên StatusStrip
        private void CapNhatSoDon()
        {
            lblSoDon.Text = $"Số đơn: {this.MdiChildren.Length}";
        }

        // Click Menu "Đơn hàng mới"
        private void tsmDonHangMoi_Click(object sender, EventArgs e)
        {
            TaoDonHangMoi();
        }

        // Click Nút "Đơn hàng mới" trên ToolStrip
        private void tsbDonHangMoi_Click(object sender, EventArgs e)
        {
            TaoDonHangMoi();
        }

        // Click Menu "Thoát"
        private void tsmThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Các kiểu sắp xếp cửa sổ MDI
        private void tsmCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmTileHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmTileVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        // Sự kiện Timer chạy đồng hồ
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblGio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // Cập nhật lại số đơn khi có form con được mở, chọn hoặc đóng
        private void Parent_MdiChildActivate(object sender, EventArgs e)
        {
            CapNhatSoDon();
        }

        // --- CÁC HÀM TRỐNG DỰ PHÒNG CỦA HỆ THỐNG ---
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void lblSoDon_Click(object sender, EventArgs e) { }
        private void lblGio_Click(object sender, EventArgs e) { }
        private void Parent_Load(object sender, EventArgs e) { }
    }
}