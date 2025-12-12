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
    public partial class alerts : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public alerts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            welcomeform frm27 = new welcomeform();
            frm27.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            txtAlertid.Text = "";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            using (SqlConnection onnn = new SqlConnection(connstring))
            {
                onnn.Open();
                string queryyy = "INSERT INTO Alerts ([Type of alert], [Date], [Send to], [Alert ID]) " +
                             "VALUES (@comboBox1, @textBox1, @comboBox2, @txtAlertid)";
                using (SqlCommand mddd = new SqlCommand(queryyy, onnn))
                {
                    mddd.Parameters.AddWithValue("@comboBox1", comboBox1.Text);
                    mddd.Parameters.AddWithValue("@comboBox2", comboBox2.Text);
                    mddd.Parameters.AddWithValue("@textBox1", textBox1.Text);
                    mddd.Parameters.AddWithValue("@txtAlertid", txtAlertid.Text);


                    mddd.ExecuteNonQuery();
                    MessageBox.Show("Alert sent Successfully");
                }
            }
        }

        private void alerts_Load(object sender, EventArgs e)
        {

        }

        private void alertt_Enter(object sender, EventArgs e)
        {

        }
    }
}
