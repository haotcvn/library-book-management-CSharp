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
    public partial class frmBooks : Form
    {
        Books book;
        private bool addNew;

        public frmBooks()
        {
            InitializeComponent();
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            try
            {
                book = new Books();
                setNull();
                setValue(true);
                setButton(true);
                showBooks();
                showTopic();
                showAuthor();
                showPublisher();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Set các giá trị
        void setValue(bool val)
        {
            txtName.Enabled = !val;
            cboTopic.Enabled = !val;
            btnAddTopic.Enabled = !val;
            cboAuthor.Enabled = !val;
            btnAddAuthor.Enabled = !val;
            cboPublisher.Enabled = !val;
            btnAddPublisher.Enabled = !val;
            txtPublishYear.Enabled = !val;
            numPage.Enabled = !val;
            numQuantity.Enabled = !val;
        }

        void setNull()
        {
            txtName.Text = "";
            cboTopic.Text = "";
            cboAuthor.Text = "";
            cboPublisher.Text = "";
            txtPublishYear.Text = "";
            numPage.Text = "";
            numQuantity.Text = "";
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
        public void showBooks()
        {
            try
            {
                dgvBooks.DataSource = book.listBooks();

                //Set chiều dài và tiêu đề cho cột
                dgvBooks.Columns["MASACH"].HeaderText = "Mã sách";
                dgvBooks.Columns["TENSACH"].HeaderText = "Tên sách";
                dgvBooks.Columns["TENCD"].HeaderText = "Chủ đề";
                dgvBooks.Columns["TENTG"].HeaderText = "Tác giả";
                dgvBooks.Columns["TENNXB"].HeaderText = "Nhà xuất bản";
                dgvBooks.Columns["NAMXB"].HeaderText = "Năm xuất bản";
                dgvBooks.Columns["SOTRANG"].HeaderText = "Số trang";
                dgvBooks.Columns["SOLUONG"].HeaderText = "Số lượng";

                dgvBooks.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvBooks.Columns["MASACH"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBooks.Columns["NAMXB"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBooks.Columns["SOTRANG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvBooks.Columns["SOLUONG"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hiển thị danh sách các chủ đề
        public void showTopic()
        {
            try
            {
                cboTopic.DataSource = book.listTopic();
                cboTopic.DisplayMember = "TENCD";
                cboTopic.ValueMember = "MACD";

                cboTopic.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hiển thị danh sách các tác giả
        public void showAuthor()
        {
            try
            {
                cboAuthor.DataSource = book.listAuthor();
                cboAuthor.DisplayMember = "TENTG";
                cboAuthor.ValueMember = "MATG";

                cboAuthor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hiển thị danh sách các nhà xuất bản
        public void showPublisher()
        {
            try
            {
                cboPublisher.DataSource = book.listPublisher();
                cboPublisher.DisplayMember = "TENNXB";
                cboPublisher.ValueMember = "MANXB";

                cboPublisher.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click dòng
        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtName.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
                cboTopic.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
                cboAuthor.Text = dgvBooks.CurrentRow.Cells[3].Value.ToString();
                cboPublisher.Text = dgvBooks.CurrentRow.Cells[4].Value.ToString();
                txtPublishYear.Text = dgvBooks.CurrentRow.Cells[5].Value.ToString();
                numPage.Text = dgvBooks.CurrentRow.Cells[6].Value.ToString();
                numQuantity.Text = dgvBooks.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Số thứ tự
        private void dgvBooks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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
                MessageBox.Show("Bạn chưa nhập tên sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(cboTopic.Text))
            {
                MessageBox.Show("Bạn chưa chọn chủ đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(cboAuthor.Text))
            {
                MessageBox.Show("Bạn chưa chọn tác giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cboPublisher.Text))
            {
                MessageBox.Show("Bạn chưa chọn nhà xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtPublishYear.Text))
            {
                MessageBox.Show("Bạn chưa nhập năm xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(numPage.Text))
            {
                MessageBox.Show("Bạn chưa nhập số trang sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(numQuantity.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value.ToString());
                    book.Delete(id);

                    MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setNull();
                    showBooks();
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
                    if (this.checkNull())
                    {
                        int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value.ToString());
                        string name = txtName.Text;
                        int topic = Convert.ToInt32(cboTopic.SelectedValue.ToString());
                        int author = Convert.ToInt32(cboAuthor.SelectedValue.ToString());
                        int publisher = Convert.ToInt32(cboPublisher.SelectedValue.ToString());
                        int year = Convert.ToInt32(txtPublishYear.Text);
                        int numpage = Convert.ToInt32(numPage.Value.ToString());
                        int quantity = Convert.ToInt32(numQuantity.Value.ToString());
                        Books bookCreate = new Books(id, name, topic, author, publisher, year, numpage, quantity);
                        if (book.Create(bookCreate))
                        {
                            MessageBox.Show("Bạn đã thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showBooks();
                            setNull();
                            setValue(true);
                            setButton(true);
                        }
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
                        int id = Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value.ToString());
                        string name = txtName.Text;
                        int topic = Convert.ToInt32(cboTopic.SelectedValue.ToString());
                        int author = Convert.ToInt32(cboAuthor.SelectedValue.ToString());
                        int publisher = Convert.ToInt32(cboPublisher.SelectedValue.ToString());
                        int year = Convert.ToInt32(txtPublishYear.Text);
                        int numpage = Convert.ToInt32(numPage.Value.ToString());
                        int quantity = Convert.ToInt32(numQuantity.Value.ToString());

                        book.Edit(id, name, topic, author, publisher, year, numpage, quantity);

                        MessageBox.Show("Bạn đã chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showBooks();
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
            frmBooks_Load(sender, e);
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
                    dgvBooks.DataSource = book.Search(id);
                }
                else if (rdoName.Checked)
                {
                    dgvBooks.DataSource = book.Search(txtSearch.Text);
                }
                else
                {
                    showBooks();
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
            showBooks();
        }
        #endregion

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            new frmTopic().ShowDialog();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            new frmAuthor().ShowDialog();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            new frmPublisher().ShowDialog();
        }

        #region Xuất file
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export Excel";
            save.Filter = "Excel (*.xlsx)|*xlsx|Excel 2003 (*.xls)|*xls";
            if (save.ShowDialog() == DialogResult.OK)
                new ExportExcel().ToExcel(dgvBooks, save.FileName, "DANH SÁCH SÁCH TRONG THƯ VIỆN");
        }
        #endregion
    }
}
