using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Domain
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }

        public string FirstMidName { get; set; }

        public DateTime EnrollDateTime { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
