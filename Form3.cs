using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BLOODDONATION
{
    public partial class frmDonor : Form
    {
        public frmDonor()
        {
            InitializeComponent();
            Button b2 = new Button();
        }
        string constring = @"Server=localhost;Port=3307;Database=trueblood;Uid=root;Pwd=pranavsv123";
        MySqlConnection conn;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDID.Text == "" || txtDName.Text == "" || txtAge.Text == ""|| cmbBloodGrp.Text == "" || cmbGender.Text == "" || dtpRegDate.Text == ""  || txtPhno.Text=="")
            {
                MessageBox.Show("no field should be blank");
            }
            /*
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("password cannot be blank");
            }
            else if (txtpassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("passwords dont match");
            }*/
            else
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into Donor values ('" + txtDID.Text + "','" + txtDName.Text+ "','" + cmbGender.Text + "','" + txtAge.Text + "','" + dtpRegDate.Value.ToString("yyyy/MM/dd HH:mm:ss") + "','" + cmbBloodGrp.Text + "','" + txtPhno.Text + "');", conn);

                try {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("new donor added");
                    this.Hide();
                    frmTransaction f44 = new frmTransaction();
                    f44.ShowDialog();
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Donor id is already existed.Enter new donor id");                }

               
            }
        }

        private void frmDonor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtDID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
