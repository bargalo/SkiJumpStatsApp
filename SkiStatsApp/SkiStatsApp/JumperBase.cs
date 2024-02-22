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

        public abstract void AddDistance(string distance);

        public abstract void AddDistance(int distance); 

        public abstract Statistics GetStatistics();
    }
}
