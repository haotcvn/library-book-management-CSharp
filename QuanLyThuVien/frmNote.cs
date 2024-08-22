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
using Microsoft.Office.Interop.Excel;

namespace QuanLyThuVien
{
    public partial class frmNote : Form
    {
        DataClassesDataContext db = new DataClassesDataContext();
        Note note;
        NoteDetails detail;
        Books oBook;
        private bool addNew;

        public frmNote()
        {
            InitializeComponent();
        }

        private void frmNote_Load(object sender, EventArgs e)
        {
            try 
            {
                oBook = new Books();
                note = new Note();
                detail = new NoteDetails();
                setNull();
                setValue(true);
                setButton(true);
                loadNote();
                loadNoteDetail();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Set các giá trị chung
        void setValue(bool val)
        {
            cboReader.Enabled = !val;
            cboEmployee.Enabled = !val;
            cboNoteM.Enabled = !val;
            cboBook.Enabled = !val;
            dtpDateStart.Enabled = !val;
            dtpDateEnd.Enabled = !val;
            txtNotes.Enabled = !val;
            numQuantity.Enabled = !val;
        }

        void setNull()
        {
            cboReader.Text = "";
            cboEmployee.Text = "";
            cboNoteM.Text = "";
            cboBook.Text = "";
            dtpDateStart.Text = "";
            dtpDateEnd.Text = "";
            txtNotes.Text = "";
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

        #region Hiển thị dữ liệu tab phiếu mượn
        // Load bảng phiếu mượn
        public void loadNote()
        {
            showNote();
            showReader();
            showEmployee();
        }
        
        public void showNote()
        {
            try
            {
                dgvNoteM.DataSource = note.listNote();

                //Set chiều dài và tiêu đề cho cột
                dgvNoteM.Columns["STT_Phieu"].HeaderText = "Số thứ tự";
                dgvNoteM.Columns["TENDG"].HeaderText = "Tên đọc giả";
                dgvNoteM.Columns["TENNV"].HeaderText = "Người lập phiếu";
                dgvNoteM.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showReader()
        {
            try
            {
                cboReader.DataSource = note.listReader();
                cboReader.DisplayMember = "TENDG";
                cboReader.ValueMember = "MADG";

                cboReader.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showEmployee()
        {
            try
            {
                cboEmployee.DataSource = note.listEmployee();
                cboEmployee.DisplayMember = "TENNV";
                cboEmployee.ValueMember = "MANV";

                cboEmployee.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click dòng
        private void dgvNoteM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cboReader.Text = dgvNoteM.CurrentRow.Cells[1].Value.ToString();
                cboEmployee.Text = dgvNoteM.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Số thứ tự
        private void dgvNoteM_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        // Chi tiết phiếu mượn
        private void dgvNoteM_DoubleClick(object sender, EventArgs e)
        {
            this.tabNote.SelectedIndex = 1;
            int id = Convert.ToInt32(dgvNoteM.CurrentRow.Cells[0].Value.ToString());
            this.dgvNoteDetails.DataSource = detail.Search(id);
        }
        #endregion

        #region Hiển thị dữ liệu tab chi tiết phiếu mượn
        // Load bảng phiếu mượn
        public void loadNoteDetail()
        {
            showNoteDetails();
            showNoteM();
            showBook();
        }

        public void showNoteDetails()
        {
            try
            {
                dgvNoteDetails.DataSource = detail.listNoteDetails();

                //Set chiều dài và tiêu đề cho cột
                dgvNoteDetails.Columns["STT_PHIEU"].HeaderText = "Số phiếu";
                dgvNoteDetails.Columns["TENSACH"].HeaderText = "Tên sách";
                dgvNoteDetails.Columns["NGAYMUON"].HeaderText = "Ngày mượn";
                dgvNoteDetails.Columns["NGAYTRA"].HeaderText = "Ngày trả";
                dgvNoteDetails.Columns["SOLUONG"].HeaderText = "Số lượng";
                dgvNoteDetails.Columns["GHICHU"].HeaderText = "Ghi chú";
                dgvNoteDetails.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showNoteM()
        {
            try
            {
                cboNoteM.DataSource = detail.listNoteM();
                cboNoteM.DisplayMember = "STT_PHIEU";
                cboNoteM.ValueMember = "STT_PHIEU";

                cboNoteM.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void showBook()
        {
            try
            {
                cboBook.DataSource = detail.listBook();
                cboBook.DisplayMember = "TENSACH";
                cboBook.ValueMember = "MASACH";

                cboBook.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Click dòng
        private void dgvNoteDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cboNoteM.Text = dgvNoteDetails.CurrentRow.Cells[0].Value.ToString();
                cboBook.Text = dgvNoteDetails.CurrentRow.Cells[1].Value.ToString();
                dtpDateStart.Text = dgvNoteDetails.CurrentRow.Cells[2].Value.ToString();
                dtpDateEnd.Text = dgvNoteDetails.CurrentRow.Cells[3].Value.ToString();
                numQuantity.Text = dgvNoteDetails.CurrentRow.Cells[4].Value.ToString();
                txtNotes.Text = dgvNoteDetails.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Số thứ tự
        private void dgvNoteDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        #region Thêm, Xóa, Sửa tab phiếu mượn
        // Kiễm tra rỗng Tab phiếu mượn
        bool checkNull()
        {
            if (string.IsNullOrEmpty(cboReader.Text))
            {
                MessageBox.Show("Bạn chưa chọn tên độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cboEmployee.Text))
            {
                MessageBox.Show("Bạn chưa chọn người lập phiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        // Kiễm tra rỗng Tab phiếu mượn chi tiết
        bool checkNullDetails()
        {
            if (string.IsNullOrEmpty(cboNoteM.Text))
            {
                MessageBox.Show("Bạn chưa chọn phiếu mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cboBook.Text))
            {
                MessageBox.Show("Bạn chưa chọn sách để mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(dtpDateStart.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(dtpDateEnd.Text))
            {
                MessageBox.Show("Bạn chưa chọn ngày hẹn trả để mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(numQuantity.Text))
            {
                MessageBox.Show("Bạn chưa nhập số lượng sách mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (btnCreate.Text == "Thêm")
                cboReader.Focus();
            if (btnCreate.Text == "Mượn")
                cboNoteM.Focus();
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
                    // Thực hiện xóa phiếu mượn
                    if (tabNote.SelectedTab == tabNote.TabPages[0])
                    {
                        int id = Convert.ToInt32(dgvNoteM.CurrentRow.Cells[0].Value.ToString());
                        note.Delete(id);

                        MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setNull();
                        showNote();
                    }

                    // Thực hiện trả sách trong chi tiết phiếu mượn
                    if (tabNote.SelectedTab == tabNote.TabPages[1])
                    {
                        int noteID = Convert.ToInt32(dgvNoteDetails.CurrentRow.Cells[0].Value.ToString());
                        int bookID = Convert.ToInt32(cboBook.SelectedValue.ToString());
                        int quantity = Convert.ToInt32(numQuantity.Value.ToString());

                        // Thực hiện xóa
                        detail.Delete(noteID, bookID);

                        // Cập nhật số lượng sách sau trả sách
                        SACH s = db.SACHes.Single(o => o.MASACH.Equals(bookID));
                        s.SOLUONG += quantity;
                        db.SubmitChanges();

                        MessageBox.Show("Bạn đã xác nhận trả thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setNull();
                        showNoteDetails();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lưu phiếu
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Thực hiên thêm mới
            if (addNew)
            {
                try
                {
                    // Thêm mới cho phiếu mượn
                    if (tabNote.SelectedTab == tabNote.TabPages[0])
                    {
                        if (checkNull())
                        {
                            // Bảng phiếu mượn
                            int readerID = Convert.ToInt32(cboReader.SelectedValue.ToString());
                            int employeeID = Convert.ToInt32(cboEmployee.SelectedValue.ToString());

                            // Thực hiện thêm phiếu
                            note.Create(readerID, employeeID);

                            MessageBox.Show("Bạn đã thêm mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showNote();
                            setNull();
                            setValue(true);
                            setButton(true);
                        }
                    }

                    // Mượn sách
                    if (tabNote.SelectedTab == tabNote.TabPages[1])
                    {
                        if (checkNullDetails())
                        {
                            // Bảng chi tiết phiếu mượn
                            int noteID = Convert.ToInt32(cboNoteM.SelectedValue.ToString());
                            int bookID = Convert.ToInt32(cboBook.SelectedValue.ToString());
                            string dateStart = dtpDateStart.Value.ToString("yyyy/MM/dd");
                            string dateEnd = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                            int quantity = Convert.ToInt32(numQuantity.Value.ToString());
                            string notes = txtNotes.Text;

                            SACH s = db.SACHes.Single(o => o.MASACH.Equals(bookID));
                            if (s.SOLUONG >= 0 && quantity <= s.SOLUONG)
                            {
                                // Thực hiện thêm mượn
                                detail.Create(noteID, bookID, dateStart, dateEnd, quantity, notes);

                                // Cập nhật số lượng sách sau khi mượn
                                s.SOLUONG -= quantity;
                                db.SubmitChanges();

                                MessageBox.Show("Bạn đã thêm mượn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                showNoteDetails();
                                new frmBooks().Refresh();

                                // Cập nhật lại các giá trị
                                setNull();
                                setValue(true);
                                setButton(true);
                            }
                            else
                                MessageBox.Show("Đã hết sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    // Chỉnh sửa phiếu mượn
                    if (tabNote.SelectedTab == tabNote.TabPages[0])
                    {
                        if (checkNull())
                        {
                            // Bảng phiếu mượn
                            int readerID = Convert.ToInt32(cboReader.SelectedValue.ToString());
                            int employeeID = Convert.ToInt32(cboEmployee.SelectedValue.ToString());
                            int tt = Convert.ToInt32(dgvNoteM.CurrentRow.Cells[0].Value.ToString());

                            note.Edit(tt, readerID, employeeID);

                            MessageBox.Show("Bạn đã chỉnh sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showNote();
                            setNull();
                            setValue(true);
                            setButton(true);
                        }
                    }

                    // Chỉnh sửa, gia hạn thời gian mượn
                    if (tabNote.SelectedTab == tabNote.TabPages[1])
                    {
                        if (checkNullDetails())
                        {
                            // Bảng chi tiết phiếu mượn
                            int noteID = Convert.ToInt32(cboNoteM.SelectedValue.ToString());
                            int bookID = Convert.ToInt32(cboBook.SelectedValue.ToString());
                            string dateStart = dtpDateStart.Value.ToString("yyyy/MM/dd");
                            string dateEnd = dtpDateEnd.Value.ToString("yyyy/MM/dd");
                            int quantity = Convert.ToInt32(numQuantity.Value.ToString());
                            string notes = txtNotes.Text;

                            detail.Edit(noteID, bookID, dateStart, dateEnd, quantity, notes);

                            MessageBox.Show("Bạn đã gia hạn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            showNoteDetails();
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
            frmNote_Load(sender, e);
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
                    dgvNoteDetails.DataSource = detail.Search(id);
                }
                else if (rdoDate.Checked)
                {
                    //DateTime dt = (DateTime)txtSearch.ToString("yyyy/MM/dd");
                    dgvNoteDetails.DataSource = detail.Search(txtSearch.Text);
                }
                else
                    showNoteDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelS_Click(object sender, EventArgs e)
        {
            btnCancelS.Enabled = false;
            txtSearch.Text = "";
            showNoteDetails();
        }
        #endregion

        private void tabNote_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabNote.SelectedTab == tabNote.TabPages[0])
            {
                btnCreate.Text = "Thêm";
                btnEdit.Text = "Sửa";
                btnDelete.Text = "Xóa";
                txtTilte.Text = "QUẢN LÝ PHIẾU MƯỢN";
            }
            else if (tabNote.SelectedTab == tabNote.TabPages[1])
            {
                btnCreate.Text = "Mượn";
                btnEdit.Text = "Gia hạn";
                btnDelete.Text = "Trả sách";
                txtTilte.Text = "PHIẾU MƯỢN CHI TIẾT";
            }
        }

        #region Xuất file
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Export Excel";
            save.Filter = "Excel (*.xlsx)|*xlsx|Excel 2003 (*.xls)|*xls";
            if (save.ShowDialog() == DialogResult.OK)
                new ExportExcel().ToExcel(dgvNoteDetails, save.FileName, "CHI TIẾT PHIẾU MƯỢN");
        }
        #endregion
    }
}
