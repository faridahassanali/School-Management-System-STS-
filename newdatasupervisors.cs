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
    public partial class newdatasupervisors : Form
    {
        string connstring = ConfigurationManager.ConnectionStrings["condb"].ConnectionString;
        public newdatasupervisors()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            newdata frm5 = new newdata();
            frm5.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newdatadrivers_Enter(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtName2.Text = "";
            txtAddress2.Text = "";
            txtAge2.Text = "";
            txtID2.Text = "";
            pictureIDfront2.Image = null;
            pictureIDback2.Image = null;
            txtExperience2.Text = "";
        }

        private void btnInsertPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open Image";
            fdlg.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                pictureIDfront2.Image = Image.FromFile(fdlg.FileName);

            }
            OpenFileDialog fdlgg = new OpenFileDialog();
            fdlgg.Title = "Open Image";
            fdlgg.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (fdlgg.ShowDialog() == DialogResult.OK)
            {
                pictureIDback2.Image = Image.FromFile(fdlgg.FileName);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Image img = pictureIDfront2.Image;
            ImageConverter Converter2 = new ImageConverter();
            var ImageConvert2 = Converter2.ConvertTo(img, typeof(byte[]));

            Image imgg = pictureIDback2.Image;
            ImageConverter Converter3 = new ImageConverter();
            var ImageConvert3 = Converter3.ConvertTo(imgg, typeof(byte[]));

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
                string sqll = "INSERT INTO Supervisors ([Name], [Address], [Age], [ID], [Copy of ID card (front)], [Copy of ID card (back)], [Previous experience necessary]) " +
                             "VALUES (@Name, @Address, @Age, @ID, @IDFront, @IDBack, @Experience)";
                using (SqlCommand cmdd = new SqlCommand(sqll, conn))
                {
                    cmdd.Parameters.AddWithValue("@Name", txtName2.Text);
                    cmdd.Parameters.AddWithValue("@Address", txtAddress2.Text);
                    cmdd.Parameters.AddWithValue("@Age", txtAge2.Text);
                    cmdd.Parameters.AddWithValue("@ID", txtID2.Text);
                    cmdd.Parameters.AddWithValue("@IDFront", ImageConvert2);
                    cmdd.Parameters.AddWithValue("@IDBack", ImageConvert3);
                    cmdd.Parameters.AddWithValue("@Experience", txtExperience2.Text);

                    cmdd.ExecuteNonQuery();
                    MessageBox.Show("Record Added Successfully");
                }
            }
        }

        private void newdatasupervisors_Load(object sender, EventArgs e)
        {

        }
    }
}
