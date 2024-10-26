namespace StudentManagementSample
{
    partial class MainFrm
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
            this.Adminbtn = new System.Windows.Forms.Button();
            this.Teacherbtn = new System.Windows.Forms.Button();
            this.Studentbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log in";
            // 
            // Adminbtn
            // 
            this.Adminbtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbtn.Location = new System.Drawing.Point(110, 241);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Size = new System.Drawing.Size(121, 47);
            this.Adminbtn.TabIndex = 3;
            this.Adminbtn.Text = "Admin";
            this.Adminbtn.UseVisualStyleBackColor = true;
            this.Adminbtn.Click += new System.EventHandler(this.Adminbtn_Click);
            // 
            // Teacherbtn
            // 
            this.Teacherbtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacherbtn.Location = new System.Drawing.Point(110, 179);
            this.Teacherbtn.Name = "Teacherbtn";
            this.Teacherbtn.Size = new System.Drawing.Size(121, 47);
            this.Teacherbtn.TabIndex = 2;
            this.Teacherbtn.Text = "Teacher";
            this.Teacherbtn.UseVisualStyleBackColor = true;
            this.Teacherbtn.Click += new System.EventHandler(this.Teacherbtn_Click);
            // 
            // Studentbtn
            // 
            this.Studentbtn.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentbtn.Location = new System.Drawing.Point(110, 120);
            this.Studentbtn.Name = "Studentbtn";
            this.Studentbtn.Size = new System.Drawing.Size(121, 47);
            this.Studentbtn.TabIndex = 1;
            this.Studentbtn.Text = "Student";
            this.Studentbtn.UseVisualStyleBackColor = true;
            this.Studentbtn.Click += new System.EventHandler(this.Studentbtn_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(350, 380);
            this.Controls.Add(this.Adminbtn);
            this.Controls.Add(this.Teacherbtn);
            this.Controls.Add(this.Studentbtn);
            this.Controls.Add(this.label1);
            this.Name = "MainFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Adminbtn;
        private System.Windows.Forms.Button Teacherbtn;
        private System.Windows.Forms.Button Studentbtn;
    }
}

