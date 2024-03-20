namespace SkiStatsApp
{
    public abstract class JumperBase : IJumper
    {
        public delegate void JumpLenghtDelegate(object sender, EventArgs args);
        private static List<Statistics> jumperStatsToList = new List<Statistics>();

        public abstract event JumpLenghtDelegate JumpAdded;
        public JumperBase(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddDistance(float distance);

        public void AddDistance(string distance)
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

        public void AddDistance(int distance)
        {
            AddDistance((float)distance);
        }

        public abstract Statistics GetStatistics();
        
        public void ShowStatistics()
        {            
            foreach (var stats in jumperStatsToList)
            {
                Console.WriteLine();
                Console.WriteLine("========== STATYSTYKI SKOCZKA: ==========");
                Console.WriteLine("==========================================");
                Console.WriteLine();
                Console.WriteLine($"====== {stats.Name + " " + stats.Surname} ======");
                Console.WriteLine($"====== Średnia długość skoku: {stats.Average:N2}m");
                Console.WriteLine($"====== Najdłuższy skok: {stats.Longest}m");
                Console.WriteLine($"====== Najkrótszy skok: {stats.Shortest}m");
                Console.WriteLine($"====== Całkowita odległość pokonana w powietrzu: {stats.TotalLenght}m");
                Console.WriteLine($"====== Całkowita liczba oddanych skoków: {stats.Count} skoków");
                Console.WriteLine($"====== Końcowa ocena skoczka: Poziom - {stats.JumperLevel}");
                Console.WriteLine();
                Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine();
            }

        }
        public void AddStatistics()
        {            
            Statistics statistics = GetStatistics();
            statistics.Name = Name;
            statistics.Surname = Surname;
            jumperStatsToList.Add(statistics);
        }
    }
}
