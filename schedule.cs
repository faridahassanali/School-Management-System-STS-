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
    public partial class schedule : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public schedule()
        {
            InitializeComponent();
        }

        private void schedule_Load(object sender, EventArgs e)
        {
            bind_data4();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            welcomeform frm19 = new welcomeform();
            frm19.Show();
        }
        private void bind_data4()
        {
            using (SqlConnection coonnn = new SqlConnection(connstring))
            {
                coonnn.Open();
                SqlDataAdapter ssqlDaaa = new SqlDataAdapter("SELECT * FROM Scheduled", coonnn);
                DataTable ddttt = new DataTable();
                ssqlDaaa.Fill(ddttt);
                dataGridView4.DataSource = ddttt;
            }
        }
    }
}
