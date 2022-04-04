using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem
{
    class StudentData
    {
        static public List<Student> TestStudents { get; } = new List<Student>()
        {
            new Student("Ivan", "Ivanov", "Petkov", "faculty", "speciality", "degree", "status", "12345", 6, 2, 30)
        };
    }
}
