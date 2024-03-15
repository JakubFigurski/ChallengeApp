﻿namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void ShouldReturnAllZeroesWhenGradesCountIsZero()
        {
            //arrange
            var Employee = new Employee();

            // act
            Statistics stat = Employee.GetStatistics();

            // assert
            Assert.That(stat.Max, Is.EqualTo(0));
            Assert.That(stat.Min, Is.EqualTo(0));
            Assert.That(stat.Avarange, Is.EqualTo(0));
        }
        [Test]
        public void ShouldReturnCorrectMinMax()
        {
            //arrange
            var Employee = new Employee();
            Employee.AddGrade(1);
            Employee.AddGrade(2);
            Employee.AddGrade(3);

            // act
            Statistics stat = Employee.GetStatistics();

            // assert
            Assert.That(stat.Min, Is.EqualTo(1));
            Assert.That(stat.Max, Is.EqualTo(3));
        }

        [Test]
        public void ShouldReturnCorrectAverageLetter()
        {
            //arrange
            var Employee = new Employee();
            Employee.AddGrade('A');
            Employee.AddGrade('a');
            Employee.AddGrade('B');
            Employee.AddGrade('b');
            Employee.AddGrade('C');
            Employee.AddGrade('c');
            Employee.AddGrade('D');
            Employee.AddGrade('d');
            Employee.AddGrade('E');
            Employee.AddGrade('e');

            // act
            Statistics stat = Employee.GetStatistics();

            // assert
            Assert.That(stat.AvarangeLetter, Is.EqualTo('E'));
        }
    }
}