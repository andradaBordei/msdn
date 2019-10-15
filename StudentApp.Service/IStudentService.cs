using StudentApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp.Service
{
    interface IStudentService
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentByName(string name);
        IEnumerable<Student> GetTop3BestGradesByCourse();

        IEnumerable<Student> GetTop3BestInSchool();
        void AddStudent(Student student);

    }
}
  