using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5
{
    class SortAddress : IComparer<Student>
    {
        public int Compare(Student a, Student b)
        {
            return String.Compare(a.Address, b.Address);
        }
    }
}
