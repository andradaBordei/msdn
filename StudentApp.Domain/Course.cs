using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Domain
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        // navigation to enrolments
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
