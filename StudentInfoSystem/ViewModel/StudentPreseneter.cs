using System.Linq;
using System.Windows.Input;

namespace StudentInfoSystem.ViewModel
{
    public class StudentPreseneter : ObservableObject
    {
        private Student _student;
        public Student Student
        {
            get
            {
                return _student;
            }
            set
            {
                _student = value;
                RaisePropertyChangedEvent("Student");
            }
        }

        public StudentPreseneter()
        {

        }

        public ICommand FillSampleCommand
        {
            get { return new DelegateCommand(FillSample); }
        }

        private void FillSample()
        {
            Student = StudentData.TestStudents.First();
        }

        public ICommand ClearDataCommand
        {
            get { return new DelegateCommand(ClearData); }
        }

        private void ClearData()
        {
            Student = new Student("", "", "", "", "", "","", "", 0, 0, 0);
        }


    }
}
