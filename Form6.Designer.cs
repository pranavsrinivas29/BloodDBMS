namespace BLOODDONATION
{
    partial class frmBB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBB));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTransac = new System.Windows.Forms.Button();
            this.txtBQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAvail = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDONORFind = new System.Windows.Forms.Button();
            this.comboBox112 = new System.Windows.Forms.ComboBox();
            this.txtrecvtest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "BLOODBANK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 70);
            this.label4.TabIndex = 14;
            this.label4.Text = "RECEIVER\'S BLOOD GROUP :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(354, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "RECEIVER ID :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "FIND YOUR CORRECT DONOR";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTransac
            // 
            this.btnTransac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTransac.Location = new System.Drawing.Point(432, 589);
            this.btnTransac.Name = "btnTransac";
            this.btnTransac.Size = new System.Drawing.Size(220, 45);
            this.btnTransac.TabIndex = 19;
            this.btnTransac.Text = "TRANSACTION";
            this.btnTransac.UseVisualStyleBackColor = true;
            this.btnTransac.Click += new System.EventHandler(this.btnFIndDonor_Click);
            // 
            // txtBQty
            // 
            this.txtBQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBQty.Location = new System.Drawing.Point(578, 418);
            this.txtBQty.Multiline = true;
            this.txtBQty.Name = "txtBQty";
            this.txtBQty.Size = new System.Drawing.Size(154, 25);
            this.txtBQty.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(306, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 70);
            this.label5.TabIndex = 21;
            this.label5.Text = "REQUIRED BLOOD QTY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAvail
            // 
            this.btnAvail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAvail.Location = new System.Drawing.Point(333, 498);
            this.btnAvail.Name = "btnAvail";
            this.btnAvail.Size = new System.Drawing.Size(163, 38);
            this.btnAvail.TabIndex = 23;
            this.btnAvail.Text = "CHECK AVAILABILITY";
            this.btnAvail.UseVisualStyleBackColor = true;
            this.btnAvail.Click += new System.EventHandler(this.btnAvail_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(740, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "units";
            // 
            // btnDONORFind
            // 
            this.btnDONORFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDONORFind.Location = new System.Drawing.Point(562, 498);
            this.btnDONORFind.Name = "btnDONORFind";
            this.btnDONORFind.Size = new System.Drawing.Size(170, 38);
            this.btnDONORFind.TabIndex = 26;
            this.btnDONORFind.Text = "FIND DONOR";
            this.btnDONORFind.UseVisualStyleBackColor = true;
            this.btnDONORFind.Click += new System.EventHandler(this.btnDONORFind_Click);
            // 
            // comboBox112
            // 
            this.comboBox112.FormattingEnabled = true;
            this.comboBox112.Location = new System.Drawing.Point(578, 301);
            this.comboBox112.Name = "comboBox112";
            this.comboBox112.Size = new System.Drawing.Size(121, 24);
            this.comboBox112.TabIndex = 27;
            // 
            // txtrecvtest
            // 
            this.txtrecvtest.Location = new System.Drawing.Point(578, 190);
            this.txtrecvtest.Multiline = true;
            this.txtrecvtest.Name = "txtrecvtest";
            this.txtrecvtest.Size = new System.Drawing.Size(154, 27);
            this.txtrecvtest.TabIndex = 29;
            this.txtrecvtest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtrecvtest_KeyDown);
            // 
            // frmBB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1145, 740);
            this.Controls.Add(this.txtrecvtest);
            this.Controls.Add(this.comboBox112);
            this.Controls.Add(this.btnDONORFind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAvail);
            this.Controls.Add(this.txtBQty);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTransac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmBB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.frmBB_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTransac;
        private System.Windows.Forms.TextBox txtBQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAvail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDONORFind;
        private System.Windows.Forms.ComboBox comboBox112;
        private System.Windows.Forms.TextBox txtrecvtest;
    }
}