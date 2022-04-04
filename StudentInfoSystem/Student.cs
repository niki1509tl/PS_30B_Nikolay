using System;
using System.Collections.Generic;
using System.Text;

namespace StudentInfoSystem
{
    class Student
    {
        public string Name;
        public string MiddleName;
        public string LastName;
        public string Faculty;
        public string Speciality;
        public string Degree;
        public string Status; // Could be enm
        public string FacNum;
        public int Course;
        public int Flow;
        public int Group;

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
