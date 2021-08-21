using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BLOODDONATION
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string constring = @"Server=localhost;Port=3307;Database=trueblood;Uid=root;Pwd=pranavsv123";
        MySqlConnection conn;
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Add a link to the LinkLabel.
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "Form2";
            //linkLabel1.Links.Add();
            Button b1 = new Button();


        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmSignUp f2 = new frmSignUp();
            f2.ShowDialog();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(constring);
            conn.Open();
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select password from login where username='" + txtUser.Text + "';", conn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);

            if (dt.Rows[0]["password"].ToString() == txtPass.Text)
            {
                this.Hide();
                WelcomeForm4 f3 = new WelcomeForm4();
                f3.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("password doesnt matched");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
