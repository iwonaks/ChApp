namespace ConsoleApp23
{
    class Employee
    {
        private List<int> jobEvaluation = new List<int>();        

        public Employee(string name, string surname, int age)
        {
            this.Name=name;
            this.Surname=surname;
            this.Age=age;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public void AddJobEvaluation(int number)
        {
            this.jobEvaluation.Add(number);
            //dodawaj kolejne wartości number do listy
        }
        
        public int Result2
        {
            get { return this.jobEvaluation.Sum(); }
            //zwraca sumę elementów z listy jobEvaluation
        }
    }
}