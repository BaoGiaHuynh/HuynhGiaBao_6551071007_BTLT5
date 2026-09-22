using System;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCongViecMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu ô nhập không bị bỏ trống
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                // Thêm nội dung vào ListBox và làm sạch ô nhập
                lstCongViec.Items.Add(txtCongViecMoi.Text.Trim());
                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập nội dung công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // --- CÁC HÀM SỰ KIỆN NỐI VỚI GIAO DIỆN ---

        private void danhDauHoanThanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThucHienDanhDauHoanThanh();
        }

        private void danhDauHoanThanhToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThucHienDanhDauHoanThanh();
        }

        private void xoaCongViecNayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThucHienXoaCongViecNay();
        }

        private void xoaCongViecNayToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThucHienXoaCongViecNay();
        }

        private void xoaTatCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThucHienXoaTatCa();
        }

        private void xoaTatCaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThucHienXoaTatCa();
        }

        private void cmsCongViec_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        // --- HÀM XỬ LÝ LOGIC CHÍNH ---

        private void ThucHienDanhDauHoanThanh()
        {
            if (lstCongViec.SelectedItem != null)
            {
                int index = lstCongViec.SelectedIndex;
                string itemText = lstCongViec.SelectedItem.ToString();
                string prefix = "[Hoàn thành] ";

                if (!itemText.StartsWith(prefix))
                {
                    lstCongViec.Items[index] = prefix + itemText;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một công việc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ThucHienXoaCongViecNay()
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn công việc cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ThucHienXoaTatCa()
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ danh sách?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }
    }
}