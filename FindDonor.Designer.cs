namespace BLOODDONATION
{
    partial class FindDonor
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
            this.dgvFindDonor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindDonor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFindDonor
            // 
            this.dgvFindDonor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindDonor.Location = new System.Drawing.Point(36, 60);
            this.dgvFindDonor.Name = "dgvFindDonor";
            this.dgvFindDonor.RowTemplate.Height = 24;
            this.dgvFindDonor.Size = new System.Drawing.Size(1084, 569);
            this.dgvFindDonor.TabIndex = 0;
            // 
            // FindDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 668);
            this.Controls.Add(this.dgvFindDonor);
            this.Name = "FindDonor";
            this.Text = "FindDonor";
            this.Load += new System.EventHandler(this.FindDonor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindDonor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFindDonor;
    }
}