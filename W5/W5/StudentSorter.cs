using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5
{
    class StudentSorter: IComparer<Student>
    {
        private List<Student> students;
        public StudentSorter(List<Student> students)
        {
            this.students = students;
        }
        public int Compare(Student x, Student y)
        {
            if (x.Number > y.Number)
            {
                return 1;
            }
            else if (x.Number < y.Number)
            {
                return -1;
            }
            return 0;
        }
    }
}
