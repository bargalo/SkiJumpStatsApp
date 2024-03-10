namespace SkiStatsApp
{
    public abstract class JumperBase : IJumper
    {
        public delegate void JumpLenghtDelegate(object sender, EventArgs args);

        public abstract event JumpLenghtDelegate JumpAdded;
        public JumperBase(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddDistance(float distance);

        public virtual void AddDistance(string distance)
        {
            if (float.TryParse(distance, out float result))
            {
                AddDistance(result);
            }
            else
            {
                throw new Exception("Wrong data!");
            }
        }

        public virtual void AddDistance(int distance)
        {
            AddDistance((float)distance);
        }

        public abstract Statistics GetStatistics();       
    }
}
