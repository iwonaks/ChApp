
namespace ConsoleApp23
{
    public abstract class EmployeeBase : IEmployee
    {
        public int Age { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public EmployeeBase()
        {

        }

        public EmployeeBase(int age, string name, string surname)
        {
            this.Age = age;
            this.Name = name;
            this.Surname = surname;
        }

        event IEmployee.FeedbakToAddGrade IEmployee.GradeAddedToStatistics
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        event IEmployee.FeedbakToAddGrade IEmployee.GradeSaveToFile
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public abstract void AddGrade(int grade);
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(string grade);
        public abstract void AddGrade(char grade);
        public abstract Statistics GetStatistics();
        public abstract Statistics CountStatistics(List<float> grades);

        public delegate void FeedbakToAddGrade(Object sender, EventArgs args);

        public abstract event FeedbakToAddGrade GradeAddedToStatistics;

        public abstract event FeedbakToAddGrade GradeSaveToFile;
    }
}