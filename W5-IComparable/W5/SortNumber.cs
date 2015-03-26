using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5
{
    class SortNumber : IComparer<Student>
    {
        public int Compare(Student a, Student b)
        {
            if (a.Number > b.Number)
            {
                return 1;
            }
            if (a.Number < b.Number)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
