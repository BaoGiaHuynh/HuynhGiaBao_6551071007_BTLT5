using System;
using System.Windows.Forms;

namespace Bai1_C5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Bắt buộc phải có dòng này để load giao diện

            // Yêu cầu 6: Bật KeyPreview để bắt phím tắt trên toàn Form
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Gán sự kiện chặn ký tự cho ô Số lượng và Đơn giá (Yêu cầu 2)
            txtSoLuong.KeyPress += ChiNhapSo_KeyPress;
            txtDonGia.KeyPress += ChiNhapSo_KeyPress;
        }

        // Yêu cầu 2: Chỉ cho phép nhập chữ số (0-9) và phím Backspace
        private void ChiNhapSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Từ chối ký tự không phải số
            }
        }

        // Yêu cầu 3: Nút Thêm đưa dữ liệu xuống ListBox
        private void btnThem_Click(object sender, EventArgs e)
        {
            ThucHienThem();
        }

        private void ThucHienThem()
        {
            string maSP = txtMaSP.Text.Trim();
            string soLuong = txtSoLuong.Text.Trim();
            string donGia = txtDonGia.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSP) || string.IsNullOrWhiteSpace(soLuong) || string.IsNullOrWhiteSpace(donGia))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã SP, Số lượng và Đơn giá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Định dạng chuỗi: "MaSP | SoLuong | DonGia"
            lstKetQua.Items.Add($"{maSP} | {soLuong} | {donGia}");
        }

        // Yêu cầu 4: Xóa trắng 3 TextBox và trỏ chuột về txtMaSP
        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            ThucHienXoaTrang();
        }

        private void ThucHienXoaTrang()
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMaSP.Focus();
        }

        // Xử lý các phím tắt F2, F5, ESC (Yêu cầu 3, 4, 5)
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                ThucHienThem(); // Kích hoạt chức năng thêm
            }
            else if (e.KeyCode == Keys.F5)
            {
                ThucHienXoaTrang(); // Kích hoạt chức năng xóa trắng
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close(); // Kích hoạt đóng form -> Gọi FormClosing
            }
        }

        // Yêu cầu 5: Xác nhận khi đóng Form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có muốn thoát?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Hủy lệnh đóng form nếu chọn No
            }
        }
    }
}