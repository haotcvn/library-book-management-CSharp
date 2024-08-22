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
    public partial class frmAuthor : Form
    {
        Author author;
        private bool addNew;

        public frmAuthor()
        {
            InitializeComponent();
        }

        private void frmAuthor_Load(object sender, EventArgs e)
        {
            try
            {
                author = new Author();
                setNull();
                setValue(true);
                setButton(true);
                showAuthor();
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
        }

        void setNull()
        {
            txtName.Text = "";
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
        public void showAuthor()
        {
            try
            {
                dgvAuthor.DataSource = author.listAuthor();

                //Set chiều dài và tiêu đề cho cột
                dgvAuthor.Columns["MATG"].HeaderText = "Mã tác giả";
                dgvAuthor.Columns["TENTG"].HeaderText = "Tên tác giả";
                dgvAuthor.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click dòng
        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtName.Text = dgvAuthor.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Số thứ tự
        private void dgvAuthor_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
                MessageBox.Show("Bạn chưa nhập tên tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // Thêm tác giả
        private void btnCreate_Click(object sender, EventArgs e)
        {
            addNew = true;
            setValue(false);
            setNull();
            setButton(false);
            txtName.Focus();
        }

        // Chỉnh sửa tác giả
        private void btnEdit_Click(object sender, EventArgs e)
        {
            addNew = false;
            setValue(false);
            setButton(false);
        }

        // Xóa tác giả
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvAuthor.CurrentRow.Cells[0].Value.ToString());
                    author.Delete(id);

                    MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setNull();
                    showAuthor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lưu tác giả
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Thực hiên thêm mới
            if (addNew)
            {
                try
                {
                    if (this.checkNull())
                    {
                        author.Create(txtName.Text);

                        MessageBox.Show("Bạn đã thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showAuthor();
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
                    if (this.checkNull())
                    {
                        int id = Convert.ToInt32(dgvAuthor.CurrentRow.Cells[0].Value.ToString());
                        author.Edit(id, txtName.Text);

                        MessageBox.Show("Bạn đã chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showAuthor();
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
            frmAuthor_Load(sender, e);
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
                    dgvAuthor.DataSource = author.Search(id);
                }
                else if (rdoName.Checked)
                {
                    dgvAuthor.DataSource = author.Search(txtSearch.Text);
                }
                else
                {
                    showAuthor();
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
            showAuthor();
        }
        #endregion

        #region Xuất file
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export Excel";
            save.Filter = "Excel (*.xlsx)|*xlsx|Excel 2003 (*.xls)|*xls";
            if (save.ShowDialog() == DialogResult.OK)
                new ExportExcel().ToExcel(dgvAuthor, save.FileName, "DANH SÁCH TÁC GIẢ");
        }
        #endregion
    }
}
