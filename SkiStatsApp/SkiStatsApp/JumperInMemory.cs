namespace SkiStatsApp
{
    public class JumperInMemory : JumperBase 
    {
        public override event JumpLenghtDelegate JumpAdded;
        private List<float> distances = new List<float>();       

        public JumperInMemory(string name, string surname)
            : base(name, surname)
        {
     
        }

        public override void AddDistance(float distance)
        {
            if (distance >= 0 && distance <= 180)
            {
                distances.Add(distance);

                if (JumpAdded != null)
                {
                    JumpAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Wrong data!");
            }
        }

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();

            foreach (var distance in distances)
            {
                stats.AddDistance(distance);
            }
            return stats;
        }                     
    }
}

