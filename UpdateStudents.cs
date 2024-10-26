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
    public partial class UpdateStudents : Form
    {
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        public UpdateStudents()
        {
            InitializeComponent();
            Programcb.Items.Add("Bachelor of Science in Computer Engineering");
            Programcb.Items.Add("Bachelor of Science in Tourism Management");
            Programcb.Items.Add("Bachelor of Science in Computer Science");
            Programcb.Items.Add("Bachelor of Science in Business Administration");
            Programcb.Items.Add("Bachelor of Science in Criminology");
            Programcb.Items.Add("Bachelor of Science in Nursing");

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            string connect = @"Data Source=NIGGA\SQLEXPRESS;Initial Catalog=LoginAccounts;Integrated Security=True";
            StringBuilder query = new StringBuilder("UPDATE Students_Table SET First_Name = @FirstName, Middle_Name = @MiddleName, Last_Name = @LastName,");
            query.Append("Birth_Date = @BirthDate, Gender = @Gender, Contact_Number = @ContactNumber, Student_Address = @Address, Program = @Program");

            if (pictureBox1.Image != null) 
            {
                query.Append(", Photos = @Images ");
            }

            query.Append(" WHERE ID = @StudentID");

            using (SqlConnection con = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand(query.ToString(), con);

                cmd.Parameters.AddWithValue("@StudentID", Stu_txt.Text);
                cmd.Parameters.AddWithValue("@FirstName", Fnametxt.Text);
                cmd.Parameters.AddWithValue("@MiddleName", Mnametxt.Text);
                cmd.Parameters.AddWithValue("@LastName", Lnametxt.Text);
                cmd.Parameters.AddWithValue("@BirthDate", Birthpicker.Value);

                string gender = rbMale.Checked ? "Male" : "Female";
                cmd.Parameters.AddWithValue("@Gender", gender);

                cmd.Parameters.AddWithValue("@ContactNumber", Contacttxt.Text);
                cmd.Parameters.AddWithValue("@Address", Addresstxt.Text);
                cmd.Parameters.AddWithValue("@Program", Programcb.Text);

                if (pictureBox1.Image != null) 
                {
                    byte[] imageBytes = ImageToByteArray(pictureBox1.Image);
                    cmd.Parameters.AddWithValue("@Images", imageBytes);
                }

                try
                {
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student information updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Update failed. No student found with the provided ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            
            string connections = @"Data Source=NIGGA\SQLEXPRESS;Initial Catalog=LoginAccounts;Integrated Security=True";
            string query2 = "UPDATE LoginAccount SET UserName = @UserName, Passwords = @Password, Account_Type = @AccountType WHERE ID = @StudentID";
            using (SqlConnection connect2 = new SqlConnection(connections))
            {
                SqlCommand cmd1 = new SqlCommand(query2, connect2);
                cmd1.Parameters.AddWithValue("@StudentID", Stu_txt.Text);
                cmd1.Parameters.AddWithValue("@UserName", Stu_User.Text);
                cmd1.Parameters.AddWithValue("@Password", Stu_Pass.Text);
                cmd1.Parameters.AddWithValue("@AccountType", Account_Type.Text);

                try
                {
                    connect2.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Login account updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while updating the login account: " + ex.Message);
                }
            }
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NIGGA\SQLEXPRESS;Initial Catalog=LoginAccounts;Integrated Security=True";
            string query = "SELECT * FROM Students_Table WHERE ID = @ID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", Search_txt.Text);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {

                        Stu_txt.Text = reader["ID"].ToString();
                        Fnametxt.Text = reader["First_Name"].ToString();
                        Mnametxt.Text = reader["Middle_Name"].ToString();
                        Lnametxt.Text = reader["Last_Name"].ToString();
                        Birthpicker.Value = Convert.ToDateTime(reader["Birth_Date"]);


                        if (reader["Gender"].ToString() == "Male")
                            rbMale.Checked = true;
                        else
                            rbFemale.Checked = true;

                        Contacttxt.Text = reader["Contact_Number"].ToString();
                        Addresstxt.Text = reader["Student_Address"].ToString();
                        Programcb.Text = reader["Program"].ToString();



                        if (reader["Photos"] != DBNull.Value)
                        {
                            byte[] imageData = (byte[])reader["Photos"];
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No student found with this ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            Stu_txt.Clear();
            Fnametxt.Clear();
            Mnametxt.Clear();
            Lnametxt.Clear();
            Contacttxt.Clear();
            Addresstxt.Clear();
            Stu_User.Clear();
            Stu_Pass.Clear();
            Account_Type.Clear();



        }

        private void Uploadbtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);


                byte[] imageBytes = ImageToByteArray(pictureBox1.Image);
            }
        }
    }
}
