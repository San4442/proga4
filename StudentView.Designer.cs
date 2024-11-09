namespace MainWindow
{
    partial class StudentView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.StudentsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StudentsListView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteAll = new System.Windows.Forms.Button();
            this.OpenStudentWindow = new System.Windows.Forms.Button();
            this.DeleteStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsListView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.StudentsChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.StudentsChart.Legends.Add(legend2);
            this.StudentsChart.Location = new System.Drawing.Point(12, 12);
            this.StudentsChart.Name = "StudentsChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.StudentsChart.Series.Add(series2);
            this.StudentsChart.Size = new System.Drawing.Size(499, 639);
            this.StudentsChart.TabIndex = 0;
            this.StudentsChart.Text = "chart1";
            // 
            // StudentsListView
            // 
            this.StudentsListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.StudentsListView.Location = new System.Drawing.Point(517, 12);
            this.StudentsListView.Name = "StudentsListView";
            this.StudentsListView.RowHeadersWidth = 51;
            this.StudentsListView.RowTemplate.Height = 24;
            this.StudentsListView.Size = new System.Drawing.Size(688, 639);
            this.StudentsListView.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Speciality";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Group";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // DeleteAll
            // 
            this.DeleteAll.Location = new System.Drawing.Point(12, 657);
            this.DeleteAll.Name = "DeleteAll";
            this.DeleteAll.Size = new System.Drawing.Size(109, 39);
            this.DeleteAll.TabIndex = 3;
            this.DeleteAll.Text = "Удалить все";
            this.DeleteAll.UseVisualStyleBackColor = true;
            this.DeleteAll.Click += new System.EventHandler(this.DeleteAll_Click);
            // 
            // OpenStudentWindow
            // 
            this.OpenStudentWindow.Location = new System.Drawing.Point(127, 657);
            this.OpenStudentWindow.Name = "OpenStudentWindow";
            this.OpenStudentWindow.Size = new System.Drawing.Size(384, 39);
            this.OpenStudentWindow.TabIndex = 4;
            this.OpenStudentWindow.Text = "Добавить студента";
            this.OpenStudentWindow.UseVisualStyleBackColor = true;
            this.OpenStudentWindow.Click += new System.EventHandler(this.OpenStudentWindow_Click);
            // 
            // DeleteStudent
            // 
            this.DeleteStudent.Location = new System.Drawing.Point(517, 657);
            this.DeleteStudent.Name = "DeleteStudent";
            this.DeleteStudent.Size = new System.Drawing.Size(688, 39);
            this.DeleteStudent.TabIndex = 5;
            this.DeleteStudent.Text = "Удалить студента";
            this.DeleteStudent.UseVisualStyleBackColor = true;
            this.DeleteStudent.Click += new System.EventHandler(this.DeleteStudent_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 708);
            this.Controls.Add(this.DeleteStudent);
            this.Controls.Add(this.OpenStudentWindow);
            this.Controls.Add(this.DeleteAll);
            this.Controls.Add(this.StudentsListView);
            this.Controls.Add(this.StudentsChart);
            this.Name = "MainWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart StudentsChart;
        private System.Windows.Forms.DataGridView StudentsListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button DeleteAll;
        private System.Windows.Forms.Button OpenStudentWindow;
        private System.Windows.Forms.Button DeleteStudent;
    }
}

