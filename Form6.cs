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
    public partial class frmBB : Form
    {
        public frmBB()
        {
            InitializeComponent();
        }
        string constring = @"Server=localhost;Port=3307;Database=trueblood;Uid=root;Pwd=pranavsv123";
        MySqlConnection conn;
        public static string bg = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmBB_Load(object sender, EventArgs e)
        {
            btnTransac.Enabled = false;
            conn = new MySqlConnection(constring);
            conn.Open();
        }

        private void btnAvail_Click(object sender, EventArgs e)
        {
            if (txtBQty.Text == "" || txtrecvtest.Text == "" || comboBox112.Text == "")
            {
                MessageBox.Show("no field should be blank");
            }
            else {
                switch (comboBox112.Text)
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

                if (Convert.ToInt16(txtBQty.Text) <= bgvalue)
                {
                    MessageBox.Show("Required qty of blood is available");
                    btnTransac.Enabled = true;
                }
                else
                {
                    MessageBox.Show("required blood qty is not available");
                }
            }
        }
        private void btnFIndDonor_Click(object sender, EventArgs e)
        {
            //btntransac
            MySqlDataAdapter sqlda1 = new MySqlDataAdapter("select * from stock;", conn);
            DataTable dt1 = new DataTable();
            sqlda1.Fill(dt1);

            int bgvalue = Convert.ToInt32(dt1.Rows[0][bg].ToString());

            bgvalue = bgvalue - Convert.ToInt16(txtBQty.Text);

            MySqlCommand cmd1 = new MySqlCommand("update stock set " + bg + "=" + bgvalue + ";", conn);

            cmd1.ExecuteNonQuery();

            MessageBox.Show("transaction sucessfull");
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.ShowDialog();
            this.Close();
        }

        private void btnDONORFind_Click(object sender, EventArgs e)
        {
            FindDonor f6 = new FindDonor();
            f6.ShowDialog();
        }

       /* private void txtSample_KEYDOWN(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from receiver where rid='" + txtRECID.Text + "';", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //txtdname123.Text = dt.Rows[0]["dname"].ToString();
                comboBox112.Text = dt.Rows[0]["bgroup"].ToString();
                txtRECID.Text = dt.Rows[0]["rid"].ToString();
            }
        }
        */
      //  private void txtrecId11_TextDown(object sender, EventArgs e)
        //{

        //}

       /* private void txtrecId11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from receiver where rid='" + txtRECID.Text + "';", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //txtdname123.Text = dt.Rows[0]["dname"].ToString();
                comboBox112.Text = dt.Rows[0]["bgroup"].ToString();
                txtRECID.Text = dt.Rows[0]["rid"].ToString();
            }
        }*/



      /*  private void txtRECID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from receiver where rid='" + txtrecvtest.Text + "';", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //txtdname123.Text = dt.Rows[0]["dname"].ToString();
                comboBox112.Text = dt.Rows[0]["bgroup"].ToString();
                txtBQty.Focus();
                //txtRECID.Text = dt.Rows[0]["rid"].ToString();
            }
        }*/

        private void txtrecvtest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conn = new MySqlConnection(constring);
                conn.Open();
                MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from receiver where rid='" + txtrecvtest.Text + "';", conn);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                //txtdname123.Text = dt.Rows[0]["dname"].ToString();
                comboBox112.Text = dt.Rows[0]["bgroup"].ToString();
                txtBQty.Focus();
                //txtRECID.Text = dt.Rows[0]["rid"].ToString();
            }
        }
    }
}
