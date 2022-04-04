using System;
using System.Collections.Generic;
using System.Text;
using UserLogin;

namespace StudentInfoSystem
{
    class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            foreach(Student student in StudentData.TestStudents)
            {
                if(student.FacNum == user.FakNum)
                {
                    return student;
                }
            }
            throw new Exception("Student could not be found");
        }
    }
}
