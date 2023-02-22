namespace ConsoleApp23
{
    public class Supervisor : EmployeeBase
    {
        private List<float> grades = new List<float>();

        public override event FeedbakToAddGrade GradeAddedToStatistics;
        public override event FeedbakToAddGrade GradeSaveToFile;
        public Supervisor()
        {

        }
        public Supervisor(int age, string name, string surname)
            : base(age, name, surname)
        {

        }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public int Age { get; set; }

        public override Statistics GetStatistics()
        {
            var statSupervisor = new Statistics();

            statSupervisor.Average = 0;
            statSupervisor.Min = float.MaxValue;
            statSupervisor.Max = float.MinValue;

            foreach (var grade in this.grades)
            {
                statSupervisor.Max = Math.Max(statSupervisor.Max, grade);
                statSupervisor.Min = Math.Min(statSupervisor.Min, grade);

                statSupervisor.Average += grade;
            }
            statSupervisor.Average/= this.grades.Count;

            return statSupervisor;
        }
        public override void AddGrade(int grade)
        {
            float gradeInt = (float)grade;
            this.AddGrade(gradeInt);
        }

        public override void AddGrade(string grade)
        {
            switch (grade)
            {
                case "1":
                    this.grades.Add(0);
                    break;

                case "1+":
                case "+1":
                    this.grades.Add(10);
                    break;

                case "2-":
                case "-2":
                    this.grades.Add(15);
                    break;

                case "2":
                    this.grades.Add(20);
                    break;

                case "2+":
                case "+2":
                    this.grades.Add(25);
                    break;

                case "3-":
                case "-3":
                    this.grades.Add(35);
                    break;

                case "3":
                    this.grades.Add(40);
                    break;

                case "3+":
                case "+3":
                    this.grades.Add(45);
                    break;

                case "-4":
                case "4-":
                    this.grades.Add(55);
                    break;

                case "4":
                    this.grades.Add(60);
                    break;

                case "4+":
                case "+4":
                    this.grades.Add(65);
                    break;

                case "-5":
                case "5-":
                    this.grades.Add(75);
                    break;

                case "5":
                    this.grades.Add(80);
                    break;

                case "5+":
                case "+5":
                    this.grades.Add(85);
                    break;

                case "-6":
                case "6-":
                    this.grades.Add(95);
                    break;

                case "6":
                    this.grades.Add(100);
                    break;
                default:
                    throw new Exception("Wpisana wartość nie odpowiada ocenie");
            }
        }

        public override void AddGrade(char grade)
        {
            throw new Exception("");
        }

        public override void AddGrade(float grade)
        {
            throw new Exception("");
        }

        public override void AddGrade(double grade)
        {
            throw new Exception("");
        }

        public override Statistics CountStatistics(List<float> grades)
        {
            throw new NotImplementedException();
        }
    }
}