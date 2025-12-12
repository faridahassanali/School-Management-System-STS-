using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace STS
{
    public partial class previousdatasupervisors : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public previousdatasupervisors()
        {
            InitializeComponent();
        }

        private void previousdatasupervisors_Load(object sender, EventArgs e)
        {
            bind_data2();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousdata frm13=new previousdata();
            frm13.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void bind_data2()
        {
            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                SqlDataAdapter sqlDaa = new SqlDataAdapter("SELECT * FROM Supervisors", conn);
                DataTable dtt = new DataTable();
                sqlDaa.Fill(dtt);
                dataGridView2.DataSource = dtt;
            }
        }
    }
}
