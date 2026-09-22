using System;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Cấu hình các thuộc tính cho ToolTip trong hàm khởi tạo Form
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 500;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cboGoiTap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numSoBuoiTuan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra rỗng cho Họ tên hoặc SĐT
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // 2. Lấy thông tin từ giao diện
                string hoTen = txtHoTen.Text;
                string sdt = txtSDT.Text;
                string goiTap = cboGoiTap.SelectedItem != null ? cboGoiTap.SelectedItem.ToString() : "Chưa chọn";
                string soBuoi = numSoBuoiTuan.Value.ToString();

                // 3. Tổng hợp thông tin
                string thongBao = $"Họ tên: {hoTen}\nSĐT: {sdt}\nGói tập: {goiTap}\nSố buổi/tuần: {soBuoi}";

                // 4. Hiển thị bảng thông báo
                MessageBox.Show(thongBao, "Thông tin đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}