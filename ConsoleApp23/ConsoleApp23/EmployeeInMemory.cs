using System.Diagnostics;
using System.Xml.Linq;

namespace ConsoleApp23
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public override event FeedbakToAddGrade GradeAddedToStatistics;
        public override event FeedbakToAddGrade GradeSaveToFile;

        public EmployeeInMemory()
        {

        }

        public EmployeeInMemory(int age, string name, string surname)
            : base(age, name, surname)
        {

        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;

                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;

                case 'C':
                case 'c':
                    this.grades.Add(50);
                    break;

                case 'D':
                case 'd':
                    this.grades.Add(30);
                    break;

                default:
                    throw new Exception("Ocena poza zakresem, nie została dodana");
                    break;
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeFloat = (float)grade;

            this.AddGrade(gradeFloat);
        }

        public override void AddGrade(float grade)
        {
            if (grade>=0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAddedToStatistics!= null)
                {
                    GradeAddedToStatistics(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid garde value");
            }
        }

        public override void AddGrade(int grade)
        {
            float gradeInt = (float)grade;

            this.AddGrade(gradeInt);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char result2))
            {
                this.AddGrade(result2);
            }
            else
            {
                throw new Exception("Wprowadzonej wartości nie można przekszatałcić na liczbę");
            }
        }

        public override Statistics GetStatistics()
        {
            var stat = new Statistics();

            foreach(var grade in this.grades) 
            {
                stat.AddGrade(grade);
            }
            return stat;
        }
        
        public override Statistics CountStatistics(List<float> grades)
        {
            throw new NotImplementedException();
        }
    }
}