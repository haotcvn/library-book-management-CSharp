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
    public partial class frmReader : Form
    {
        Reader reader;
        private bool addNew;

        public frmReader()
        {
            InitializeComponent();
        }

        private void frmReader_Load(object sender, EventArgs e)
        {
            try
            {
                reader = new Reader();
                setNull();
                setValue(true);
                setButton(true);
                showReader();
                showTypeReader();
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
            cboTypeReader.Enabled = !val;
            rdoMale.Enabled = !val;
            rdoFemale.Enabled = !val;
            txtAddress.Enabled = !val;
            txtNumPhone.Enabled = !val;
        }

        void setNull()
        {
            txtName.Text = "";
            cboTypeReader.Text = "";
            txtAddress.Text = "";
            txtNumPhone.Text = "";
            rdoMale.Checked = false;
            rdoFemale.Checked = false;
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
        // Hiển thị danh sách các cuốn sách
        public void showReader()
        {
            try
            {
                
                dgvReader.DataSource = reader.listReader();

                //Set chiều dài và tiêu đề cho cột
                dgvReader.Columns["MADG"].HeaderText = "Mã số";
                dgvReader.Columns["TENDG"].HeaderText = "Tên độc giả";
                dgvReader.Columns["GIOITINH"].HeaderText = "Giới tính";
                dgvReader.Columns["TENLOAIDG"].HeaderText = "Loại độc giả";
                dgvReader.Columns["DIACHI"].HeaderText = "Địa chỉ";
                dgvReader.Columns["SDT"].HeaderText = "Số điện thoại";

                // Căn giữa cột tiêu đề
                dgvReader.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Căn giữa nội dung
                dgvReader.Columns["MADG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvReader.Columns["GIOITINH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvReader.Columns["TENLOAIDG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvReader.Columns["SDT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hiển thị danh sách các chủ đề
        public void showTypeReader()
        {
            try
            {
                cboTypeReader.DataSource = reader.listTypeReader();
                cboTypeReader.DisplayMember = "TENLOAIDG";
                cboTypeReader.ValueMember = "MALOAIDG";

                cboTypeReader.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click dòng
        private void dgvReader_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtName.Text = dgvReader.CurrentRow.Cells[1].Value.ToString();
                if (dgvReader.CurrentRow.Cells[2].Value.ToString() == "Nam")
                    rdoMale.Checked = true;
                else
                    rdoFemale.Checked = true;
                cboTypeReader.Text = dgvReader.CurrentRow.Cells[3].Value.ToString();
                txtAddress.Text = dgvReader.CurrentRow.Cells[4].Value.ToString();
                txtNumPhone.Text = dgvReader.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Số thứ tự
        private void dgvReader_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
                MessageBox.Show("Bạn chưa nhập tên độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (rdoMale.Checked == false && rdoFemale.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cboTypeReader.Text))
            {
                MessageBox.Show("Bạn chưa chọn loại độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    int id = Convert.ToInt32(dgvReader.CurrentRow.Cells[0].Value.ToString());
                    reader.Delete(id);

                    MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setNull();
                    showReader();
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
                        int type = Convert.ToInt32(cboTypeReader.SelectedValue.ToString());
                        string sex = (rdoMale.Checked ? rdoMale.Text : rdoFemale.Text);
                        string address = txtAddress.Text;
                        string numphone = txtNumPhone.Text;
                        reader.Create(type, name, sex, address, numphone);

                        MessageBox.Show("Bạn đã thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showReader();
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
                        int id = Convert.ToInt32(dgvReader.CurrentRow.Cells[0].Value.ToString());
                        string name = txtName.Text;
                        int type = Convert.ToInt32(cboTypeReader.SelectedValue.ToString());
                        string sex = (rdoMale.Checked ? rdoMale.Text : rdoFemale.Text);
                        string address = txtAddress.Text;
                        string numphone = txtNumPhone.Text;

                        reader.Edit(id, type, name, sex, address, numphone);

                        MessageBox.Show("Bạn đã chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showReader();
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
            frmReader_Load(sender, e);
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
                    dgvReader.DataSource = reader.Search(id);
                }
                else if (rdoName.Checked)
                {
                    dgvReader.DataSource = reader.Search(txtSearch.Text);
                }
                else
                {
                    showReader();
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
            rdoName.Checked = false;
            txtSearch.Text = "";
            showReader();
        }
        #endregion

        #region Xuất file
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export Excel";
            save.Filter = "Excel (*.xlsx)|*xlsx|Excel 2003 (*.xls)|*xls";
            if (save.ShowDialog() == DialogResult.OK)
                new ExportExcel().ToExcel(dgvReader, save.FileName, "DANH SÁCH ĐỘC GIẢ");
        }
        #endregion
    }
}
