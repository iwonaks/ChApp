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

        [Test]
        public void GetEmployeeGradeAsLetterA()
        {
            var employee = new Employee("Iwona", "Ks", 46);

            employee.AddGrade(100);
            employee.AddGrade(100);
            employee.AddGrade(100);

            var stat = employee.GetStatistics();

            Assert.IsTrue(stat.AverageLetter=='A');
            Assert.IsFalse(stat.AverageLetter=='B');
            Assert.IsFalse(stat.AverageLetter=='C');
            Assert.IsFalse(stat.AverageLetter=='D');
        }

        [Test]
        public void GetEmployeeGradeAsLetterB()
        {
            var employee = new Employee("Iwona", "Ks", 46);

            employee.AddGrade(80);
            employee.AddGrade(80);
            employee.AddGrade(80);

            var stat = employee.GetStatistics();

            Assert.IsTrue(stat.AverageLetter=='B');
            Assert.IsFalse(stat.AverageLetter=='A');
            Assert.IsFalse(stat.AverageLetter=='C');
            Assert.IsFalse(stat.AverageLetter=='D');
        }

        [Test]
        public void GetEmployeeGradeAsLetterC()
        {
            var employee = new Employee("Iwona", "Ks", 46);

            employee.AddGrade(50);
            employee.AddGrade(60);
            employee.AddGrade(55);

            var stat = employee.GetStatistics();

            Assert.IsTrue(stat.AverageLetter=='C');
            Assert.IsFalse(stat.AverageLetter=='A');
            Assert.IsFalse(stat.AverageLetter=='B');
            Assert.IsFalse(stat.AverageLetter=='D');
        }

        [Test]
        public void GetEmployeeGradeAsLetterD()
        {
            var employee = new Employee("Iwona", "Ks", 46);

            employee.AddGrade(20);
            employee.AddGrade(70);
            employee.AddGrade(0);

            var stat = employee.GetStatistics();

            Assert.IsTrue(stat.AverageLetter=='D');
            Assert.IsFalse(stat.AverageLetter=='A');
            Assert.IsFalse(stat.AverageLetter=='B');
            Assert.IsFalse(stat.AverageLetter=='C');
        }

        [Test]
        public void GetEmployeeGradeAsBadLetter()
        {
            var employee = new Employee("Iwona", "Ks", 46);

            employee.AddGrade(29);
            employee.AddGrade(29);
            employee.AddGrade(29);

            var stat = employee.GetStatistics();

            Assert.IsFalse(stat.AverageLetter=='C');
            Assert.IsFalse(stat.AverageLetter=='A');
            Assert.IsFalse(stat.AverageLetter=='B');
            Assert.IsFalse(stat.AverageLetter=='D');
        }
    }
}