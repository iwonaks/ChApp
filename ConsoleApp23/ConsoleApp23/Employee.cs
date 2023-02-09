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
            this.grades.Add(grade);
            //dodawaj kolejne wartości number do listy
        }

        public Statistics GetStatistics()
        {
            var stat = new Statistics();

            stat.Average = 0;
            stat.Min = float.MaxValue;
            stat.Max = float.MinValue;

            foreach(var grade in this.grades)
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