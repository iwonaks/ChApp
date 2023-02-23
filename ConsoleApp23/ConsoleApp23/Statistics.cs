
namespace ConsoleApp23
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Average
        {
            get
            {
                return this.Sum/this.Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var a when a == 100:
                        return 'A';
                    case var a when a  >= 80:
                        return 'B';
                    case var a when a  >= 50:
                        return 'C';
                    case var a when a  >= 30:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }
        public int Count { get; private set; }
        public float Sum
        {
            get;
            private set;

        }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum+= grade;
            this.Max=Math.Max(this.Max, grade);
            this.Min= Math.Min(this.Min, grade);
        }
    }
}
