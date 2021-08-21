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
    public partial class frmReceiever : Form
    {
        public frmReceiever()
        {
            InitializeComponent();
            Button dynamicButton = new Button();
        }
        string constring = @"Server=localhost;Port=3307;Database=trueblood;Uid=root;Pwd=pranavsv123";
        MySqlConnection conn;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRid.Text == "" || txtRname.Text == "" || txtRage.Text == "" || cmbRbg.Text == "" || cmbRgender.Text == "" || dtpRdate.Text == "")
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
                
                //stored procedures
                  
                conn = new MySqlConnection(constring);
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("addrecv", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("_id", txtRid.Text);
                cmd.Parameters.AddWithValue("_rname", txtRname.Text);
                cmd.Parameters.AddWithValue("_age", txtRage.Text);
                cmd.Parameters.AddWithValue("_gender", cmbRgender.Text);
                cmd.Parameters.AddWithValue("_regdate", dtpRdate.Value.ToString("yyyy/MM/dd HH:mm:ss"));
                cmd.Parameters.AddWithValue("_bg", cmbRbg.Text);

                cmd.ExecuteNonQuery();

               
                MessageBox.Show("new receiver added");


                this.Hide();
                frmBB f6 = new frmBB();
                f6.ShowDialog();
                this.Close();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmReceiever_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void txtRname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
