namespace StudentManagementSample
{
    partial class AdminFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Adminuser = new System.Windows.Forms.TextBox();
            this.AdminPass = new System.Windows.Forms.TextBox();
            this.StudenLoginbtn = new System.Windows.Forms.Button();
            this.StudentClearbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // Adminuser
            // 
            this.Adminuser.Location = new System.Drawing.Point(118, 124);
            this.Adminuser.Name = "Adminuser";
            this.Adminuser.Size = new System.Drawing.Size(191, 26);
            this.Adminuser.TabIndex = 3;
            // 
            // AdminPass
            // 
            this.AdminPass.Location = new System.Drawing.Point(118, 172);
            this.AdminPass.Name = "AdminPass";
            this.AdminPass.Size = new System.Drawing.Size(191, 26);
            this.AdminPass.TabIndex = 4;
            // 
            // StudenLoginbtn
            // 
            this.StudenLoginbtn.Location = new System.Drawing.Point(224, 221);
            this.StudenLoginbtn.Name = "StudenLoginbtn";
            this.StudenLoginbtn.Size = new System.Drawing.Size(85, 44);
            this.StudenLoginbtn.TabIndex = 6;
            this.StudenLoginbtn.Text = "Login";
            this.StudenLoginbtn.UseVisualStyleBackColor = true;
            this.StudenLoginbtn.Click += new System.EventHandler(this.StudenLoginbtn_Click);
            // 
            // StudentClearbtn
            // 
            this.StudentClearbtn.Location = new System.Drawing.Point(118, 221);
            this.StudentClearbtn.Name = "StudentClearbtn";
            this.StudentClearbtn.Size = new System.Drawing.Size(85, 44);
            this.StudentClearbtn.TabIndex = 7;
            this.StudentClearbtn.Text = "Clear";
            this.StudentClearbtn.UseVisualStyleBackColor = true;
            this.StudentClearbtn.Click += new System.EventHandler(this.StudentClearbtn_Click);
            // 
            // AdminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(350, 380);
            this.Controls.Add(this.StudentClearbtn);
            this.Controls.Add(this.StudenLoginbtn);
            this.Controls.Add(this.AdminPass);
            this.Controls.Add(this.Adminuser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminFrm";
            this.Text = "Admin Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Adminuser;
        private System.Windows.Forms.TextBox AdminPass;
        private System.Windows.Forms.Button StudenLoginbtn;
        private System.Windows.Forms.Button StudentClearbtn;
    }
}