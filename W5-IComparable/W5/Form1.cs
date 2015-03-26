using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            students.Add(new Student("Robin", "Son", 3));
            students.Add(new Student("Guus", "Eindhoven", 1));
            students.Add(new Student("Bas", "Fontys", 2));
            FillList(students);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            students.Add(new Student(tbNaam.Text, tbAddress.Text, Convert.ToInt32(tbNummer.Text)));
            FillList(students);
        }

        private void FillList(List<Student> students)
        {
            lbStudents.Items.Clear();
            foreach (Student student in students)
            {
                lbStudents.Items.Add(student);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            students.Sort();
            FillList(students);
        }

        private void btnSortNumber_Click(object sender, EventArgs e)
        {
            students.Sort(new SortNumber());
            FillList(students);
        }

        private void btnSortAddress_Click(object sender, EventArgs e)
        {
            students.Sort(new SortAddress());
            FillList(students);
        }
    }
}
