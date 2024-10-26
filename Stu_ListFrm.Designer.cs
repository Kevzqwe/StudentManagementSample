namespace StudentManagementSample
{
    partial class Stu_ListFrm
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
            this.components = new System.ComponentModel.Container();
            this.StudentList = new System.Windows.Forms.DataGridView();
            this.studentsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginAccountsDataSet = new StudentManagementSample.LoginAccountsDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.Refresh_btn = new System.Windows.Forms.Button();
            this.students_TableTableAdapter = new StudentManagementSample.LoginAccountsDataSetTableAdapters.Students_TableTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.Search_txt = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.student_DataSet = new StudentManagementSample.Student_DataSet();
            this.studentsTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.students_TableTableAdapter1 = new StudentManagementSample.Student_DataSetTableAdapters.Students_TableTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photosDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAccountsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentList
            // 
            this.StudentList.AutoGenerateColumns = false;
            this.StudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentList.BackgroundColor = System.Drawing.Color.White;
            this.StudentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.contactNumberDataGridViewTextBoxColumn,
            this.studentAddressDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.photosDataGridViewImageColumn});
            this.StudentList.DataSource = this.studentsTableBindingSource1;
            this.StudentList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentList.Location = new System.Drawing.Point(17, 59);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(857, 487);
            this.StudentList.TabIndex = 0;
            this.StudentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentList_CellContentClick);
            // 
            // studentsTableBindingSource
            // 
            this.studentsTableBindingSource.DataMember = "Students_Table";
            this.studentsTableBindingSource.DataSource = this.loginAccountsDataSet;
            // 
            // loginAccountsDataSet
            // 
            this.loginAccountsDataSet.DataSetName = "LoginAccountsDataSet";
            this.loginAccountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Master Lists:";
            // 
            // Refresh_btn
            // 
            this.Refresh_btn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_btn.Location = new System.Drawing.Point(695, 547);
            this.Refresh_btn.Name = "Refresh_btn";
            this.Refresh_btn.Size = new System.Drawing.Size(179, 34);
            this.Refresh_btn.TabIndex = 2;
            this.Refresh_btn.Text = "Refresh Data";
            this.Refresh_btn.UseVisualStyleBackColor = true;
            this.Refresh_btn.Click += new System.EventHandler(this.Refresh_btn_Click);
            // 
            // students_TableTableAdapter
            // 
            this.students_TableTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Student: ";
            // 
            // Search_txt
            // 
            this.Search_txt.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_txt.Location = new System.Drawing.Point(612, 15);
            this.Search_txt.Name = "Search_txt";
            this.Search_txt.Size = new System.Drawing.Size(209, 27);
            this.Search_txt.TabIndex = 4;
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.Color.White;
            this.Search_btn.BackgroundImage = global::StudentManagementSample.Properties.Resources.serge_removebg_preview__1_1;
            this.Search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Search_btn.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_btn.ForeColor = System.Drawing.Color.White;
            this.Search_btn.Location = new System.Drawing.Point(827, 9);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(47, 42);
            this.Search_btn.TabIndex = 5;
            this.Search_btn.UseVisualStyleBackColor = false;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // student_DataSet
            // 
            this.student_DataSet.DataSetName = "Student_DataSet";
            this.student_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableBindingSource1
            // 
            this.studentsTableBindingSource1.DataMember = "Students_Table";
            this.studentsTableBindingSource1.DataSource = this.student_DataSet;
            // 
            // students_TableTableAdapter1
            // 
            this.students_TableTableAdapter1.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First_Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "Middle_Name";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "Birth_Date";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "Birth_Date";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // contactNumberDataGridViewTextBoxColumn
            // 
            this.contactNumberDataGridViewTextBoxColumn.DataPropertyName = "Contact_Number";
            this.contactNumberDataGridViewTextBoxColumn.HeaderText = "Contact_Number";
            this.contactNumberDataGridViewTextBoxColumn.Name = "contactNumberDataGridViewTextBoxColumn";
            // 
            // studentAddressDataGridViewTextBoxColumn
            // 
            this.studentAddressDataGridViewTextBoxColumn.DataPropertyName = "Student_Address";
            this.studentAddressDataGridViewTextBoxColumn.HeaderText = "Student_Address";
            this.studentAddressDataGridViewTextBoxColumn.Name = "studentAddressDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // photosDataGridViewImageColumn
            // 
            this.photosDataGridViewImageColumn.DataPropertyName = "Photos";
            this.photosDataGridViewImageColumn.HeaderText = "Photos";
            this.photosDataGridViewImageColumn.Name = "photosDataGridViewImageColumn";
            // 
            // Stu_ListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(896, 593);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Search_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Refresh_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stu_ListFrm";
            this.Text = "Stu_ListFrm";
            this.Load += new System.EventHandler(this.Stu_ListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginAccountsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsTableBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Refresh_btn;
        private LoginAccountsDataSet loginAccountsDataSet;
        private System.Windows.Forms.BindingSource studentsTableBindingSource;
        private LoginAccountsDataSetTableAdapters.Students_TableTableAdapter students_TableTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Search_txt;
        private System.Windows.Forms.Button Search_btn;
        private Student_DataSet student_DataSet;
        private System.Windows.Forms.BindingSource studentsTableBindingSource1;
        private Student_DataSetTableAdapters.Students_TableTableAdapter students_TableTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photosDataGridViewImageColumn;
    }
}