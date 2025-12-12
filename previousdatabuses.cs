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
    public partial class previousdatabuses : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public previousdatabuses()
        {
            InitializeComponent();
        }

        private void previousdatabuses_Load(object sender, EventArgs e)
        {
            bind_data3();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousdata frm15=new previousdata();
            frm15.Show();
        }
        private void bind_data3()
        {
            using (SqlConnection connn = new SqlConnection(connstring))
            {
                connn.Open();
                SqlDataAdapter sqlDaaa = new SqlDataAdapter("SELECT * FROM Buses", connn);
                DataTable dttt = new DataTable();
                sqlDaaa.Fill(dttt);
                dataGridView3.DataSource = dttt;
            }
        }
    }
}
