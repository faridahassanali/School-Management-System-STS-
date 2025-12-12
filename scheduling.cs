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
    public partial class scheduling : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public scheduling()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBusNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtLicence_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItinerary_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            previousdata frm17 = new previousdata();
            frm17.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBusNumber2.Text = "";
            txtAssgDriver2.Text = "";
            txtAssgSupervisor2.Text = "";
            txtTurns.Text = "";
            txtItinerary.Text = "";
            txtName1turn.Text = "";
            txtName2turn.Text = "";
            txtArrival1.Text = "";
            txtDeparture1.Text = "";
            txtArrival2.Text="";
            txtDeparture2.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection coonnn = new SqlConnection(connstring))
            {
                coonnn.Open();
                string ssqlll = "INSERT INTO Scheduled ([Bus number], [Assigned driver], [Assigned supervisor], [Number of turns], [Itinerary], [Name of students in first turn and Addresses], [Name of students in second turn and Addresses],[Arrival time to school for first turn],[Arrival time to school for second turn],[Departure time from school for first turn],[Departure time from school for second turn]) " +
                             "VALUES (@BusNumber2, @AssgDriver2, @AssgSupervisor2, @Turns, @Itinerary, @Name1turn, @Name2turn, @Arrival1,@Departure1,@Arrival2,@Departure2)";
                using (SqlCommand cmmddd = new SqlCommand(ssqlll, coonnn))
                {
                    cmmddd.Parameters.AddWithValue("@BusNumber2", txtBusNumber2.Text);
                    cmmddd.Parameters.AddWithValue("@AssgDriver2", txtAssgDriver2.Text);
                    cmmddd.Parameters.AddWithValue("@AssgSupervisor2", txtAssgSupervisor2.Text);
                    cmmddd.Parameters.AddWithValue("@Turns", txtTurns.Text);
                    cmmddd.Parameters.AddWithValue("@Itinerary", txtItinerary.Text);
                    cmmddd.Parameters.AddWithValue("@Name1turn", txtName1turn.Text);
                    cmmddd.Parameters.AddWithValue("@Name2turn", txtName2turn.Text);
                    cmmddd.Parameters.AddWithValue("@Arrival1", txtArrival1.Text);
                    cmmddd.Parameters.AddWithValue("@Departure1", txtDeparture1.Text);
                    cmmddd.Parameters.AddWithValue("@Arrival2", txtArrival2.Text);
                    cmmddd.Parameters.AddWithValue("@Departure2", txtDeparture2.Text);

                    cmmddd.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully");
                }
            }
        }

        private void txtArrival2_TextChanged(object sender, EventArgs e)
        {

        }

        private void scheduling_Load(object sender, EventArgs e)
        {

        }
    }
}
