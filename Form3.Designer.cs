namespace BLOODDONATION
{
    partial class frmDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonor));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBloodGrp = new System.Windows.Forms.ComboBox();
            this.btnDSubmit = new System.Windows.Forms.Button();
            this.txtPhno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "DONOR INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(323, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "DID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(577, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNAME :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "BLOODGROUP :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(323, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "REGISTERED DATE:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "GENDER :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(336, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "AGE :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAge.Location = new System.Drawing.Point(416, 260);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(120, 24);
            this.txtAge.TabIndex = 9;
            // 
            // cmbGender
            // 
            this.cmbGender.DisplayMember = "MALE";
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbGender.Location = new System.Drawing.Point(712, 260);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(145, 28);
            this.cmbGender.TabIndex = 11;
            this.cmbGender.ValueMember = "FEMALE";
            // 
            // dtpRegDate
            // 
            this.dtpRegDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpRegDate.Location = new System.Drawing.Point(633, 344);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(202, 26);
            this.dtpRegDate.TabIndex = 12;
            this.dtpRegDate.Value = new System.DateTime(2019, 10, 30, 13, 53, 0, 0);
            // 
            // cmbBloodGrp
            // 
            this.cmbBloodGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbBloodGrp.FormattingEnabled = true;
            this.cmbBloodGrp.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbBloodGrp.Location = new System.Drawing.Point(567, 504);
            this.cmbBloodGrp.Name = "cmbBloodGrp";
            this.cmbBloodGrp.Size = new System.Drawing.Size(120, 28);
            this.cmbBloodGrp.TabIndex = 13;
            // 
            // btnDSubmit
            // 
            this.btnDSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnDSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSubmit.Location = new System.Drawing.Point(469, 581);
            this.btnDSubmit.Name = "btnDSubmit";
            this.btnDSubmit.Size = new System.Drawing.Size(218, 44);
            this.btnDSubmit.TabIndex = 16;
            this.btnDSubmit.Text = "SUBMIT";
            this.btnDSubmit.UseVisualStyleBackColor = false;
            this.btnDSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPhno
            // 
            this.txtPhno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhno.Location = new System.Drawing.Point(567, 424);
            this.txtPhno.Multiline = true;
            this.txtPhno.Name = "txtPhno";
            this.txtPhno.Size = new System.Drawing.Size(120, 24);
            this.txtPhno.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(387, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "PHONE NO:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDID
            // 
            this.txtDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDID.Location = new System.Drawing.Point(416, 182);
            this.txtDID.Multiline = true;
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(112, 24);
            this.txtDID.TabIndex = 7;
            this.txtDID.TextChanged += new System.EventHandler(this.txtDID_TextChanged);
            // 
            // txtDName
            // 
            this.txtDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDName.Location = new System.Drawing.Point(689, 182);
            this.txtDName.Multiline = true;
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(168, 24);
            this.txtDName.TabIndex = 8;
            // 
            // frmDonor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 734);
            this.Controls.Add(this.txtPhno);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDSubmit);
            this.Controls.Add(this.cmbBloodGrp);
            this.Controls.Add(this.dtpRegDate);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.txtDID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmDonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmDonor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpRegDate;
        private System.Windows.Forms.ComboBox cmbBloodGrp;
        private System.Windows.Forms.Button btnDSubmit;
        private System.Windows.Forms.TextBox txtPhno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.TextBox txtDName;
    }
}