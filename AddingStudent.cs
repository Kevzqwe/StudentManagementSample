using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSample
{
    public partial class AddingStudent : Form
    {
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        public AddingStudent()
        {
            InitializeComponent();
            Programcb.Items.Add("Bachelor of Science in Information Technology");
            Programcb.Items.Add("Bachelor of Science in Computer Engineering");
            Programcb.Items.Add("Bachelor of Science in Tourism Management");
            Programcb.Items.Add("Bachelor of Science in Computer Science");
            Programcb.Items.Add("Bachelor of Science in Business Administration");
            Programcb.Items.Add("Bachelor of Science in Criminology");
            Programcb.Items.Add("Bachelor of Science in Nursing");
        }
        String connect = @"Data Source=NIGGA\SQLEXPRESS;Initial Catalog=LoginAccounts;Integrated Security=True";
        private void AddingStudent_Load(object sender, EventArgs e)
        {

        }

        private void e2btn_Click(object sender, EventArgs e)
        {
            string firstName = Fnametxt.Text;
            string middleName = Mnametxt.Text;
            string lastName = Lnametxt.Text;
            DateTime birthDate = Birthpicker.Value;
            string contactNumber = Contacttxt.Text;
            string address = Addresstxt.Text;
            string Student_user = Stu_User.Text;
            string Student_pass = Stu_Pass.Text;
            string StudentAccountType = Account_Type.Text;
            string program = Programcb.Items[0].ToString();
            byte[] images = ImageToByteArray(pictureBox1.Image);


            string gender;

            if (MaleBtn.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }


            using (SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Students_Table (First_Name, Middle_Name, Last_Name, Birth_Date, Gender, Contact_Number, Student_Address, Program, Photos) " +
                                   "VALUES (@FirstName, @MiddleName, @LastName, @BirthDate, @Gender, @ContactNumber, @Address, @Program, @images)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@MiddleName", middleName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Program", program);
                        cmd.Parameters.AddWithValue("@images", images);



                        cmd.ExecuteNonQuery();

                    }
                    string query1 = "INSERT INTO LoginAccount (UserName, Passwords, Account_Type) " + "VALUES (@StudentUser, @StudentPass, @Accounttype)";
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.AddWithValue("@StudentUser", Student_user);
                        cmd1.Parameters.AddWithValue("@StudentPass", Student_pass);
                        cmd1.Parameters.AddWithValue("@Accounttype", StudentAccountType);

                        cmd1.ExecuteNonQuery();
                    }


                    MessageBox.Show("Student record saved successfully.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            AdminFrame adminF = new AdminFrame();
            adminF.Show();
            this.Hide();
        }

        private void Imagebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
