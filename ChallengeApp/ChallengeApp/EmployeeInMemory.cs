﻿namespace ChallengeApp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate? GradeAdded;
        private List<float> grades = new List<float>();


        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }


        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        public override void AddGrade(string? grade)
        {
            if ((!string.IsNullOrWhiteSpace(grade)) && (grade.Length < 3))
            {
                int signDetect = 0;
                int stringscore = 0;
                foreach (char a in grade)
                {
                    switch (a)
                    {
                        case '+':
                            signDetect = 5;
                            break;
                        case '-':
                            signDetect = -5;
                            break;
                        case '6':
                            stringscore = 100;
                            break;
                        case '5':
                            stringscore = 80;
                            break;
                        case '4':
                            stringscore = 60;
                            break;
                        case '3':
                            stringscore = 40;
                            break;
                        case '2':
                            stringscore = 20;
                            break;
                        case '1':
                        case '0':
                            stringscore = 0;
                            break;
                        default:
                            throw new Exception("Unsupported grade");
                    }
                }
                stringscore += signDetect;
                if (stringscore < 0)
                {
                    this.AddGrade(0);
                }
                else if (stringscore > 100)
                {
                    this.AddGrade(100);
                }
                else
                {
                    this.AddGrade(stringscore);
                }
            }
            else
            {
                throw new Exception("Wrong grade string");
            }
        }
        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Avarange = 0;
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
                    statistics.Avarange += grade;
                }
                statistics.Avarange = statistics.Avarange / this.grades.Count;
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
                case var a when a >= 60:
                    statistics.AvarangeLetter = 'B';
                    break;
                case var a when a >= 40:
                    statistics.AvarangeLetter = 'C';
                    break;
                case var a when a >= 20:
                    statistics.AvarangeLetter = 'D';
                    break;
                default:
                    statistics.AvarangeLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}