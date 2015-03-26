using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5
{
    class Student : IComparable<Student>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        
        public Student(string name, string address, int number)
        {
            Name = name;
            Address = address;
            Number = number;
        }

        public override string ToString()
        {
          return Name + " , " + Address + " , " + Number;
        }

        public int CompareTo(Student other)
        {
            char original = Convert.ToChar(this.Name.Substring(0, 1).ToUpper());
            char different = Convert.ToChar(other.Name.Substring(0, 1).ToUpper());
            if (original > different)
            {
                return 1;
            }
            else if (original < different)
            {
                return -1;
            }
            return 0;
        }
    }
}
