
using System.Runtime.CompilerServices;

namespace ConsoleApp23
{
    internal class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "gradesEmployee.txt";

        public override event FeedbakToAddGrade GradeAddedToStatistics;
        public override event FeedbakToAddGrade GradeSaveToFile;

        public EmployeeInFile()
        {
        }

        public EmployeeInFile(int age, string name, string surname) : base(age, name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade>=0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);

                    if (GradeSaveToFile!=null)
                    {
                        GradeSaveToFile(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception("invalid garde value");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeFloat = (float)grade;

            AddGrade(gradeFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeFloat = (float)grade;

            AddGrade(gradeFloat);
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result1))
            {
                this.AddGrade(result1);
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

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;

                case 'B':
                case 'b':
                    AddGrade(80);
                    break;

                case 'C':
                case 'c':
                    AddGrade(50);
                    break;

                case 'D':
                case 'd':
                    AddGrade(30);
                    break;

                default:
                    throw new Exception("Ocena poza zakresem i nie została dodana");
            }
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();

            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line!=null)
                    {
                        var lineFloat = float.Parse(line);
                        grades.Add(lineFloat);
                        line = reader.ReadLine();
                    }
                    if (GradeAddedToStatistics!= null)
                    {
                        GradeAddedToStatistics(this, new EventArgs());
                    }
                }
            }
            return grades;
        }
    
    public override Statistics CountStatistics(List<float> grades)
    {
        var stat = new Statistics();

        stat.Average = 0;
        stat.Min = float.MaxValue;
        stat.Max = float.MinValue;


        foreach (var grade in grades)
        {
            stat.Max = Math.Max(stat.Max, grade);
            stat.Min = Math.Min(stat.Min, grade);

            stat.Average += grade;
        }
        stat.Average/= grades.Count;

        return stat;
    }
    public override Statistics GetStatistics()
    {
        var gradesFromList = ReadGradesFromFile();
        var result = CountStatistics(gradesFromList);
        return result;
    }
}
}
