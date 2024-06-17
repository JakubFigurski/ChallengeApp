﻿namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public abstract event GradeAddedDelegate GradeAdded;
        
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.GradeAdded += this.EmployeeGradeAdded;
        }
        public EmployeeBase()
        {
            this.GradeAdded += this.EmployeeGradeAdded;
        }

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public void EmployeeGradeAdded(object sender, EventArgs args)
        {
            Console.WriteLine("Dodano nową ocenę");
        }
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(string? grade);
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
        public void AddGrade(ulong grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(uint grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
        }
        public abstract Statistics GetStatistics();
    }
}