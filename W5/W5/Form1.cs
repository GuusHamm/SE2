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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            students.Add(new Student(tbNaam.Text,tbAddress.Text,Convert.ToInt32(tbNummer.Text)));
            FillList(students);
        }

        private void FillList(List<Student> students)
        {
            listBox1.Items.Clear();
            foreach (Student student in students)
            {
                listBox1.Items.Add(student);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            students.Sort();
            FillList(students);
        }

        private void btnSortNumber_Click(object sender, EventArgs e)
        {
            StudentSorter studentSorter = new StudentSorter(students);
            studentSorter.Compare();
        }

        public static IComparer StudentSorter()
        {
            return (IComparer)new StudentSorter();
        }
}
}
