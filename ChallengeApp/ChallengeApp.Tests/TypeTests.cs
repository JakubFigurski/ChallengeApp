using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void IntAreTheSame()
        {
            //arrange
            int a = 5;
            int b = 5;
            //assert

            Assert.AreEqual(a, b);

        }

        [Test]
        public void IntArenotTheSame()
        {
            //arrange
            int a = 5;
            int b = 6;

            //assert

            Assert.AreNotEqual(a, b);

        }

        [Test]
        public void FloatAreTheSame()
        {
            //arrange
            float a = 5.2f;
            float b = 5.2f;

            //assert

            Assert.AreEqual(a, b);

        }

        [Test]
        public void DoubleAreNotTheSame()
        {
            //arrange

            double a = 5.5;
            double b = 5.5;

            //assert

            Assert.AreEqual(a, b);

        }

        [Test]
        public void UserWithTheSameSurname()
        {

            //arrange

            var user1 = GetUser("kuba", "Figurski", 27);
            var user2 = GetUser("Kamil", "Figurski", 30);

            //assert

            Assert.AreEqual(user1.Surname, user2.Surname);
          
        }

        private Employee GetUser(string name, string surname, int age)
        {
            return new Employee(name, surname, age );
        }

    }
}
