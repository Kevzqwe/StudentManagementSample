using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSample
{
    public partial class ProfRegistrationFrm : Form
    {
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }
        public ProfRegistrationFrm()
        {
            InitializeComponent();
        }
        String connection = @"Data Source=NIGGA\SQLEXPRESS;Initial Catalog=LoginAccounts;Integrated Security=True";
        private void Prof_btn_Click(object sender, EventArgs e)
        {
            string firstName = ProfFname.Text;
            string middleName = ProfMname.Text;
            string lastName = ProfLname.Text;
            DateTime birthDate = ProfBirthpicker.Value;
            string contactNumber = ProfContact.Text;
            string address = ProfAdd.Text;
            string ProfUser = Prof_User.Text;
            string ProfPass = Prof_Pass.Text;
            string StudentAccountType = Account_Type.Text;
            byte[] images = ImageToByteArray(pictureBox1.Image);


            string gender;

            if (PMaleBtn.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Professor_Table (First_Name, Middle_Name, Last_Name, Birth_Date, Gender, Contact_Number, Professor_Address,Photos) " +
                                   "VALUES (@FirstName, @MiddleName, @LastName, @BirthDate, @Gender, @ContactNumber, @Address, @images)";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@MiddleName", middleName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@images", images);



                        cmd.ExecuteNonQuery();

                    }
                    string query1 = "INSERT INTO LoginAccount (UserName, Passwords, Account_Type) " + "VALUES (@ProfUser, @ProfPass, @Accounttype)";
                    using (SqlCommand cmd1 = new SqlCommand(query1, conn))
                    {
                        cmd1.Parameters.AddWithValue("@ProfUser", ProfUser);
                        cmd1.Parameters.AddWithValue("@ProfPass", ProfPass);
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
    }
}
