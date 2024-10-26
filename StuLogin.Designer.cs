namespace StudentManagementSample
{
    partial class StuLogin
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
            this.StudentUser = new System.Windows.Forms.TextBox();
            this.StudentPass = new System.Windows.Forms.TextBox();
            this.StudenLoginbtn = new System.Windows.Forms.Button();
            this.StudentClearbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // StudentUser
            // 
            this.StudentUser.Location = new System.Drawing.Point(118, 124);
            this.StudentUser.Name = "StudentUser";
            this.StudentUser.Size = new System.Drawing.Size(191, 27);
            this.StudentUser.TabIndex = 2;
            // 
            // StudentPass
            // 
            this.StudentPass.Location = new System.Drawing.Point(118, 172);
            this.StudentPass.Name = "StudentPass";
            this.StudentPass.Size = new System.Drawing.Size(191, 27);
            this.StudentPass.TabIndex = 3;
            // 
            // StudenLoginbtn
            // 
            this.StudenLoginbtn.Location = new System.Drawing.Point(224, 221);
            this.StudenLoginbtn.Name = "StudenLoginbtn";
            this.StudenLoginbtn.Size = new System.Drawing.Size(85, 44);
            this.StudenLoginbtn.TabIndex = 4;
            this.StudenLoginbtn.Text = "Login";
            this.StudenLoginbtn.UseVisualStyleBackColor = true;
            // 
            // StudentClearbtn
            // 
            this.StudentClearbtn.Location = new System.Drawing.Point(118, 221);
            this.StudentClearbtn.Name = "StudentClearbtn";
            this.StudentClearbtn.Size = new System.Drawing.Size(85, 44);
            this.StudentClearbtn.TabIndex = 5;
            this.StudentClearbtn.Text = "Clear";
            this.StudentClearbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Student Login";
            // 
            // StuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(350, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentClearbtn);
            this.Controls.Add(this.StudenLoginbtn);
            this.Controls.Add(this.StudentPass);
            this.Controls.Add(this.StudentUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StuLogin";
            this.Text = "Student Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentUser;
        private System.Windows.Forms.TextBox StudentPass;
        private System.Windows.Forms.Button StudenLoginbtn;
        private System.Windows.Forms.Button StudentClearbtn;
        private System.Windows.Forms.Label label3;
    }
}