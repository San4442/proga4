namespace MainWindow
{
    partial class StudentWindow
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
            this.AddStudent = new System.Windows.Forms.Button();
            this.TextGroup = new System.Windows.Forms.TextBox();
            this.TextSpeciality = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextCountGenerate = new System.Windows.Forms.TextBox();
            this.GenerateStudentList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(12, 101);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(458, 59);
            this.AddStudent.TabIndex = 7;
            this.AddStudent.Text = "Добавить студента";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // TextGroup
            // 
            this.TextGroup.Location = new System.Drawing.Point(11, 72);
            this.TextGroup.Name = "TextGroup";
            this.TextGroup.Size = new System.Drawing.Size(459, 22);
            this.TextGroup.TabIndex = 6;
            // 
            // TextSpeciality
            // 
            this.TextSpeciality.Location = new System.Drawing.Point(11, 44);
            this.TextSpeciality.Name = "TextSpeciality";
            this.TextSpeciality.Size = new System.Drawing.Size(459, 22);
            this.TextSpeciality.TabIndex = 5;
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(11, 16);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(459, 22);
            this.TextName.TabIndex = 4;
            // 
            // TextCountGenerate
            // 
            this.TextCountGenerate.Location = new System.Drawing.Point(543, 16);
            this.TextCountGenerate.Name = "TextCountGenerate";
            this.TextCountGenerate.Size = new System.Drawing.Size(245, 22);
            this.TextCountGenerate.TabIndex = 9;
            // 
            // GenerateStudentList
            // 
            this.GenerateStudentList.Location = new System.Drawing.Point(543, 44);
            this.GenerateStudentList.Name = "GenerateStudentList";
            this.GenerateStudentList.Size = new System.Drawing.Size(245, 116);
            this.GenerateStudentList.TabIndex = 8;
            this.GenerateStudentList.Text = "Сгенерировать список";
            this.GenerateStudentList.UseVisualStyleBackColor = true;
            this.GenerateStudentList.Click += new System.EventHandler(this.GenerateStudentList_Click);
            // 
            // StudentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 178);
            this.Controls.Add(this.TextCountGenerate);
            this.Controls.Add(this.GenerateStudentList);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.TextGroup);
            this.Controls.Add(this.TextSpeciality);
            this.Controls.Add(this.TextName);
            this.Name = "StudentWindow";
            this.Text = "StudentWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.TextBox TextGroup;
        private System.Windows.Forms.TextBox TextSpeciality;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextCountGenerate;
        private System.Windows.Forms.Button GenerateStudentList;
    }
}