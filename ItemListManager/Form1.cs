using System;
using System.Windows.Forms;

namespace ItemListManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cboDonViTinh.Items.Add("Cái");
            cboDonViTinh.Items.Add("Bộ");
            cboDonViTinh.Items.Add("Kg");
            cboDonViTinh.Items.Add("Mét");

            cboDonViTinh.SelectedIndex = 0;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaVT.Text))
            {
                MessageBox.Show("Vui lòng nhập mã vật tư!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenVT.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vật tư!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVT.Focus();
                return;
            }

            if (cboDonViTinh.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboDonViTinh.Focus();
                return;
            }

            decimal donGia;

            if (!decimal.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá phải là số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            if (donGia < 0)
            {
                MessageBox.Show("Đơn giá không được nhỏ hơn 0!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            foreach (ListViewItem item in listViewVatTu.Items)
            {
                if (item.SubItems[0].Text.Equals(
                    txtMaVT.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã vật tư đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaVT.Focus();
                    return;
                }
            }

            ListViewItem dong = new ListViewItem(txtMaVT.Text.Trim());

            dong.SubItems.Add(txtTenVT.Text.Trim());
            dong.SubItems.Add(cboDonViTinh.Text);
            dong.SubItems.Add(donGia.ToString("N0"));

            listViewVatTu.Items.Add(dong);

            XoaTrang();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (listViewVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMaVT.Text))
            {
                MessageBox.Show("Vui lòng nhập mã vật tư!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTenVT.Text))
            {
                MessageBox.Show("Vui lòng nhập tên vật tư!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVT.Focus();
                return;
            }

            decimal donGia;

            if (!decimal.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá phải là số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            if (donGia < 0)
            {
                MessageBox.Show("Đơn giá không được nhỏ hơn 0!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            ListViewItem dong = listViewVatTu.SelectedItems[0];

            for (int i = 0; i < listViewVatTu.Items.Count; i++)
            {
                if (listViewVatTu.Items[i] != dong &&
                    listViewVatTu.Items[i].SubItems[0].Text.Equals(
                        txtMaVT.Text.Trim(),
                        StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Mã vật tư đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaVT.Focus();
                    return;
                }
            }

            dong.SubItems[0].Text = txtMaVT.Text.Trim();
            dong.SubItems[1].Text = txtTenVT.Text.Trim();
            dong.SubItems[2].Text = cboDonViTinh.Text;
            dong.SubItems[3].Text = donGia.ToString("N0");

            XoaTrang();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (listViewVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dòng này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                listViewVatTu.Items.Remove(listViewVatTu.SelectedItems[0]);
                XoaTrang();
            }
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            if (listViewVatTu.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult ketQua = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa toàn bộ danh sách không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (ketQua == DialogResult.Yes)
            {
                listViewVatTu.Items.Clear();
                XoaTrang();
            }
        }

        private void listViewVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewVatTu.SelectedItems.Count == 0)
                return;

            ListViewItem dong = listViewVatTu.SelectedItems[0];

            txtMaVT.Text = dong.SubItems[0].Text;
            txtTenVT.Text = dong.SubItems[1].Text;
            cboDonViTinh.Text = dong.SubItems[2].Text;
            txtDonGia.Text = dong.SubItems[3].Text.Replace(",", "");
        }

        private void XoaTrang()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            cboDonViTinh.SelectedIndex = 0;
            txtDonGia.Clear();

            listViewVatTu.SelectedItems.Clear();

            txtMaVT.Focus();
        }
    }
}