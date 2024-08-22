namespace QuanLyThuVien
{
    partial class frmBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBooks));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grInfoDetail = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numPage = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPublishYear = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboPublisher = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.cboAuthor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddTopic = new System.Windows.Forms.Button();
            this.cboTopic = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancelS = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grReader = new System.Windows.Forms.GroupBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grInfoDetail.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grSearch.SuspendLayout();
            this.grReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Lavender;
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCreate,
            this.btnEdit,
            this.btnDelete,
            this.btnSave,
            this.btnCancel,
            this.btnRefresh,
            this.btnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(760, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCreate
            // 
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(61, 22);
            this.btnCreate.Text = "Thêm";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 22);
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 22);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(49, 22);
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 22);
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 22);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 22);
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 30);
            this.panel1.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightBlue;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(756, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "QUẢN LÝ SÁCH";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grInfoDetail
            // 
            this.grInfoDetail.Controls.Add(this.panel7);
            this.grInfoDetail.Controls.Add(this.panel8);
            this.grInfoDetail.Controls.Add(this.panel6);
            this.grInfoDetail.Controls.Add(this.panel5);
            this.grInfoDetail.Controls.Add(this.panel4);
            this.grInfoDetail.Controls.Add(this.panel3);
            this.grInfoDetail.Controls.Add(this.panel2);
            this.grInfoDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.grInfoDetail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInfoDetail.Location = new System.Drawing.Point(0, 55);
            this.grInfoDetail.Margin = new System.Windows.Forms.Padding(4);
            this.grInfoDetail.Name = "grInfoDetail";
            this.grInfoDetail.Padding = new System.Windows.Forms.Padding(4);
            this.grInfoDetail.Size = new System.Drawing.Size(319, 406);
            this.grInfoDetail.TabIndex = 0;
            this.grInfoDetail.TabStop = false;
            this.grInfoDetail.Text = "Thông tin chi tiết";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.numQuantity);
            this.panel7.Location = new System.Drawing.Point(10, 298);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(294, 40);
            this.panel7.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng:";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(107, 10);
            this.numQuantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(175, 23);
            this.numQuantity.TabIndex = 6;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.numPage);
            this.panel8.Location = new System.Drawing.Point(10, 252);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(294, 40);
            this.panel8.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số trang:";
            // 
            // numPage
            // 
            this.numPage.Location = new System.Drawing.Point(107, 10);
            this.numPage.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numPage.Name = "numPage";
            this.numPage.Size = new System.Drawing.Size(175, 23);
            this.numPage.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtPublishYear);
            this.panel6.Location = new System.Drawing.Point(10, 206);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(294, 40);
            this.panel6.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Năm xuất bản:";
            // 
            // txtPublishYear
            // 
            this.txtPublishYear.Location = new System.Drawing.Point(107, 9);
            this.txtPublishYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtPublishYear.Name = "txtPublishYear";
            this.txtPublishYear.Size = new System.Drawing.Size(176, 23);
            this.txtPublishYear.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAddPublisher);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.cboPublisher);
            this.panel5.Location = new System.Drawing.Point(10, 160);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 40);
            this.panel5.TabIndex = 0;
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPublisher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPublisher.BackgroundImage")));
            this.btnAddPublisher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPublisher.Location = new System.Drawing.Point(260, 9);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(23, 24);
            this.btnAddPublisher.TabIndex = 22;
            this.btnAddPublisher.UseVisualStyleBackColor = false;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhà xuất bản:";
            // 
            // cboPublisher
            // 
            this.cboPublisher.FormattingEnabled = true;
            this.cboPublisher.Location = new System.Drawing.Point(107, 9);
            this.cboPublisher.Name = "cboPublisher";
            this.cboPublisher.Size = new System.Drawing.Size(147, 24);
            this.cboPublisher.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddAuthor);
            this.panel4.Controls.Add(this.cboAuthor);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(10, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 40);
            this.panel4.TabIndex = 0;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAuthor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAuthor.BackgroundImage")));
            this.btnAddAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAuthor.Location = new System.Drawing.Point(260, 9);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(23, 24);
            this.btnAddAuthor.TabIndex = 22;
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // cboAuthor
            // 
            this.cboAuthor.FormattingEnabled = true;
            this.cboAuthor.Location = new System.Drawing.Point(107, 9);
            this.cboAuthor.Name = "cboAuthor";
            this.cboAuthor.Size = new System.Drawing.Size(147, 24);
            this.cboAuthor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tác giả:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddTopic);
            this.panel3.Controls.Add(this.cboTopic);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(10, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 40);
            this.panel3.TabIndex = 0;
            // 
            // btnAddTopic
            // 
            this.btnAddTopic.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTopic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddTopic.BackgroundImage")));
            this.btnAddTopic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTopic.Location = new System.Drawing.Point(260, 9);
            this.btnAddTopic.Name = "btnAddTopic";
            this.btnAddTopic.Size = new System.Drawing.Size(23, 24);
            this.btnAddTopic.TabIndex = 22;
            this.btnAddTopic.UseVisualStyleBackColor = false;
            this.btnAddTopic.Click += new System.EventHandler(this.btnAddTopic_Click);
            // 
            // cboTopic
            // 
            this.cboTopic.FormattingEnabled = true;
            this.cboTopic.Location = new System.Drawing.Point(107, 9);
            this.cboTopic.Name = "cboTopic";
            this.cboTopic.Size = new System.Drawing.Size(147, 24);
            this.cboTopic.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chủ đề:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Location = new System.Drawing.Point(10, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 40);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 9);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 23);
            this.txtName.TabIndex = 1;
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.btnExport);
            this.grSearch.Controls.Add(this.btnCancelS);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.rdoName);
            this.grSearch.Controls.Add(this.rdoID);
            this.grSearch.Controls.Add(this.txtSearch);
            this.grSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearch.Location = new System.Drawing.Point(319, 55);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(441, 105);
            this.grSearch.TabIndex = 0;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Tìm kiếm";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(343, 60);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(92, 23);
            this.btnExport.TabIndex = 26;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancelS
            // 
            this.btnCancelS.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelS.Image")));
            this.btnCancelS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelS.Location = new System.Drawing.Point(270, 60);
            this.btnCancelS.Name = "btnCancelS";
            this.btnCancelS.Size = new System.Drawing.Size(58, 23);
            this.btnCancelS.TabIndex = 25;
            this.btnCancelS.Text = "Hủy";
            this.btnCancelS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelS.UseVisualStyleBackColor = true;
            this.btnCancelS.Click += new System.EventHandler(this.btnCancelS_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(209, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 23);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(117, 33);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(78, 20);
            this.rdoName.TabIndex = 8;
            this.rdoName.Text = "Tên sách";
            this.rdoName.UseVisualStyleBackColor = true;
            // 
            // rdoID
            // 
            this.rdoID.AutoSize = true;
            this.rdoID.Checked = true;
            this.rdoID.Location = new System.Drawing.Point(18, 33);
            this.rdoID.Name = "rdoID";
            this.rdoID.Size = new System.Drawing.Size(73, 20);
            this.rdoID.TabIndex = 7;
            this.rdoID.TabStop = true;
            this.rdoID.Text = "Mã sách";
            this.rdoID.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(18, 60);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 23);
            this.txtSearch.TabIndex = 9;
            // 
            // grReader
            // 
            this.grReader.Controls.Add(this.dgvBooks);
            this.grReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grReader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grReader.Location = new System.Drawing.Point(319, 160);
            this.grReader.Margin = new System.Windows.Forms.Padding(4);
            this.grReader.Name = "grReader";
            this.grReader.Padding = new System.Windows.Forms.Padding(4);
            this.grReader.Size = new System.Drawing.Size(441, 301);
            this.grReader.TabIndex = 0;
            this.grReader.TabStop = false;
            this.grReader.Text = "Thông tin chung";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(4, 20);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(433, 277);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            this.dgvBooks.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvBooks_RowPostPaint);
            // 
            // frmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 461);
            this.Controls.Add(this.grReader);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.grInfoDetail);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBooks";
            this.Text = "QUẢN LÝ SÁCH";
            this.Load += new System.EventHandler(this.frmBooks_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grInfoDetail.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPage)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.grReader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCreate;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grInfoDetail;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ComboBox cboPublisher;
        private System.Windows.Forms.ComboBox cboAuthor;
        private System.Windows.Forms.ComboBox cboTopic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublishYear;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grReader;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnAddTopic;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPage;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancelS;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
    }
}