using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STS
{
    public partial class welcomeform : Form
    {
        public welcomeform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            newdata frm = new newdata();
            frm.Show();
            this.Hide();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPreviousData_Click(object sender, EventArgs e)
        {
            previousdata frm8= new previousdata();
            frm8.Show();
            this.Hide();
        }

        private void AddData_Click(object sender, EventArgs e)
        {
            schedule frm18= new schedule();
            frm18.Show();
            this.Hide();
        }

        private void btnOtherSystems_Click(object sender, EventArgs e)
        {
            schoolsystems frm20= new schoolsystems();
            frm20.Show();
            this.Hide();
        }

        private void btnAlerts_Click(object sender, EventArgs e)
        {
            alerts frm26= new alerts();
            frm26.Show();
            this.Hide();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            calendar frm32= new calendar();
            frm32.Show();
            this.Hide();
        }
    }
}
