using System.Diagnostics;
using System.Xml.Linq;

namespace ConsoleApp23
{
    public class EmployeeInMemory : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public EmployeeInMemory()
        {
       
        }

        public EmployeeInMemory(int age, string name, string surname)
            :base(age, name, surname) 
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

        public override void AddGrade(float grade)
        {
            if (grade>=0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("invalid garde value");
            }
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
        
        public override void AddGrade(double grade)
        {
            float gradeFloat = (float)grade;

            this.AddGrade(gradeFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeInt = (float)grade;

            this.AddGrade(gradeInt);
        }

        public override Statistics GetStatistics()
        {
            var stat = new Statistics();

            stat.Average = 0;
            stat.Min = float.MaxValue;
            stat.Max = float.MinValue;

            foreach (var grade in this.grades)
            {
                stat.Max = Math.Max(stat.Max, grade);
                stat.Min = Math.Min(stat.Min, grade);

                stat.Average += grade;
            }
            stat.Average/= this.grades.Count;

            GetAverageAsLetter(stat);

            return stat;
        }
        private static void GetAverageAsLetter(Statistics stat)
        {
            switch (stat.Average)
            {
                case var a when a == 100:
                    stat.AverageLetter = 'A';
                    break;

                case var a when a  >= 80:
                    stat.AverageLetter = 'B';
                    break;

                case var a when a  >= 50:
                    stat.AverageLetter = 'C';
                    break;

                case var a when a  >= 30:
                    stat.AverageLetter = 'D';
                    break;

                default:
                    break;
            }
        }

        public override Statistics CountStatistics(List<float> grades)
        {
            throw new NotImplementedException();
        }
    }
}