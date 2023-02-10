namespace ConsoleApp23
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname, int age)
        {
            this.Name=name;
            this.Surname=surname;
            this.Age=age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade>0 && grade <200) //walidacja
            {
                this.grades.Add(grade);
                //dodawaj kolejne wartości number do listy
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
                this.grades.Add(result);
            }
            else
            {
                Console.WriteLine("Wprowadzonej wartości nie można przekszatałcić na liczbę");
            }
        }

        public void AddGrade(double grade)
        {
            double gradeRound = Math.Round(grade, 2);
            float gradeFloat = (float)gradeRound;

            this.grades.Add(gradeFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeInt = (float)grade;

            this.grades.Add(gradeInt);
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

            return stat;
        }
    }
}