using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residence
{
    internal class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Student(string name, string email) 
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }

    }
}
