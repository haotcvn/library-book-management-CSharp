using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmQLThuVien : Form
    {
        public frmQLThuVien()
        {
            InitializeComponent();
        }

        private void frmQLThuVien_Load(object sender, EventArgs e)
        {
            try
            {
                setStatus();

                // Thực hiện đăng nhập
                this.login();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Hide_Show_AllMenu(Boolean VisibleValue)
        {
            this.btDangXuat.Visible = VisibleValue;
            this.btCategories.Visible = VisibleValue;
            this.btReport.Visible = VisibleValue;
            this.toolStrip1.Visible = VisibleValue;
        }

        // Thực hiện
        
        #region Nút menuStrip
        private void btDangNhap_Click(object sender, EventArgs e)
        {
            this.login();
        }

        // Đăng nhập 
        void login()
        {
            try
            {
                Hide_Show_AllMenu(false);
                Form f = new frmLogin();
                DialogResult res = f.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    Hide_Show_AllMenu(true);
                    f.Close();
                }
                else
                {
                    Hide_Show_AllMenu(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thực hiện đăng xuất
        private void btDangXuat_Click(object sender, EventArgs e)
        {
            new frmQLThuVien().ShowDialog();
        }

        // Thực hiện gọi form thống kê - báo cáo sách
        //== Báo cáo độc giả
        private void btRpReader_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "frmReaderReport")
                    {
                        f.Activate();
                        return;
                    }
                }
                frmReaderReport rpReader = new frmReaderReport();
                rpReader.MdiParent = this;
                rpReader.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //== Báo cáo sách
        private void btRpBooks_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "frmBookReport")
                    {
                        f.Activate();
                        return;
                    }
                }
                frmBookReport rpBook = new frmBookReport();
                rpBook.MdiParent = this;
                rpBook.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút danh mục ============================================
        private void btReader_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "frmReader")
                    {
                        f.Activate();
                        return;
                    }
                }
                frmReader reader = new frmReader();
                reader.MdiParent = this;
                reader.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBook_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "frmBooks")
                    {
                        f.Activate();
                        return;
                    }
                }
                frmBooks book = new frmBooks();
                book.MdiParent = this;
                book.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btTopic_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "frmTopic")
                    {
                        f.Activate();
                        return;
                    }
                }
                frmTopic topic = new frmTopic();
                topic.MdiParent = this;
                topic.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "frmAuthor")
                    {
                        f.Activate();
                        return;
                    }
                }
                frmAuthor author = new frmAuthor();
                author.MdiParent = this;
                author.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btPublisher_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "frmPublisher")
                    {
                        f.Activate();
                        return;
                    }
                }
                frmPublisher publisher = new frmPublisher();
                publisher.MdiParent = this;
                publisher.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNote_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == "frmNote")
                    {
                        f.Activate();
                        return;
                    }
                }
                frmNote note = new frmNote();
                note.MdiParent = this;
                note.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // End nút danh mục ============================================

        // Nút xem lịch
        private void btnCalendar_Click(object sender, EventArgs e)
        {
            new frmCalendar().ShowDialog();
        }

        // Nút thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                this.Close();
        }
        #endregion

        #region Nút toolStrip
        // Thực hiện gọi form đọc giả
        private void btnReader_Click(object sender, EventArgs e)
        {
            try
            {
                this.btReader_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thực hiện gọi form sách
        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                this.btBook_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thực hiện gọi form chủ đề
        private void btnTopic_Click(object sender, EventArgs e)
        {
            try
            {
                this.btTopic_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thực hiện gọi form tác giả
        private void btnAuthor_Click(object sender, EventArgs e)
        {
            try 
            {
                this.btAuthor_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thực hiện gọi form nhà xuất bản
        private void btnPublisher_Click(object sender, EventArgs e)
        {
            try
            {
                this.btPublisher_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thực hiện gọi form phiếu mượn - trả
        private void btnNote_Click(object sender, EventArgs e)
        {
            try
            {
                this.btNote_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Status
        // Thời gian 
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            tslbTime.Text = DateTime.Now.ToString();
        }

        void setStatus()
        {
            timer.Start();
            tslbReady.Alignment = ToolStripItemAlignment.Left;
            tslbTime.Alignment = ToolStripItemAlignment.Right;
        }
        #endregion
    }
}
