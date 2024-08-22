using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.Class;

namespace QuanLyThuVien
{
    public partial class frmPublisher : Form
    {
        Publisher publisher;
        private bool addNew;

        public frmPublisher()
        {
            InitializeComponent();
        }

        private void frmPublisher_Load(object sender, EventArgs e)
        {
            try
            {
                publisher = new Publisher();
                setValue(true);
                setButton(true);
                showPublisher();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Set các giá trị chung
        void setValue(bool val)
        {
            txtName.Enabled = !val;
            txtAddress.Enabled = !val;
            txtNumPhone.Enabled = !val;
        }

        void setNull()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtNumPhone.Text = "";
        }

        void setButton(bool btn)
        {
            btnCreate.Enabled = btn;
            btnEdit.Enabled = btn;
            btnDelete.Enabled = btn;
            btnSave.Enabled = !btn;
            btnCancel.Enabled = !btn;
            btnExit.Enabled = btn;
            btnCancelS.Enabled = !btn;
        }
        #endregion

        #region Hiển thị dữ liệu

        // Hiển thị danh sách các chủ đề
        public void showPublisher()
        {
            try
            {
                dgvPublisher.DataSource = publisher.listPublisher();

                //Set tiêu đề cho cột
                dgvPublisher.Columns["MANXB"].HeaderText = "Mã nhà xuất bản";
                dgvPublisher.Columns["TENNXB"].HeaderText = "Tên nhà xuất bản";
                dgvPublisher.Columns["DIACHI"].HeaderText = "Địa chỉ";
                dgvPublisher.Columns["SDT"].HeaderText = "Số điện thoại";

                dgvPublisher.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtName.Text = dgvPublisher.CurrentRow.Cells[1].Value.ToString();
                txtAddress.Text = dgvPublisher.CurrentRow.Cells[2].Value.ToString();
                txtNumPhone.Text = dgvPublisher.CurrentRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Số thứ tự
        private void dgvPublisher_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                using (SolidBrush b = new SolidBrush(Color.Blue))
                {
                    e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Thêm, Xóa, Sửa
        // Kiểm tra rỗng
        bool checkNull()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        // Thêm mới sách
        private void btnCreate_Click(object sender, EventArgs e)
        {
            addNew = true;
            setValue(false);
            setNull();
            setButton(false);
            txtName.Focus();
        }

        // Chỉnh sửa sách
        private void btnEdit_Click(object sender, EventArgs e)
        {
            addNew = false;
            setValue(false);
            setButton(false);
        }

        // Xóa sách
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvPublisher.CurrentRow.Cells[0].Value.ToString());
                    publisher.Delete(id);

                    MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setNull();
                    showPublisher();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lưu sách
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Thực hiên thêm mới
            if (addNew)
            {
                try
                {
                    if (checkNull())
                    {
                        string name = txtName.Text;
                        string address = txtAddress.Text;
                        string numphone = txtNumPhone.Text;
                        publisher.Create(name, address, numphone);

                        MessageBox.Show("Bạn đã thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showPublisher();
                        setNull();
                        setValue(true);
                        setButton(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Thực hiên cập nhập
            else
            {
                try
                {
                    if (checkNull())
                    {
                        int id = Convert.ToInt32(dgvPublisher.CurrentRow.Cells[0].Value.ToString());
                        string name = txtName.Text;
                        string address = txtAddress.Text;
                        string numphone = txtNumPhone.Text;

                        publisher.Edit(id, name, address, numphone);

                        MessageBox.Show("Bạn đã chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showPublisher();
                        setNull();
                        setValue(true);
                        setButton(true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hủy thao tác
        private void btnCancel_Click(object sender, EventArgs e)
        {
            setNull();
            setValue(true);
            setButton(true);
        }

        // Làm mới dữ liệu
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            frmPublisher_Load(sender, e);
        }

        // Thoát
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }

        #endregion

        #region Tìm kiếm
        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnCancelS.Enabled = true;
            try
            {
                if (rdoID.Checked)
                {
                    int id = Convert.ToInt32(txtSearch.Text);
                    dgvPublisher.DataSource = publisher.Search(id);
                }
                else if (rdoName.Checked)
                {
                    dgvPublisher.DataSource = publisher.Search(txtSearch.Text);
                }
                else
                {
                    showPublisher();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelS_Click(object sender, EventArgs e)
        {
            btnCancelS.Enabled = false;
            rdoID.Checked = false;
            rdoID.Checked = false;
            txtSearch.Text = "";
            showPublisher();
        }
        #endregion

        #region Xuất file
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export Excel";
            save.Filter = "Excel (*.xlsx)|*xlsx|Excel 2003 (*.xls)|*xls";
            if (save.ShowDialog() == DialogResult.OK)
                new ExportExcel().ToExcel(dgvPublisher, save.FileName, "DANH SÁCH NHÀ XUẤT BẢN");
        }
        #endregion
    }
}
