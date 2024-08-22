using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyThuVien.Class;

namespace QuanLyThuVien
{
    public partial class frmBookReport : Form
    {
        public frmBookReport()
        {
            InitializeComponent();
        }
        private void frmBookReport_Load(object sender, EventArgs e)
        {
            this.option();
        }
        void option()
        {
            this.cboOption.Items.Add("Tất cả sách");
            this.cboOption.Items.Add("Sách đang được mượn");
            this.cboOption.Items.Add("Sách trễ hẹn trả");
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            

            // Chế độ xem report
            //rpVBooks.SetDisplayMode(DisplayMode.PrintLayout); // đặt chế độ xem trước khi in

            // Thống kê tất cả sách trong thư viện
            if (cboOption.Text == "Tất cả sách")
            {
                try
                {
                    // Lấy báo cáo ở local
                    rpVBooks.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.rpBooks.rdlc";
                    rpVBooks.LocalReport.DataSources.Clear();
                    ReportDataSource rpData = new ReportDataSource();
                    rpData.Name = "DataSet1";
                    rpData.Value = new Books().listBooks();
                    rpVBooks.LocalReport.DataSources.Add(rpData);
                    this.rpVBooks.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Thống kê tất cả sách đang được mượn
            if (cboOption.Text == "Sách đang được mượn")
            {
                try
                {
                    rpVBooks.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.rpBooks.rdlc";
                    rpVBooks.LocalReport.DataSources.Clear();
                    ReportDataSource rpData = new ReportDataSource();
                    rpData.Name = "DataSet1";
                    rpData.Value = new Books().listBooked();
                    rpVBooks.LocalReport.DataSources.Add(rpData);
                    this.rpVBooks.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Thống kê tất cả sách độc giả mượn đã quá hạn trả
            if (cboOption.Text == "Sách trễ hẹn trả")
            {
                try
                {
                    rpVBooks.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.rp_Books.rdlc";
                    rpVBooks.LocalReport.DataSources.Clear();
                    ReportDataSource rpData = new ReportDataSource();
                    rpData.Name = "DataSet1";
                    rpData.Value = new Books().listLimitBook();
                    rpVBooks.LocalReport.DataSources.Add(rpData);
                    this.rpVBooks.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
