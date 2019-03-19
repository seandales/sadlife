namespace WindowsFormsApp2
{
    partial class SetRGuestAppointment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.lbReason = new System.Windows.Forms.Label();
            this.cbGType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSet = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.rbold = new System.Windows.Forms.RadioButton();
            this.rbnew = new System.Windows.Forms.RadioButton();
            this.tcGuest = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnOldGuest = new System.Windows.Forms.Button();
            this.btnNewGuest = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbStatus_ = new System.Windows.Forms.ComboBox();
            this.tbAddress_ = new System.Windows.Forms.TextBox();
            this.tbContactNum_ = new System.Windows.Forms.TextBox();
            this.tbName_ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tcGuest.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1554, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(372, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Appointment";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbReason);
            this.groupBox1.Controls.Add(this.lbReason);
            this.groupBox1.Controls.Add(this.cbGType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbLname);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbContact);
            this.groupBox1.Controls.Add(this.tbFname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(192, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 453);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guest Details";
            // 
            // tbReason
            // 
            this.tbReason.Location = new System.Drawing.Point(131, 358);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(204, 66);
            this.tbReason.TabIndex = 13;
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.Location = new System.Drawing.Point(128, 342);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(83, 13);
            this.lbReason.TabIndex = 12;
            this.lbReason.Text = "Reason for visit:";
            // 
            // cbGType
            // 
            this.cbGType.FormattingEnabled = true;
            this.cbGType.Items.AddRange(new object[] {
            "Walk in guest",
            "Radio Guest"});
            this.cbGType.Location = new System.Drawing.Point(131, 301);
            this.cbGType.Name = "cbGType";
            this.cbGType.Size = new System.Drawing.Size(204, 21);
            this.cbGType.TabIndex = 11;
            this.cbGType.SelectedIndexChanged += new System.EventHandler(this.cbGType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(132, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Guest Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(132, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Last Name:";
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(131, 97);
            this.tbLname.Multiline = true;
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(204, 25);
            this.tbLname.TabIndex = 9;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(131, 205);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(204, 66);
            this.tbAddress.TabIndex = 5;
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(131, 148);
            this.tbContact.Multiline = true;
            this.tbContact.Name = "tbContact";
            this.tbContact.Size = new System.Drawing.Size(204, 25);
            this.tbContact.TabIndex = 4;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(131, 40);
            this.tbFname.Multiline = true;
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(204, 25);
            this.tbFname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Contact No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(673, 678);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(191, 44);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "NEXT";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(487, 678);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(177, 44);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rbold
            // 
            this.rbold.AutoSize = true;
            this.rbold.Location = new System.Drawing.Point(41, 87);
            this.rbold.Name = "rbold";
            this.rbold.Size = new System.Drawing.Size(95, 17);
            this.rbold.TabIndex = 4;
            this.rbold.TabStop = true;
            this.rbold.Text = "returning guest";
            this.rbold.UseVisualStyleBackColor = true;
            this.rbold.Visible = false;
            this.rbold.CheckedChanged += new System.EventHandler(this.rbold_CheckedChanged);
            // 
            // rbnew
            // 
            this.rbnew.AutoSize = true;
            this.rbnew.Location = new System.Drawing.Point(154, 88);
            this.rbnew.Name = "rbnew";
            this.rbnew.Size = new System.Drawing.Size(74, 17);
            this.rbnew.TabIndex = 5;
            this.rbnew.TabStop = true;
            this.rbnew.Text = "new guest";
            this.rbnew.UseVisualStyleBackColor = true;
            this.rbnew.Visible = false;
            this.rbnew.CheckedChanged += new System.EventHandler(this.rbnew_CheckedChanged);
            // 
            // tcGuest
            // 
            this.tcGuest.Controls.Add(this.tabPage3);
            this.tcGuest.Controls.Add(this.tabPage1);
            this.tcGuest.Controls.Add(this.tabPage2);
            this.tcGuest.Location = new System.Drawing.Point(37, 114);
            this.tcGuest.Name = "tcGuest";
            this.tcGuest.SelectedIndex = 0;
            this.tcGuest.Size = new System.Drawing.Size(831, 558);
            this.tcGuest.TabIndex = 6;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnOldGuest);
            this.tabPage3.Controls.Add(this.btnNewGuest);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(823, 532);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnOldGuest
            // 
            this.btnOldGuest.Location = new System.Drawing.Point(215, 255);
            this.btnOldGuest.Name = "btnOldGuest";
            this.btnOldGuest.Size = new System.Drawing.Size(405, 82);
            this.btnOldGuest.TabIndex = 1;
            this.btnOldGuest.Text = "OLD GUEST";
            this.btnOldGuest.UseVisualStyleBackColor = true;
            this.btnOldGuest.Click += new System.EventHandler(this.btnOldGuest_Click);
            // 
            // btnNewGuest
            // 
            this.btnNewGuest.Location = new System.Drawing.Point(215, 164);
            this.btnNewGuest.Name = "btnNewGuest";
            this.btnNewGuest.Size = new System.Drawing.Size(405, 82);
            this.btnNewGuest.TabIndex = 0;
            this.btnNewGuest.Text = "NEW GUEST";
            this.btnNewGuest.UseVisualStyleBackColor = true;
            this.btnNewGuest.Click += new System.EventHandler(this.btnNewGuest_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 532);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(11, 335);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(798, 180);
            this.dataGridView3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(11, 287);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(799, 49);
            this.panel5.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 48);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(796, 165);
            this.dataGridView2.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label15.Location = new System.Drawing.Point(5, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(219, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Past Appointments of Guest";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.panel4.Controls.Add(this.cbStatus_);
            this.panel4.Controls.Add(this.tbAddress_);
            this.panel4.Controls.Add(this.tbContactNum_);
            this.panel4.Controls.Add(this.tbName_);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(11, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 211);
            this.panel4.TabIndex = 5;
            // 
            // cbStatus_
            // 
            this.cbStatus_.FormattingEnabled = true;
            this.cbStatus_.Items.AddRange(new object[] {
            "radio guest",
            "walk in guest"});
            this.cbStatus_.Location = new System.Drawing.Point(103, 145);
            this.cbStatus_.Name = "cbStatus_";
            this.cbStatus_.Size = new System.Drawing.Size(164, 21);
            this.cbStatus_.TabIndex = 7;
            // 
            // tbAddress_
            // 
            this.tbAddress_.Location = new System.Drawing.Point(102, 100);
            this.tbAddress_.Name = "tbAddress_";
            this.tbAddress_.Size = new System.Drawing.Size(165, 20);
            this.tbAddress_.TabIndex = 6;
            // 
            // tbContactNum_
            // 
            this.tbContactNum_.Location = new System.Drawing.Point(102, 65);
            this.tbContactNum_.Name = "tbContactNum_";
            this.tbContactNum_.Size = new System.Drawing.Size(165, 20);
            this.tbContactNum_.TabIndex = 5;
            // 
            // tbName_
            // 
            this.tbName_.Location = new System.Drawing.Point(102, 24);
            this.tbName_.Name = "tbName_";
            this.tbName_.Size = new System.Drawing.Size(165, 20);
            this.tbName_.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label13.Location = new System.Drawing.Point(5, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "status:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label12.Location = new System.Drawing.Point(5, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label11.Location = new System.Drawing.Point(5, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Contact Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label8.Location = new System.Drawing.Point(5, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(11, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 49);
            this.panel3.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label9.Location = new System.Drawing.Point(5, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Guest Details";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(302, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(508, 211);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(302, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 49);
            this.panel2.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(476, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(27, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label7.Location = new System.Drawing.Point(152, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Search by Last Name:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(304, 14);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(170, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label5.Location = new System.Drawing.Point(5, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "List of Guests";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(823, 532);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel6.Location = new System.Drawing.Point(37, 113);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(828, 24);
            this.panel6.TabIndex = 7;
            // 
            // SetRGuestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 733);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.tcGuest);
            this.Controls.Add(this.rbnew);
            this.Controls.Add(this.rbold);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Name = "SetRGuestAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetRGuestAppointment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetRGuestAppointment_FormClosing);
            this.Load += new System.EventHandler(this.SetRGuestAppointment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tcGuest.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.ComboBox cbGType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbold;
        private System.Windows.Forms.RadioButton rbnew;
        private System.Windows.Forms.TabControl tcGuest;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbAddress_;
        private System.Windows.Forms.TextBox tbContactNum_;
        private System.Windows.Forms.TextBox tbName_;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnOldGuest;
        private System.Windows.Forms.Button btnNewGuest;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbStatus_;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.Label lbReason;
    }
}