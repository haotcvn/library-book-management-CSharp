namespace QuanLyThuVien
{
    partial class frmNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNote));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCreate = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTilte = new System.Windows.Forms.TextBox();
            this.tabNote = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grReader = new System.Windows.Forms.GroupBox();
            this.dgvNoteM = new System.Windows.Forms.DataGridView();
            this.grInfoDetail = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboReader = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvNoteDetails = new System.Windows.Forms.DataGridView();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancelS = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cboBook = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cboNoteM = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabNote.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grReader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteM)).BeginInit();
            this.grInfoDetail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteDetails)).BeginInit();
            this.grSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(775, 25);
            this.toolStrip1.TabIndex = 25;
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
            this.panel1.Controls.Add(this.txtTilte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 30);
            this.panel1.TabIndex = 26;
            // 
            // txtTilte
            // 
            this.txtTilte.BackColor = System.Drawing.Color.LightBlue;
            this.txtTilte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTilte.Enabled = false;
            this.txtTilte.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTilte.Location = new System.Drawing.Point(0, 0);
            this.txtTilte.Name = "txtTilte";
            this.txtTilte.Size = new System.Drawing.Size(771, 27);
            this.txtTilte.TabIndex = 4;
            this.txtTilte.Text = "QUẢN LÝ PHIẾU MƯỢN";
            this.txtTilte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabNote
            // 
            this.tabNote.Controls.Add(this.tabPage1);
            this.tabNote.Controls.Add(this.tabPage2);
            this.tabNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNote.Location = new System.Drawing.Point(0, 55);
            this.tabNote.Name = "tabNote";
            this.tabNote.SelectedIndex = 0;
            this.tabNote.Size = new System.Drawing.Size(775, 410);
            this.tabNote.TabIndex = 27;
            this.tabNote.SelectedIndexChanged += new System.EventHandler(this.tabNote_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grReader);
            this.tabPage1.Controls.Add(this.grInfoDetail);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phiếu mượn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grReader
            // 
            this.grReader.Controls.Add(this.dgvNoteM);
            this.grReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grReader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grReader.Location = new System.Drawing.Point(322, 3);
            this.grReader.Margin = new System.Windows.Forms.Padding(4);
            this.grReader.Name = "grReader";
            this.grReader.Padding = new System.Windows.Forms.Padding(4);
            this.grReader.Size = new System.Drawing.Size(442, 375);
            this.grReader.TabIndex = 28;
            this.grReader.TabStop = false;
            this.grReader.Text = "Thông tin chung";
            // 
            // dgvNoteM
            // 
            this.dgvNoteM.AllowUserToAddRows = false;
            this.dgvNoteM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNoteM.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNoteM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNoteM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoteM.Location = new System.Drawing.Point(4, 20);
            this.dgvNoteM.Name = "dgvNoteM";
            this.dgvNoteM.ReadOnly = true;
            this.dgvNoteM.Size = new System.Drawing.Size(434, 351);
            this.dgvNoteM.TabIndex = 0;
            this.dgvNoteM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNoteM_CellClick);
            this.dgvNoteM.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvNoteM_RowPostPaint);
            this.dgvNoteM.DoubleClick += new System.EventHandler(this.dgvNoteM_DoubleClick);
            // 
            // grInfoDetail
            // 
            this.grInfoDetail.Controls.Add(this.panel2);
            this.grInfoDetail.Controls.Add(this.panel3);
            this.grInfoDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.grInfoDetail.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grInfoDetail.Location = new System.Drawing.Point(3, 3);
            this.grInfoDetail.Margin = new System.Windows.Forms.Padding(4);
            this.grInfoDetail.Name = "grInfoDetail";
            this.grInfoDetail.Padding = new System.Windows.Forms.Padding(4);
            this.grInfoDetail.Size = new System.Drawing.Size(319, 375);
            this.grInfoDetail.TabIndex = 26;
            this.grInfoDetail.TabStop = false;
            this.grInfoDetail.Text = "Thông tin chi tiết";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cboEmployee);
            this.panel2.Location = new System.Drawing.Point(7, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 40);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Người lập:";
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(107, 9);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(176, 24);
            this.cboEmployee.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cboReader);
            this.panel3.Location = new System.Drawing.Point(7, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 40);
            this.panel3.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ tên độc giả:";
            // 
            // cboReader
            // 
            this.cboReader.FormattingEnabled = true;
            this.cboReader.Location = new System.Drawing.Point(107, 9);
            this.cboReader.Name = "cboReader";
            this.cboReader.Size = new System.Drawing.Size(176, 24);
            this.cboReader.TabIndex = 8;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.grSearch);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chi tiết phiếu mượn - trả";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvNoteDetails);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(322, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(442, 270);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // dgvNoteDetails
            // 
            this.dgvNoteDetails.AllowUserToAddRows = false;
            this.dgvNoteDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNoteDetails.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNoteDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNoteDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNoteDetails.Location = new System.Drawing.Point(4, 20);
            this.dgvNoteDetails.Name = "dgvNoteDetails";
            this.dgvNoteDetails.ReadOnly = true;
            this.dgvNoteDetails.Size = new System.Drawing.Size(434, 246);
            this.dgvNoteDetails.TabIndex = 0;
            this.dgvNoteDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNoteDetails_CellClick);
            this.dgvNoteDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvNoteDetails_RowPostPaint);
            // 
            // grSearch
            // 
            this.grSearch.Controls.Add(this.btnExport);
            this.grSearch.Controls.Add(this.btnCancelS);
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.txtSearch);
            this.grSearch.Controls.Add(this.rdoDate);
            this.grSearch.Controls.Add(this.rdoID);
            this.grSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grSearch.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearch.Location = new System.Drawing.Point(322, 3);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(442, 105);
            this.grSearch.TabIndex = 30;
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
            this.btnExport.TabIndex = 29;
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
            this.btnCancelS.TabIndex = 28;
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
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(18, 60);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 23);
            this.txtSearch.TabIndex = 23;
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(117, 33);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(87, 20);
            this.rdoDate.TabIndex = 19;
            this.rdoDate.Text = "Ngày nượn";
            this.rdoDate.UseVisualStyleBackColor = true;
            // 
            // rdoID
            // 
            this.rdoID.AutoSize = true;
            this.rdoID.Checked = true;
            this.rdoID.Location = new System.Drawing.Point(18, 33);
            this.rdoID.Name = "rdoID";
            this.rdoID.Size = new System.Drawing.Size(76, 20);
            this.rdoID.TabIndex = 18;
            this.rdoID.TabStop = true;
            this.rdoID.Text = "Số phiếu";
            this.rdoID.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.panel10);
            this.groupBox1.Controls.Add(this.panel11);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(319, 375);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numQuantity);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(7, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 40);
            this.panel4.TabIndex = 12;
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
            this.numQuantity.Size = new System.Drawing.Size(176, 23);
            this.numQuantity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số lượng:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtNotes);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(7, 253);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 40);
            this.panel5.TabIndex = 12;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(107, 9);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(176, 23);
            this.txtNotes.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ghi chú:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dtpDateEnd);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Location = new System.Drawing.Point(7, 161);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(294, 40);
            this.panel8.TabIndex = 12;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(107, 7);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(176, 23);
            this.dtpDateEnd.TabIndex = 5;
            this.dtpDateEnd.Value = new System.DateTime(2023, 5, 13, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ngày trả:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtpDateStart);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Location = new System.Drawing.Point(7, 115);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(294, 40);
            this.panel9.TabIndex = 13;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(107, 7);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(176, 23);
            this.dtpDateStart.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày mượn:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.cboBook);
            this.panel10.Location = new System.Drawing.Point(7, 69);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(294, 40);
            this.panel10.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tên sách:";
            // 
            // cboBook
            // 
            this.cboBook.FormattingEnabled = true;
            this.cboBook.Location = new System.Drawing.Point(107, 9);
            this.cboBook.Name = "cboBook";
            this.cboBook.Size = new System.Drawing.Size(176, 24);
            this.cboBook.TabIndex = 8;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label10);
            this.panel11.Controls.Add(this.cboNoteM);
            this.panel11.Location = new System.Drawing.Point(7, 23);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(294, 40);
            this.panel11.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số phiếu mượn:";
            // 
            // cboNoteM
            // 
            this.cboNoteM.FormattingEnabled = true;
            this.cboNoteM.Location = new System.Drawing.Point(107, 9);
            this.cboNoteM.Name = "cboNoteM";
            this.cboNoteM.Size = new System.Drawing.Size(176, 24);
            this.cboNoteM.TabIndex = 8;
            // 
            // frmNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 465);
            this.Controls.Add(this.tabNote);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNote";
            this.Text = "PHIẾU MƯỢN - TRẢ";
            this.Load += new System.EventHandler(this.frmNote_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabNote.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grReader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteM)).EndInit();
            this.grInfoDetail.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoteDetails)).EndInit();
            this.grSearch.ResumeLayout(false);
            this.grSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
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
        private System.Windows.Forms.TabControl tabNote;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grInfoDetail;
        private System.Windows.Forms.GroupBox grReader;
        private System.Windows.Forms.DataGridView dgvNoteM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvNoteDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboReader;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboBook;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboNoteM;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancelS;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTilte;
    }
}