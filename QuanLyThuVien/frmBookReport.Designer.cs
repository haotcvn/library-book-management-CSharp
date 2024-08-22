namespace QuanLyThuVien
{
    partial class frmBookReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookReport));
            this.vi_BookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyThuVienDataSet = new QuanLyThuVien.QuanLyThuVienDataSet();
            this.rpVBooks = new Microsoft.Reporting.WinForms.ReportViewer();
            this.vi_BookTableAdapter = new QuanLyThuVien.QuanLyThuVienDataSetTableAdapters.vi_BookTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.cboOption = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.vi_BookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyThuVienDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vi_BookBindingSource
            // 
            this.vi_BookBindingSource.DataMember = "vi_Book";
            this.vi_BookBindingSource.DataSource = this.QuanLyThuVienDataSet;
            // 
            // QuanLyThuVienDataSet
            // 
            this.QuanLyThuVienDataSet.DataSetName = "QuanLyThuVienDataSet";
            this.QuanLyThuVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpVBooks
            // 
            this.rpVBooks.AutoScroll = true;
            this.rpVBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rpVBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vi_BookBindingSource;
            this.rpVBooks.LocalReport.DataSources.Add(reportDataSource1);
            this.rpVBooks.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.rpBooks.rdlc";
            this.rpVBooks.Location = new System.Drawing.Point(0, 0);
            this.rpVBooks.Name = "rpVBooks";
            this.rpVBooks.Size = new System.Drawing.Size(1030, 517);
            this.rpVBooks.TabIndex = 0;
            // 
            // vi_BookTableAdapter
            // 
            this.vi_BookTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnStatistical);
            this.groupBox1.Controls.Add(this.cboOption);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1030, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(318, 22);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(67, 24);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnStatistical
            // 
            this.btnStatistical.Location = new System.Drawing.Point(236, 22);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(75, 24);
            this.btnStatistical.TabIndex = 1;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.UseVisualStyleBackColor = true;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click);
            // 
            // cboOption
            // 
            this.cboOption.FormattingEnabled = true;
            this.cboOption.Location = new System.Drawing.Point(12, 22);
            this.cboOption.Name = "cboOption";
            this.cboOption.Size = new System.Drawing.Size(209, 24);
            this.cboOption.TabIndex = 0;
            this.cboOption.Text = "-- Tùy chọn --";
            // 
            // frmBookReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1030, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rpVBooks);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmBookReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ VÀ BÁO CÁO SÁCH";
            this.Load += new System.EventHandler(this.frmBookReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vi_BookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyThuVienDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpVBooks;
        private System.Windows.Forms.BindingSource vi_BookBindingSource;
        private QuanLyThuVienDataSet QuanLyThuVienDataSet;
        private QuanLyThuVienDataSetTableAdapters.vi_BookTableAdapter vi_BookTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.ComboBox cboOption;
        private System.Windows.Forms.Button btnExit;
    }
}