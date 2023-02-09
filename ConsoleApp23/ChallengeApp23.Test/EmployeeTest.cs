using ConsoleApp23;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp23.Test
{
    public class Tests
    {
        [Test]
        public void GetAverageEmployeeStatistic()
        {
            var employee = new Employee("Iwona", "Ks", 46);

            employee.AddGrade(3);
            employee.AddGrade(6);
            employee.AddGrade(7);

            var stat = employee.GetStatistics();

            Assert.AreEqual(Math.Round(5.33), Math.Round(stat.Average));
        }

        [Test]
        public void GetMinEmployeeStatistic()
        {
            var employee = new Employee("Iwona", "Ks", 46);

            employee.AddGrade(3);
            employee.AddGrade(6);
            employee.AddGrade(7);

            var stat = employee.GetStatistics();

            Assert.AreEqual(3, stat.Min);
        }

        [Test]
        public void GetMaxEmployeeStatistic()
        {
            var employee = new Employee("Iwona", "Ks", 46);

            employee.AddGrade(3);
            employee.AddGrade(6);
            employee.AddGrade(7);

            var stat = employee.GetStatistics();

            Assert.AreEqual(7, stat.Max);
        }
    }
}