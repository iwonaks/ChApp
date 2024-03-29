﻿
using System.Runtime.CompilerServices;

namespace ConsoleApp23
{
    internal class EmployeeInFile : EmployeeBase
    {
        public string Name { get; set; }
      
        public override event FeedbakToAddGrade GradeAddedToStatistics;
        public override event FeedbakToAddGrade GradeSaveToFile;

        public EmployeeInFile()
        {
        }

        public EmployeeInFile(int age, string name, string surname) : base(age, name, surname)
        {
            this.Name = name;
            
        }

        public override void AddGrade(float grade)
        {
            if (grade>=0 && grade <= 100)
            {
                using (var writer = File.AppendText($"{Name}.txt"))
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

            if (File.Exists($"{Name}.txt"))
            {
                using (var reader = File.OpenText($"{Name}.txt"))
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

           foreach(var grade in grades)
            {
                stat.AddGrade(grade);
            }

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
