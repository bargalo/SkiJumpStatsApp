namespace SkiStatsApp
{
    public class Statistics
    {
        public float Longest { get; private set; }
        public float Shortest { get; private set; }
        public float Average
        {
            get
            {
                return TotalLenght / Count;
            }
        }
        public float TotalLenght { get; private set; }
        public int Count { get; private set; }

        public Statistics()
        {
            Count = 0;
            TotalLenght = 0;
            Longest = float.MinValue;
            Shortest = float.MaxValue;
        }

        public string JumperLevel
        {
            get
            {
                switch (Average)
                {
                    case var average when average >= 135:
                        return "Legendary";
                    case var average when average >= 125:
                        return "Amazing";
                    case var average when average >= 115:
                        return "Good";
                    case var average when average >= 105:
                        return "Average";
                    default:
                        return "Train more!";
                }
            }
        }
        public void AddDistance(float distance)
        {
            Count++;
            TotalLenght += distance;
            Shortest = Math.Min(Shortest, distance);
            Longest = Math.Max(Longest, distance);
        }
    }
}
