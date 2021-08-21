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
    public partial class frmSignUp   : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
            Button b3 = new Button();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("username cannot be blank");
            }
            else if (txtpassword.Text == "")
            {
                MessageBox.Show("password cannot be blank");
            }
            else if (txtpassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("passwords dont match");
            }
            else
            {
                MySqlCommand cmd = new MySqlCommand("insert into login values ('" + txtUsername.Text + "','" + txtpassword.Text + "');", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("new user added");

                this.Hide();
                frmLogin f1 = new frmLogin();
                f1.ShowDialog();
                this.Close();
            }


        }
        string constring = @"Server=localhost;Port=3307;Database=trueblood;Uid=root;Pwd=pranavsv123";
        MySqlConnection conn;
        private void frmSignUp_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(constring);
            conn.Open();
            //MessageBox.Show("Connected");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
