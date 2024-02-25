namespace ChallengeApp.Tests
    
{
    public class Tests
    {  
        [Test]
        public void AddScoreShouldHaveResult()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski", 22);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(10);
            employee.AddScore(1);


            //act
            var result = employee.Result;

            //assert  
            Assert.AreEqual(23, result);
               
        }

        [Test]
        public void AddAndTakeAwayUserScore()
        {
            //arrange
            var employee = new Employee("Kuba", "Kowalski", 27);
            employee.AddScore(10);
            employee.AddScore(7);
            employee.AddScore(20);
            employee.AddScore(-1);


            //act
            var result = employee.Result;

            //assert  
            Assert.AreEqual(36, result);

        }

        [Test]
        public void CheckUserScoreWithMinusPoint()
        {
            //arrange
            var employee = new Employee("Adrian", "Kowalski", 50);
            employee.AddScore(-5);
            employee.AddScore(-7);
            employee.AddScore(-10);
            employee.AddScore(-1);


            //act
            var result = employee.Result;

            //assert  
            Assert.AreEqual(-23, result);

        }





    }
}