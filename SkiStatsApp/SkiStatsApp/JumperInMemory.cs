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
        public override void AddDistance(int distance)
        {
            base.AddDistance(distance);
        }

        public override void AddDistance(string distance)
        {   
            base.AddDistance(distance);
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
        public void AddJumperDataAndDistanceToMemory()
        {
            while (true)
            {
                var counter1 = 1;
                Console.WriteLine("Podaj imię skoczka:...");
                var jumperName = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko skoczka:...");
                var jumperSurname = Console.ReadLine();
                var jumperInMemory = new JumperInMemory(jumperName, jumperSurname);

                while (true)
                {
                    if (counter1 > 0 && counter1 < 2)
                    {
                        Console.WriteLine($"===Podaj na jaką odległość oddał skok {jumperName + " " + jumperSurname} ...(m)");
                    }
                    jumperInMemory.JumpAdded += JumperDistanceAdded;
                    void JumperDistanceAdded(object sender, EventArgs args)
                    {
                        Console.WriteLine("===Dodano skok do statystyk!");
                    }
                    var userInput = Console.ReadLine();
                    if (userInput == "q")
                    {
                        counter1 = 1;
                        jumperInMemory.JumpAdded -= JumperDistanceAdded;
                        break;
                    }
                    try
                    {
                        jumperInMemory.AddDistance(userInput);
                        jumperInMemory.JumpAdded -= JumperDistanceAdded;
                        counter1++;
                    }
                    catch (Exception e)
                    {
                        counter1++;
                        jumperInMemory.JumpAdded -= JumperDistanceAdded;
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine($"===Aby zakończyć dodawanie wartości temu zawodnikowi wybierz 'q'... lub dodaj kolejny wynik skoku {jumperName + " " + jumperSurname} ...(m)");
                }
                Console.WriteLine("===Aby wyświetlić aktualne statystyki wpisz 'stats' bądź wybierz dowolny klawisz aby przejść do kolejnego skoczka!");
                var endInput = Console.ReadLine();

                if (endInput == "stats")
                {
                    Console.WriteLine();
                    Console.WriteLine("========== STATYSTYKI SKOCZKÓW: ==========");
                    Console.WriteLine("==========================================");
                    var stats = jumperInMemory.GetStatistics();
                    Console.WriteLine();
                    Console.WriteLine($"====== {jumperName + " " + jumperSurname} ======");
                    Console.WriteLine($"====== Średnia długość skoku: {stats.Average:N2}m");
                    Console.WriteLine($"====== Najdłuższy skok: {stats.Longest}m");
                    Console.WriteLine($"====== Najkrótszy skok: {stats.Shortest}m");
                    Console.WriteLine($"====== Całkowita odległość pokonana w powietrzu: {stats.TotalLenght}m");
                    Console.WriteLine($"====== Całkowita liczba oddanych skoków: {stats.Count} skoków");
                    Console.WriteLine($"====== Końcowa ocena skoczka: Poziom - {stats.JumperLevel}");
                    Console.WriteLine();
                    Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                    Console.WriteLine();
                    break;
                }
                else if (endInput != "stats")
                {
                    Console.WriteLine("NASTĘPNY SKOCZEK!");
                }
            }
        }
    }
}

