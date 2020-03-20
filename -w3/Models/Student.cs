using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cwiczenia3.NewFolder
{


    public class Student
    {
        public int IdStudent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IndexNumber { get; set; }

        override
        public string ToString()
        {
            return $"{IdStudent}: {IndexNumber} {FirstName} {LastName}";
        }
    }
}