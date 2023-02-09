using ConsoleApp23;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp23.Test
{
    public class Tests
    {
        [Test]
        public void Result_JobEvaluation()
        {
            var employee = new Employee("Iwona", "Ks", 46);

            employee.AddJobEvaluation(3);
            employee.AddJobEvaluation(-8);
            employee.AddJobEvaluation(-7);

            var sum = employee.Result;

            Assert.AreEqual(-12,sum); 
        }
    }
}