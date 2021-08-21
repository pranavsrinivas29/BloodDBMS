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
    public partial class frmTransaction : Form
    {
        public frmTransaction()
        {
            InitializeComponent();
        }
        string constring = @"Server=localhost;Port=3307;Database=trueblood;Uid=root;Pwd=pranavsv123";
        MySqlConnection conn;
        private void btnTransacSubmit_Click(object sender, EventArgs e)
        {



            if (txtdid111.Text == "" || txtHosid.Text == "" || txtHosName.Text == "" || txtLoc.Text == "")
            {
                MessageBox.Show("no field should be blank");
            }
 
            else {
                //conn.Close();
                conn = new MySqlConnection(constring);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into transaction values ('" + txtdid111.Text + "','" + txtHosid.Text + "','" + txtHosName.Text + "','" + txtLoc.Text + "');", conn);
                cmd.ExecuteNonQuery();

                MySqlDataAdapter sqlda = new MySqlDataAdapter("select bloodgrp from donor where did='" + txtdid111.Text + "';", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);

                string bg = dt.Rows[0]["bloodgrp"].ToString();

                switch (bg)
                {
                    case "A+": bg = "AP"; break;
                    case "A-": bg = "AN"; break;
                    case "B+": bg = "BP"; break;
                    case "B-": bg = "BN"; break;
                    case "AB+": bg = "ABP"; break;
                    case "AB-": bg = "ABN"; break;
                    case "O+": bg = "OP"; break;
                    case "O-": bg = "ONeg"; break;
                }

                MySqlDataAdapter sqlda1 = new MySqlDataAdapter("select * from stock;", conn);
                DataTable dt1 = new DataTable();
                sqlda1.Fill(dt1);

                int bgvalue = Convert.ToInt32(dt1.Rows[0][bg].ToString());
                bgvalue++;

                MySqlCommand cmd1 = new MySqlCommand("update stock set " + bg + "='" + bgvalue + "';", conn);

                cmd1.ExecuteNonQuery();

                MySqlDataAdapter sqlda2 = new MySqlDataAdapter("select * from timesdonated where did='" + txtdid111.Text+"';", conn);
                DataTable dt2 = new DataTable();
                sqlda2.Fill(dt2);

                int bgvalue2 = Convert.ToInt32(dt2.Rows[0][1].ToString());
                bgvalue2 += 1;

                MySqlCommand cmd2 = new MySqlCommand("update timesdonated set times='" + bgvalue2 + "' where did='"+ txtdid111.Text+"';", conn);
                cmd2.ExecuteNonQuery();

                MessageBox.Show("blood transaction made");

            }
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            this.Close();
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {

        }

        private void txtDonorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonorId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from donor where did='" + txtdid111.Text + "';", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                txtdname123.Text = dt.Rows[0]["dname"].ToString();
                txtbg124.Text = dt.Rows[0]["bloodgrp"].ToString();
                txtdid111.Text = dt.Rows[0]["did"].ToString();            }
        }

        private void txtDonorID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtdid111_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdid111_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from donor where did='" + txtdid111.Text + "';", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                txtdname123.Text = dt.Rows[0]["dname"].ToString();
                txtbg124.Text = dt.Rows[0]["bloodgrp"].ToString();
                txtdid111.Text = dt.Rows[0]["did"].ToString();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
