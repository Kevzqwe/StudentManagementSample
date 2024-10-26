namespace StudentManagementSample
{
    partial class AdminFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDSTUDENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTATICSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITREMOVESTUDENTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEACHERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDDTEACHERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIEWTEACHERLISTSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACULTYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOURSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROGRAMLISTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.Backbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.loginAccountsDataSet1 = new StudentManagementSample.LoginAccountsDataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginAccountsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sTUDENTToolStripMenuItem,
            this.tEACHERSToolStripMenuItem,
            this.cOURSEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1028, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sTUDENTToolStripMenuItem
            // 
            this.sTUDENTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDSTUDENTToolStripMenuItem,
            this.sTUDENTLISTToolStripMenuItem,
            this.sTATICSToolStripMenuItem,
            this.eDITREMOVESTUDENTSToolStripMenuItem});
            this.sTUDENTToolStripMenuItem.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTUDENTToolStripMenuItem.Name = "sTUDENTToolStripMenuItem";
            this.sTUDENTToolStripMenuItem.Size = new System.Drawing.Size(94, 27);
            this.sTUDENTToolStripMenuItem.Text = "STUDENT";
            // 
            // aDDSTUDENTToolStripMenuItem
            // 
            this.aDDSTUDENTToolStripMenuItem.Name = "aDDSTUDENTToolStripMenuItem";
            this.aDDSTUDENTToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.aDDSTUDENTToolStripMenuItem.Text = "ADD STUDENT";
            this.aDDSTUDENTToolStripMenuItem.Click += new System.EventHandler(this.aDDSTUDENTToolStripMenuItem_Click);
            // 
            // sTUDENTLISTToolStripMenuItem
            // 
            this.sTUDENTLISTToolStripMenuItem.Name = "sTUDENTLISTToolStripMenuItem";
            this.sTUDENTLISTToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.sTUDENTLISTToolStripMenuItem.Text = "STUDENT LIST";
            this.sTUDENTLISTToolStripMenuItem.Click += new System.EventHandler(this.sTUDENTLISTToolStripMenuItem_Click);
            // 
            // sTATICSToolStripMenuItem
            // 
            this.sTATICSToolStripMenuItem.Name = "sTATICSToolStripMenuItem";
            this.sTATICSToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.sTATICSToolStripMenuItem.Text = "VIEW STUDENT RECORDS";
            // 
            // eDITREMOVESTUDENTSToolStripMenuItem
            // 
            this.eDITREMOVESTUDENTSToolStripMenuItem.Name = "eDITREMOVESTUDENTSToolStripMenuItem";
            this.eDITREMOVESTUDENTSToolStripMenuItem.Size = new System.Drawing.Size(274, 28);
            this.eDITREMOVESTUDENTSToolStripMenuItem.Text = "EDIT/REMOVE STUDENTS";
            this.eDITREMOVESTUDENTSToolStripMenuItem.Click += new System.EventHandler(this.eDITREMOVESTUDENTSToolStripMenuItem_Click);
            // 
            // tEACHERSToolStripMenuItem
            // 
            this.tEACHERSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDDTEACHERSToolStripMenuItem,
            this.vIEWTEACHERLISTSToolStripMenuItem,
            this.fACULTYToolStripMenuItem});
            this.tEACHERSToolStripMenuItem.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEACHERSToolStripMenuItem.Name = "tEACHERSToolStripMenuItem";
            this.tEACHERSToolStripMenuItem.Size = new System.Drawing.Size(102, 27);
            this.tEACHERSToolStripMenuItem.Text = "TEACHERS";
            // 
            // aDDTEACHERSToolStripMenuItem
            // 
            this.aDDTEACHERSToolStripMenuItem.Name = "aDDTEACHERSToolStripMenuItem";
            this.aDDTEACHERSToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.aDDTEACHERSToolStripMenuItem.Text = "ADD TEACHERS";
            this.aDDTEACHERSToolStripMenuItem.Click += new System.EventHandler(this.aDDTEACHERSToolStripMenuItem_Click);
            // 
            // vIEWTEACHERLISTSToolStripMenuItem
            // 
            this.vIEWTEACHERLISTSToolStripMenuItem.Name = "vIEWTEACHERLISTSToolStripMenuItem";
            this.vIEWTEACHERLISTSToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.vIEWTEACHERLISTSToolStripMenuItem.Text = "VIEW TEACHER LISTS";
            // 
            // fACULTYToolStripMenuItem
            // 
            this.fACULTYToolStripMenuItem.Name = "fACULTYToolStripMenuItem";
            this.fACULTYToolStripMenuItem.Size = new System.Drawing.Size(243, 28);
            this.fACULTYToolStripMenuItem.Text = "FACULTY";
            // 
            // cOURSEToolStripMenuItem
            // 
            this.cOURSEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pROGRAMLISTToolStripMenuItem});
            this.cOURSEToolStripMenuItem.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cOURSEToolStripMenuItem.Name = "cOURSEToolStripMenuItem";
            this.cOURSEToolStripMenuItem.Size = new System.Drawing.Size(97, 27);
            this.cOURSEToolStripMenuItem.Text = "PROGRAM";
            // 
            // pROGRAMLISTToolStripMenuItem
            // 
            this.pROGRAMLISTToolStripMenuItem.Name = "pROGRAMLISTToolStripMenuItem";
            this.pROGRAMLISTToolStripMenuItem.Size = new System.Drawing.Size(193, 28);
            this.pROGRAMLISTToolStripMenuItem.Text = "PROGRAM LIST";
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Mainpanel.Location = new System.Drawing.Point(12, 43);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(1004, 658);
            this.Mainpanel.TabIndex = 1;
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(904, 707);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(120, 37);
            this.Backbtn.TabIndex = 2;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(918, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // loginAccountsDataSet1
            // 
            this.loginAccountsDataSet1.DataSetName = "LoginAccountsDataSet";
            this.loginAccountsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdminFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1028, 748);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Mainpanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminFrame";
            this.Text = "AdminFrame";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginAccountsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDSTUDENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTLISTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTATICSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITREMOVESTUDENTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEACHERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOURSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDDTEACHERSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIEWTEACHERLISTSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACULTYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROGRAMLISTToolStripMenuItem;
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button button1;
        private LoginAccountsDataSet loginAccountsDataSet1;
    }
}