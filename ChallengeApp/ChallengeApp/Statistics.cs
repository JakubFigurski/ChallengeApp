namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public int Count { get; private set; }

        public float Sum { get; private set; }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MaxValue;
            this.Min = float.MinValue;
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
        }

        public float Avarange
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char AvarangeLetter
        {
            get
            {
                switch (this.Avarange)
                {
                    case var a when a >= 80:
                        return 'A';
                    case var a when a >= 60:
                        return 'B';
                    case var a when a >= 40:
                        return 'C';
                    case var a when a >= 20:
                        return 'D';
                    default:
                        return 'E';

                }
            }

        }
    }
}
