namespace ChallengeApp
{
    public class Supervisior : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisior(string? name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string? Name { get; set; }
        public string Surname { get; set; }

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

        public void AddGrade(string grade)
        {

            switch (grade)
            {
                case "6":
                    this.AddGrade(100);
                    break;
                case "-6":
                case "6-":
                    this.AddGrade(95);
                    break;
                case "+5":
                case "5+":
                    this.AddGrade(85);
                    break;
                case "5":
                    this.AddGrade(80);
                    break;
                case "-5":
                case "5-":
                    this.AddGrade(75);
                    break;
                case "+4":
                case "4+":
                    this.AddGrade(65);
                    break;
                case "4":
                    this.AddGrade(60);
                    break;
                case "-4":
                case "4-":
                    this.AddGrade(55);
                    break;
                case "+3":
                case "3+":
                    this.AddGrade(45);
                    break;
                case "3":
                    this.AddGrade(40);
                    break;
                case "-3":
                case "3-":
                    this.AddGrade(35);
                    break;
                case "+2":
                case "2+":
                    this.AddGrade(25);
                    break;
                case "2":
                    this.AddGrade(20);
                    break;
                case "-2":
                case "2-":
                    this.AddGrade(15);
                    break;
                case "+1":
                case "1+":
                    this.AddGrade(5);
                    break;
                case "1":
                    this.AddGrade(0);
                    break;
                default:
                    throw new Exception("String is not float");
            }
        }

        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
        }

        /*  public void AddGrade(char grade)
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
      */

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
                    statistics.Avarange = grade;
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

      
