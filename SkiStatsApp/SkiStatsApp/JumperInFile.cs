namespace SkiStatsApp
{
    public class JumperInFile : JumperBase
    {
        public override event JumpLenghtDelegate JumpAdded;
        
        public JumperInFile(string name, string surname)
           : base(name, surname)
        {
            FileName = name + surname + ".txt";           
        }
        public string FileName { get; private set; }
        
        public override void AddDistance(float distance)
        {
            if (distance >= 0 && distance <= 180)
            {
                using (var writer = File.AppendText(FileName))
                {
                    writer.WriteLine(distance);
                }
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
        public override void AddDistance(string distance)
        {
            base.AddDistance(distance);
        }

        public override void AddDistance(int distance)
        {
            base.AddDistance(distance);
        }

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();

            if (File.Exists(FileName))
            {
                using (var reader = File.OpenText(FileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        stats.AddDistance(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return stats;
        } 
        public void AddJumperDataAndDistanceToFile()
        {
            while (true)
            {
                var counter1 = 1;
                Console.WriteLine("Podaj imię skoczka:...");
                var jumperName = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko skoczka:...");
                var jumperSurname = Console.ReadLine();
                var jumperInFile = new JumperInFile(jumperName, jumperSurname);

                while (true)
                {           
                    if (counter1 > 0 && counter1 < 2)
                    {
                        Console.WriteLine($"===Podaj na jaką odległość oddał skok {jumperName + " " + jumperSurname} ...(m)");
                    }
                    jumperInFile.JumpAdded += JumperDistanceAdded;
                    void JumperDistanceAdded(object sender, EventArgs args)
                    {
                        Console.WriteLine("===Dodano skok do statystyk!");
                    }
                    var userInput = Console.ReadLine();
                    if (userInput == "q")
                    {
                        counter1 = 1;
                        jumperInFile.JumpAdded -= JumperDistanceAdded;
                        break;
                    }
                    try
                    {
                        jumperInFile.AddDistance(userInput);
                        jumperInFile.JumpAdded -= JumperDistanceAdded;
                        counter1++;
                    }
                    catch (Exception e)
                    {
                        counter1++;
                        jumperInFile.JumpAdded -= JumperDistanceAdded;
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

                    var stats = jumperInFile.GetStatistics();
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
