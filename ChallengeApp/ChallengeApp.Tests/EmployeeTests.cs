
namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void ShouldReturnMin()
        {
            var employee1 = new Employee("Kuba", "Figurski", 27);
            employee1.AddGrade(2);
            employee1.AddGrade(5);
            employee1.AddGrade(7);
            employee1.AddGrade(10);
            employee1.AddGrade(4);

            var statistics1 = employee1.GetStatistics();

            Assert.AreEqual(2, statistics1.Min);
        }

        [Test]
        public void ShouldReturnMax()
        {
            var employee1 = new Employee("Kuba", "Figurski", 27);
            employee1.AddGrade(2);
            employee1.AddGrade(5);
            employee1.AddGrade(7);
            employee1.AddGrade(10);
            employee1.AddGrade(4);

            var statistics1 = employee1.GetStatistics();

            Assert.AreEqual(10, statistics1.Max);
        }

        [Test]
        public void ShouldReturnAverange()
        {
            var employee1 = new Employee("Kuba", "Figurski", 27);
            employee1.AddGrade(2);
            employee1.AddGrade(5);
            employee1.AddGrade(7);
            employee1.AddGrade(10);
            employee1.AddGrade(4);

            var statistics1 = employee1.GetStatistics();

            Assert.AreEqual(5.6f, statistics1.Avarange);
        }



    }
}
