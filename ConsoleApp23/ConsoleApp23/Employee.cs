using System.Diagnostics;

namespace ConsoleApp23
{
    public class Employee
    {
        private List<float> grades = new List<float>();


        public Employee()
        {
        }

        public Employee(string name, string surname, int age)
        {
            this.Name=name;
            this.Surname=surname;
            this.Age=age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }


        public void AddGrade(char grade)
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
                    Console.WriteLine("Ocena poza zakresem, nie została dodana");
                    break;
            }
        }

        public void AddGrade(float grade)
        {
            if (grade>=0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Błędny zakres");
            }
        }

        public void AddGrade(string grade)
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
                Console.WriteLine("Wprowadzonej wartości nie można przekszatałcić na liczbę");
            }
        }

        public void AddGrade(double grade)
        {
            float gradeFloat = (float)grade;

            this.AddGrade(gradeFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeInt = (float)grade;

            this.AddGrade(gradeInt);
        }

        public Statistics GetStatistics()
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
                    Console.WriteLine("Nie uzyskałeś wystarczającej średniej do zaliczenia");
                    break;
            }
        }
    }
}