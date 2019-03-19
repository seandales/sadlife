namespace WindowsFormsApp2
{
    partial class AddProgramSegment
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
            this.DGV_Segm = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProgTopic = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSpeaker = new System.Windows.Forms.TextBox();
            this.dtpEDate = new System.Windows.Forms.DateTimePicker();
            this.dtpSDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.cbTime2 = new System.Windows.Forms.ComboBox();
            this.tbSMinute = new System.Windows.Forms.TextBox();
            this.tbSHour = new System.Windows.Forms.TextBox();
            this.tbEHour = new System.Windows.Forms.TextBox();
            this.tbEMinute = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Segm)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Segm
            // 
            this.DGV_Segm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Segm.Location = new System.Drawing.Point(482, 121);
            this.DGV_Segm.Name = "DGV_Segm";
            this.DGV_Segm.Size = new System.Drawing.Size(418, 485);
            this.DGV_Segm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program Topic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // tbProgTopic
            // 
            this.tbProgTopic.Location = new System.Drawing.Point(177, 96);
            this.tbProgTopic.Multiline = true;
            this.tbProgTopic.Name = "tbProgTopic";
            this.tbProgTopic.Size = new System.Drawing.Size(246, 27);
            this.tbProgTopic.TabIndex = 3;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(177, 206);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(246, 117);
            this.tbDesc.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(306, 560);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 46);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(177, 560);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 46);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-115, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1162, 58);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label3.Location = new System.Drawing.Point(465, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ADD PROGRAM SEGMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Time:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "End Time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Program Speaker:";
            // 
            // tbSpeaker
            // 
            this.tbSpeaker.Location = new System.Drawing.Point(177, 154);
            this.tbSpeaker.Multiline = true;
            this.tbSpeaker.Name = "tbSpeaker";
            this.tbSpeaker.Size = new System.Drawing.Size(246, 27);
            this.tbSpeaker.TabIndex = 13;
            // 
            // dtpEDate
            // 
            this.dtpEDate.Location = new System.Drawing.Point(177, 492);
            this.dtpEDate.Name = "dtpEDate";
            this.dtpEDate.Size = new System.Drawing.Size(246, 20);
            this.dtpEDate.TabIndex = 17;
            // 
            // dtpSDate
            // 
            this.dtpSDate.Location = new System.Drawing.Point(177, 445);
            this.dtpSDate.Name = "dtpSDate";
            this.dtpSDate.Size = new System.Drawing.Size(246, 20);
            this.dtpSDate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "End Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Start Date:";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(482, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 31);
            this.panel2.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(213, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(212, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = ":";
            // 
            // cbTime
            // 
            this.cbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbTime.Location = new System.Drawing.Point(277, 343);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(52, 28);
            this.cbTime.TabIndex = 25;
            this.cbTime.Text = "PM";
            // 
            // cbTime2
            // 
            this.cbTime2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTime2.FormattingEnabled = true;
            this.cbTime2.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbTime2.Location = new System.Drawing.Point(277, 385);
            this.cbTime2.Name = "cbTime2";
            this.cbTime2.Size = new System.Drawing.Size(51, 28);
            this.cbTime2.TabIndex = 30;
            this.cbTime2.Text = "PM";
            // 
            // tbSMinute
            // 
            this.tbSMinute.Location = new System.Drawing.Point(228, 343);
            this.tbSMinute.Multiline = true;
            this.tbSMinute.Name = "tbSMinute";
            this.tbSMinute.Size = new System.Drawing.Size(35, 29);
            this.tbSMinute.TabIndex = 32;
            // 
            // tbSHour
            // 
            this.tbSHour.Location = new System.Drawing.Point(177, 343);
            this.tbSHour.Multiline = true;
            this.tbSHour.Name = "tbSHour";
            this.tbSHour.Size = new System.Drawing.Size(35, 29);
            this.tbSHour.TabIndex = 33;
            this.tbSHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSHour_KeyPress);
            // 
            // tbEHour
            // 
            this.tbEHour.Location = new System.Drawing.Point(176, 384);
            this.tbEHour.Multiline = true;
            this.tbEHour.Name = "tbEHour";
            this.tbEHour.Size = new System.Drawing.Size(35, 29);
            this.tbEHour.TabIndex = 35;
            // 
            // tbEMinute
            // 
            this.tbEMinute.Location = new System.Drawing.Point(227, 384);
            this.tbEMinute.Multiline = true;
            this.tbEMinute.Name = "tbEMinute";
            this.tbEMinute.Size = new System.Drawing.Size(35, 29);
            this.tbEMinute.TabIndex = 34;
            // 
            // AddProgramSegment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 661);
            this.Controls.Add(this.tbEHour);
            this.Controls.Add(this.tbEMinute);
            this.Controls.Add(this.tbSHour);
            this.Controls.Add(this.tbSMinute);
            this.Controls.Add(this.cbTime2);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtpEDate);
            this.Controls.Add(this.dtpSDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSpeaker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.tbProgTopic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV_Segm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProgramSegment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProgramSegment";
            this.Load += new System.EventHandler(this.AddProgramSegment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Segm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Segm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProgTopic;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSpeaker;
        private System.Windows.Forms.DateTimePicker dtpEDate;
        private System.Windows.Forms.DateTimePicker dtpSDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cbTime2;
        private System.Windows.Forms.TextBox tbSMinute;
        private System.Windows.Forms.TextBox tbSHour;
        private System.Windows.Forms.TextBox tbEHour;
        private System.Windows.Forms.TextBox tbEMinute;
    }
}