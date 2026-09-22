using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; // Hỗ trợ sử dụng Interaction.InputBox

namespace Bai5
{
    public partial class frmDonHang : Form
    {
        public frmDonHang()
        {
            InitializeComponent();
        }

        // Tự động tạo các cột cho ListView khi Form chạy
        private void frmDonHang_Load(object sender, EventArgs e)
        {
            lsvChiTiet.View = View.Details;
            lsvChiTiet.FullRowSelect = true;
            lsvChiTiet.GridLines = true;

            // Nếu chưa thiết kế cột thì tự tạo 4 cột tiêu đề
            if (lsvChiTiet.Columns.Count == 0)
            {
                lsvChiTiet.Columns.Add("Tên sản phẩm", 140);
                lsvChiTiet.Columns.Add("Số lượng", 70);
                lsvChiTiet.Columns.Add("Đơn giá", 100);
                lsvChiTiet.Columns.Add("Thành tiền", 110);
            }
        }

        // --- XỬ LÝ NÚT THÊM (SỬA CẢ 2 HÀM SỰ KIỆN) ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThucHienThem();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            ThucHienThem();
        }

        private void ThucHienThem()
        {
            if (string.IsNullOrWhiteSpace(txtTenSP.Text) || !decimal.TryParse(txtDonGia.Text, out decimal donGia))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm và đơn giá hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenSP = txtTenSP.Text.Trim();
            int soLuong = (int)numSoLuong.Value;
            decimal thanhTien = soLuong * donGia;

            // Thêm dòng mới vào ListView
            ListViewItem item = new ListViewItem(tenSP);
            item.SubItems.Add(soLuong.ToString());
            item.SubItems.Add(donGia.ToString("N0"));
            item.SubItems.Add(thanhTien.ToString("N0"));

            lsvChiTiet.Items.Add(item);

            // Cập nhật lại tổng tiền
            CapNhatTongTien();

            // Làm sạch ô nhập
            txtTenSP.Clear();
            txtDonGia.Clear();
            numSoLuong.Value = 1;
            txtTenSP.Focus();
        }

        // --- HÀM TÍNH TỔNG TIỀN ---
        private void CapNhatTongTien()
        {
            decimal tongTien = 0;
            foreach (ListViewItem item in lsvChiTiet.Items)
            {
                if (decimal.TryParse(item.SubItems[3].Text.Replace(",", "").Replace(".", ""), out decimal thanhTien))
                {
                    tongTien += thanhTien;
                }
            }
            lblTongTien.Text = $"Tổng tiền: {tongTien:N0} VNĐ";
        }

        // --- MENU CHUỘT PHẢI ---
        private void xoaDongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvChiTiet.SelectedItems.Count > 0)
            {
                lsvChiTiet.Items.Remove(lsvChiTiet.SelectedItems[0]);
                CapNhatTongTien();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void suaSoLuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lsvChiTiet.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvChiTiet.SelectedItems[0];
                string currentSL = item.SubItems[1].Text;

                string input = Interaction.InputBox("Nhập số lượng mới:", "Sửa số lượng", currentSL);

                if (int.TryParse(input, out int soLuongMoi) && soLuongMoi > 0)
                {
                    decimal donGia = decimal.Parse(item.SubItems[2].Text.Replace(",", "").Replace(".", ""));
                    decimal thanhTienMoi = soLuongMoi * donGia;

                    item.SubItems[1].Text = soLuongMoi.ToString();
                    item.SubItems[3].Text = thanhTienMoi.ToString("N0");

                    CapNhatTongTien();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Cảnh báo khi đóng
        private void frmDonHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (lsvChiTiet.Items.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn đóng đơn hàng khi chưa 'chốt đơn' hay không?",
                    "Xác nhận đóng",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        // Các hàm rỗng giữ nguyên để không bị lỗi giao diện
        private void lblTongTien_Click(object sender, EventArgs e) { }
        private void lsvChiTiet_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtDonGia_TextChanged(object sender, EventArgs e) { }
        private void numSoLuong_ValueChanged(object sender, EventArgs e) { }
        private void txtTenSP_TextChanged(object sender, EventArgs e) { }
    }
}