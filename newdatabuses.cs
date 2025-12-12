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
using System.Xml.Linq;

namespace STS
{
    public partial class newdatabuses : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public newdatabuses()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            newdata frm7 = new newdata();
            frm7.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExperience2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtBusNumber.Text = "";
            txtModel.Text = "";
            txtLicence.Text = "";
            txtCapacity.Text = "";
            txtAssgSupervisor.Text = "";
            txtAssgDriver.Text = "";
            txtMaintenance.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(txtAssgDriver.Text) || string.IsNullOrWhiteSpace(txtAssgSupervisor.Text))
            {
                MessageBox.Show("Please enter both driver and supervisor names");
                return;
            }

            using (SqlConnection connn = new SqlConnection(connstring))
            {
                try
                {
                    connn.Open();

                    // First verify driver exists
                    string checkDriverSql = "SELECT 1 FROM Drivers WHERE Name = @Driver";
                    using (SqlCommand checkDriverCmd = new SqlCommand(checkDriverSql, connn))
                    {
                        checkDriverCmd.Parameters.AddWithValue("@Driver", txtAssgDriver.Text.Trim());
                        if (checkDriverCmd.ExecuteScalar() == null)
                        {
                            MessageBox.Show("The specified driver does not exist in the database");
                            return;
                        }
                    }

                    // Verify supervisor exists
                    string checkSupervisorSql = "SELECT 1 FROM Supervisors WHERE Name = @Supervisor";
                    using (SqlCommand checkSupervisorCmd = new SqlCommand(checkSupervisorSql, connn))
                    {
                        checkSupervisorCmd.Parameters.AddWithValue("@Supervisor", txtAssgSupervisor.Text.Trim());
                        if (checkSupervisorCmd.ExecuteScalar() == null)
                        {
                            MessageBox.Show("The specified supervisor does not exist in the database");
                            return;
                        }
                    }

                    // Proceed with insert
                    string insertSql = @"INSERT INTO Buses (
                                [Bus number], 
                                [Model], 
                                [Licence plate number], 
                                [Capacity], 
                                [Maintenance history], 
                                [Assigned driver], 
                                [Assigned supervisor]
                              ) VALUES (
                                @BusNumber, 
                                @Model, 
                                @Licence, 
                                @Capacity, 
                                @Maintenance, 
                                @AssgDriver, 
                                @AssgSupervisor
                              )";

                    using (SqlCommand cmddd = new SqlCommand(insertSql, connn))
                    {
                        cmddd.Parameters.AddWithValue("@BusNumber", txtBusNumber.Text);
                        cmddd.Parameters.AddWithValue("@Model", txtModel.Text);
                        cmddd.Parameters.AddWithValue("@Licence", txtLicence.Text);
                        cmddd.Parameters.AddWithValue("@Capacity", txtCapacity.Text);
                        cmddd.Parameters.AddWithValue("@Maintenance", txtMaintenance.Text);
                        cmddd.Parameters.AddWithValue("@AssgDriver", txtAssgDriver.Text.Trim());
                        cmddd.Parameters.AddWithValue("@AssgSupervisor", txtAssgSupervisor.Text.Trim());

                        int rowsAffected = cmddd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bus record added successfully!");
                            btnNew.PerformClick(); // Clear form
                        }
                        else
                        {
                            MessageBox.Show("No records were added");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Foreign key violation
                    {
                        MessageBox.Show("Database constraint violation. Please verify:\n" +
                                      "1. Driver exists in Drivers table\n" +
                                      "2. Supervisor exists in Supervisors table\n" +
                                      "3. Names match exactly (including case and spaces)");
                    }
                    else
                    {
                        MessageBox.Show($"Database error: {ex.Message}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void newdatabus_Enter(object sender, EventArgs e)
        {

        }

        private void newdatabuses_Load(object sender, EventArgs e)
        {

        }
    }
}
