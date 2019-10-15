using System;
using System.Collections.Generic;
using System.Text;
using StudentApp.Data;
using StudentApp.Domain;

namespace StudentApp.Service
{
    public class StudentService : IStudentService
    {
        public void AddStudent(Student student)
        {
            using (var context = new SchoolContext())
            {

                var std = new Student()
                {
                    LastName = "Bill"
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        }

        public IEnumerable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetTop3BestGradesByCourse()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetTop3BestInSchool()
        {
            throw new NotImplementedException();
        }
    }
}
