namespace BLOODDONATION
{
    partial class frmReceiever
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiever));
            this.btnRsubmit = new System.Windows.Forms.Button();
            this.dtpRdate = new System.Windows.Forms.DateTimePicker();
            this.cmbRgender = new System.Windows.Forms.ComboBox();
            this.txtRage = new System.Windows.Forms.TextBox();
            this.txtRname = new System.Windows.Forms.TextBox();
            this.txtRid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRbg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRsubmit
            // 
            this.btnRsubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnRsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRsubmit.Location = new System.Drawing.Point(473, 628);
            this.btnRsubmit.Name = "btnRsubmit";
            this.btnRsubmit.Size = new System.Drawing.Size(218, 44);
            this.btnRsubmit.TabIndex = 32;
            this.btnRsubmit.Text = "SUBMIT";
            this.btnRsubmit.UseVisualStyleBackColor = false;
            this.btnRsubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpRdate
            // 
            this.dtpRdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpRdate.Location = new System.Drawing.Point(604, 424);
            this.dtpRdate.Name = "dtpRdate";
            this.dtpRdate.Size = new System.Drawing.Size(193, 26);
            this.dtpRdate.TabIndex = 28;
            // 
            // cmbRgender
            // 
            this.cmbRgender.DisplayMember = "MALE";
            this.cmbRgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbRgender.FormattingEnabled = true;
            this.cmbRgender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbRgender.Location = new System.Drawing.Point(696, 295);
            this.cmbRgender.Name = "cmbRgender";
            this.cmbRgender.Size = new System.Drawing.Size(91, 28);
            this.cmbRgender.TabIndex = 27;
            this.cmbRgender.ValueMember = "FEMALE";
            // 
            // txtRage
            // 
            this.txtRage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRage.Location = new System.Drawing.Point(384, 299);
            this.txtRage.Multiline = true;
            this.txtRage.Name = "txtRage";
            this.txtRage.Size = new System.Drawing.Size(154, 24);
            this.txtRage.TabIndex = 26;
            this.txtRage.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtRname
            // 
            this.txtRname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRname.Location = new System.Drawing.Point(696, 201);
            this.txtRname.Multiline = true;
            this.txtRname.Name = "txtRname";
            this.txtRname.Size = new System.Drawing.Size(215, 24);
            this.txtRname.TabIndex = 25;
            this.txtRname.TextChanged += new System.EventHandler(this.txtRname_TextChanged);
            // 
            // txtRid
            // 
            this.txtRid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRid.Location = new System.Drawing.Point(384, 201);
            this.txtRid.Multiline = true;
            this.txtRid.Name = "txtRid";
            this.txtRid.Size = new System.Drawing.Size(154, 24);
            this.txtRid.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(276, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 32);
            this.label7.TabIndex = 23;
            this.label7.Text = "AGE :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(569, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 32);
            this.label6.TabIndex = 22;
            this.label6.Text = "GENDER :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 67);
            this.label5.TabIndex = 21;
            this.label5.Text = "REGISTERING DATE :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "RNAME :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 37);
            this.label2.TabIndex = 18;
            this.label2.Text = "RID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 100);
            this.label1.TabIndex = 17;
            this.label1.Text = "RECIEVER INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 520);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 43);
            this.label4.TabIndex = 20;
            this.label4.Text = "BLOODGROUP :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbRbg
            // 
            this.cmbRbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbRbg.FormattingEnabled = true;
            this.cmbRbg.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cmbRbg.Location = new System.Drawing.Point(622, 531);
            this.cmbRbg.Name = "cmbRbg";
            this.cmbRbg.Size = new System.Drawing.Size(81, 28);
            this.cmbRbg.TabIndex = 29;
            // 
            // frmReceiever
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1149, 759);
            this.Controls.Add(this.btnRsubmit);
            this.Controls.Add(this.cmbRbg);
            this.Controls.Add(this.dtpRdate);
            this.Controls.Add(this.cmbRgender);
            this.Controls.Add(this.txtRage);
            this.Controls.Add(this.txtRname);
            this.Controls.Add(this.txtRid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmReceiever";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frmReceiever_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRsubmit;
        private System.Windows.Forms.DateTimePicker dtpRdate;
        private System.Windows.Forms.ComboBox cmbRgender;
        private System.Windows.Forms.TextBox txtRage;
        private System.Windows.Forms.TextBox txtRname;
        private System.Windows.Forms.TextBox txtRid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRbg;
    }
}