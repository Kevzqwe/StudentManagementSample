using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSample
{
    public partial class AdminFrame : Form
    {
        public AdminFrame()
        {
            InitializeComponent();
        }

        public void loadForm(object Form)
        {
            if (this.Mainpanel.Controls.Count > 0)
                this.Mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Mainpanel.Controls.Add(f);
            this.Mainpanel.Tag = f;
            f.Show();

        }

        private void aDDSTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new AddingStudent());
        }

        private void sTUDENTLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new Stu_ListFrm());
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            if (this.Mainpanel.Controls.Count > 0)
            {
                this.Mainpanel.Controls.RemoveAt(0);
            }
        }

        private void eDITREMOVESTUDENTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new UpdateStudents());
        }

        private void aDDTEACHERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm(new ProfRegistrationFrm());
        }
    }
}
