using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSample
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void Studentbtn_Click(object sender, EventArgs e)
        {
            
            StuLogin stu = new StuLogin();
            stu.Show();

            this.Hide();


         
           
        }

        private void Teacherbtn_Click(object sender, EventArgs e)
        {
            TeacherLogin Teach = new TeacherLogin();
            Teach.Show();

            this.Hide();

            
        }

        private void Adminbtn_Click(object sender, EventArgs e)
        {
            AdminFrm admin = new AdminFrm();
            admin.Show();

            this.Hide();    
        }
        
    }
}
