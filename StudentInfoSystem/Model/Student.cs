using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem
{
    public class Student
    {
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }
        public string Degree { get; set; }
        public string Status { get; set; } // Could be enm
        public string FacNum { get; set; }
        public int Course { get; set; }
        public int Flow { get; set; }
        public int Group { get; set; }

        public Student(string name, string middleName, string lastName, string faculty, string speciality, string degree, string status, string facNum, int course, int flow, int group)
        {
            Name = name;
            MiddleName = middleName;
            LastName = lastName;
            Faculty = faculty;
            Speciality = speciality;
            Degree = degree;
            Status = status;
            FacNum = facNum;
            Course = course;
            Flow = flow;
            Group = group;
        }
    }
}
