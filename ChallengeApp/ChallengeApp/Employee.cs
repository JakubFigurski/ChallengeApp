﻿namespace ChallengeApp
{
    public class Employee : Person, IEmployee
    {
        private List<float> grades = new List<float>();

        public Employee()
            : this("no name", "no surname") 
            
        {          
        }

        public Employee(string name, string surname)
            : base(name, surname)
        {
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
         
        public void AddGrade(string? grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultLetter))
            {
                this.AddGrade(resultLetter);
            }
            else 
            {
                throw new Exception("String is not float");
            }
        
        }
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
        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avarange = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue; 
            statistics.Count = 0;
            statistics.Sum = 0;
            if (this.grades.Count > 0)
            {
                statistics.Max = float.MinValue;
                statistics.Min = float.MaxValue;
                foreach (var grade in this.grades)
                {
                    if (grade < 0)
                    {                      
                        continue;
                    }
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Avarange= grade;
                    statistics.Count++;
                    statistics.Sum = statistics.Sum + grade;
                }
                statistics.Avarange /= this.grades.Count;
            }
            else
            {
                statistics.Min = 0;
                statistics.Max = 0;
            }
            switch (statistics.Avarange)
            {
                case var a when a >= 80:
                    statistics.AvarangeLetter = 'A';
                    break;
                case var b when b >= 60:
                    statistics.AvarangeLetter = 'B';
                    break;
                case var c when c >= 40:
                    statistics.AvarangeLetter = 'C';
                    break;
                case var d when d >= 20:
                    statistics.AvarangeLetter = 'D';
                    break;
                case var e when e <= 19:
                    statistics.AvarangeLetter = 'E';
                    break;
            }
            return statistics;
        }

    }
}