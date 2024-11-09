using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainWindow
{
    public partial class StudentView : Form, IView
    {
        public event DeleteDataDelegate DeleteDataEvent;
        public event AddDataDelegate AddDataEvent;
        public event GenerateDataDelegate GenerateDataEvent;

        private StudentWindow studentWindow;
        public StudentView()
        {
            InitializeComponent();
        }

        public void ReloadForm(IEnumerable<IEnumerable<object>> data)
        {
            LoadStudentsList(data);
            LoadStudentsChart(data);
        }

        private void OpenStudentWindow_Click(object sender, EventArgs e)
        {
            this.studentWindow = new StudentWindow(this);
            studentWindow.Show();
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (StudentsListView == null)
            {
                return;
            }

            if (StudentsListView.CurrentRow.Selected)
            {
                DeleteDataEvent?.Invoke(Int32.Parse(StudentsListView.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        public void AddStudent(string _name, string _speciality, string _group)
        {
            string name = _name;
            string speciality = _speciality;
            string group = _group;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(name)) { return; }

            AddDataEvent?.Invoke(new List<object>() { name, speciality, group });
        }

        public void GenerateStudent(int count)
        {
            GenerateDataEvent?.Invoke(count);
        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            DeleteDataEvent?.Invoke(-1);
        }

        private void LoadStudentsList(IEnumerable<IEnumerable<object>> data)
        {
            StudentsListView.Rows.Clear();

            foreach (var item in data)
            {
                List<object> list = new List<object>(item);
                StudentsListView.Rows.Add(list[0], list[1], list[2], list[3]);
            }

        }

        private void LoadStudentsChart(IEnumerable<IEnumerable<object>> data)
        {
            StudentsChart.Series.Clear();

            var studentsSpecialties = data
                .GroupBy(item => item.ElementAt(2).ToString())
                .ToDictionary(g => g.Key, g => g.Count());

            int count = 0;
            int maxStudents = 0;

            foreach (var specialty in studentsSpecialties)
            {
                var series = StudentsChart.Series.Add(specialty.Key);
                series.Points.Add(specialty.Value);

                maxStudents = Math.Max(maxStudents, specialty.Value);
                count++;
            }

            StudentsChart.ChartAreas[0].AxisY.Minimum = 0;
            StudentsChart.ChartAreas[0].AxisY.Maximum = maxStudents + 1;
            StudentsChart.ChartAreas[0].AxisY.Interval = Math.Max(1, maxStudents / 5);
        }
    }
}
