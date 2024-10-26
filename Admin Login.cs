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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StudentManagementSample
{
    public partial class AdminFrm : Form
    {
        public AdminFrm()
        {
            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=NIGGA\SQLEXPRESS;Initial Catalog=LoginAccounts;Integrated Security=True");
        private void StudenLoginbtn_Click(object sender, EventArgs e)
        {
            
            string user, password;

            user = Adminuser.Text;
            password = AdminPass.Text;

            try
            {
                String querry = "SELECT * FROM AdminAccount WHERE UserName= '" + Adminuser.Text + "' AND Passwords = '" + AdminPass.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, con);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    user = Adminuser.Text;
                    password = AdminPass.Text;

                    AdminFrame adframe =  new AdminFrame();
                    adframe.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Adminuser.Clear();
                    AdminPass.Clear();
                }


            }
            catch
            {
                MessageBox.Show("Invalid.");
            }
            finally
            {
                con.Close();
            }
        }

        private void StudentClearbtn_Click(object sender, EventArgs e)
        {
            AdminPass.Clear();
            Adminuser.Clear();
        }
    }
}
