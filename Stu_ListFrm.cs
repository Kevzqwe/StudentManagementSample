using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSample
{
    public partial class Stu_ListFrm : Form
    {
        String connected = @"Data Source=NIGGA\SQLEXPRESS;Initial Catalog=LoginAccounts;Integrated Security=True";
        public Stu_ListFrm()
        {
            InitializeComponent();
        }

        private void Refresh_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Students_Table";

            using (SqlConnection conn = new SqlConnection(connected))
            {
                try
                {
                    conn.Open();

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    
                    StudentList.DataSource = dataTable;

                    StudentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            StudentList.FirstDisplayedScrollingRowIndex = StudentList.RowCount - 1;
        }

        private void StudentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminFrame adminF = new AdminFrame();
            adminF.Show();
            this.Hide();
        }

        private void Stu_ListFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_DataSet.Students_Table' table. You can move, or remove it, as needed.
            this.students_TableTableAdapter1.Fill(this.student_DataSet.Students_Table);
            this.students_TableTableAdapter.Fill(this.loginAccountsDataSet.Students_Table);

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            string inputID = Search_txt.Text;

           
            if (int.TryParse(inputID, out int searchID))
            {
                
                string query = "SELECT * FROM Students_Table WHERE ID = @ID";

                using (SqlConnection conn = new SqlConnection(@"Data Source=NIGGA\SQLEXPRESS;Initial Catalog=LoginAccounts;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();

                       
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                          
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = searchID;

                            
                            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();

                            
                            dataAdapter.Fill(dataTable);

                         
                            StudentList.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
               
                MessageBox.Show("Please enter a valid integer ID.");
            }
        }
    }
}
