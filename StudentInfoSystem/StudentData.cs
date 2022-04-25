using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem
{
    class StudentData
    {
        static public List<Student> TestStudents { get; } = new List<Student>()
        {
            new Student("Ivan", "Ivanov", "Petkov", "faculty", "speciality", "degree", "status", "12345", 6, 2, 30),
            new Student("Test", "Test", "Test", "fac", "spec", "deg", "stat", "222", 2, 1, 29),
            new Student("Nikolay", "a", "b", "c", "spec", "degree", "stat", "121219052", 2, 2, 2)
        };
    }
}
