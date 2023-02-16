
using ConsoleApp23;
using System.Reflection.Metadata;

namespace ChallengeApp23.Test
{
    internal class TypeTest
    {
        [Test]
        public void DiferentInt()
        {
            // arage
            int number1 = 1;
            int number2 = 2;

            // act

            // assert
            Assert.AreNotEqual(number2,number1);
        }

        [Test]
        public void TheSameString()
        {
            // arage
            string word1 = "Iwona";
            string word2 = "Iwona";

            // act

            // assert
            Assert.AreEqual(word1,word2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObjects()
        {
            // arage
            var employee1 = GetUser("Iwona", "KS", 46);
            var employee2 = GetUser("Iwona", "KS", 46);

            // act

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private EmployeeInMemory GetUser(string name, string surname, int age) //metoda tworząca nowego użytkownika
        {
            return new EmployeeInMemory(name, surname, age);
        }
    }
}
