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
    public partial class StudentWindow : Form
    {
        private StudentView view;

        public StudentWindow(StudentView view)
        {
            this.view = view;
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            
            string name = TextName.Text;
            string speciality = TextSpeciality.Text;
            string group = TextGroup.Text;

            view.AddStudent(name, speciality, group);
        }

        private void GenerateStudentList_Click(object sender, EventArgs e)
        {
            view.GenerateStudent(Int32.Parse(TextCountGenerate.Text));
        }
    }
}
