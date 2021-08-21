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
    public partial class FindDonor : Form
    {
        public FindDonor()
        {
            InitializeComponent();
        }
        string constring = @"Server=localhost;Port=3307;Database=trueblood;Uid=root;Pwd=pranavsv123";
        MySqlConnection conn;
        private void FindDonor_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(constring);
            conn.Open();

            string bg1 = "";
            switch (frmBB.bg)
            {
                case "AP": bg1 = "A+"; break;
                case "AN": bg1 = "A-"; break;
                case "BP": bg1 = "B+"; break;
                case "BN": bg1 = "B-"; break;
                case "ABP": bg1 = "AB+"; break;
                case "ABN": bg1= "AB-"; break;
                case "OP": bg1 = "O+"; break;
                case "ONeg": bg1 = "O-"; break;
            }
            MySqlDataAdapter sqlda = new MySqlDataAdapter("select * from donor where bloodgrp='" + bg1 + "';", conn);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);

            dgvFindDonor.DataSource = dt;

        }
    }
}
