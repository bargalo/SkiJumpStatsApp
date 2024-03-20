namespace SkiStatsApp
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("======= WITAMY W PROGRAMIE DO PROWADZENIA STATYSTYK NAJLEPSZYCH SKOCZKÓW NARCIARSKICH w HISTORII TEGO SPORTU =======");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();
            Console.WriteLine("============================= PROSZĘ STOSOWAĆ SIĘ DO POLECEŃ WYŚWIETLANYCH NA EKRANIE ==============================");
            Console.WriteLine();
            Console.WriteLine("============================ NASZ PROGRAM CHARAKTERYZUJE SIĘ WYGODĄ I PROSTOTĄ OBSŁUGI =============================");
            Console.WriteLine();
            Console.WriteLine("============================================ ŻYCZYMY UDANEJ ZABAWY!!! ==============================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Wybierz klawisz 'f' aby zapisać wyniki do pliku lub 'm' aby zapisać w pamięci programu.");

            while (true)
            {
                var input = Console.ReadLine();
                while (input != "f" && input != "m")
                {
                    Console.WriteLine("Wrong button!");
                    input = Console.ReadLine();
                    continue;
                }
                switch (input)
                {
                    case "f":
                        AddDataAndDistance(true);
                        break;
                    case "m":
                        AddDataAndDistance(false);
                        break;
                }
                break;
            }

            static void AddDataAndDistance(bool isInFile)
            {
                while (true)
                {
                    string jumperName = GetJumperData("Podaj imię skoczka:...");
                    string jumperSurname = GetJumperData("Podaj nazwisko skoczka:...");
                    JumperBase jumperData = isInFile ? 
                        new JumperInFile(jumperName, jumperSurname) : 
                        new JumperInMemory(jumperName, jumperSurname);                   
                    AddDistanceToJumper(jumperData);
                    jumperData.AddStatistics();
                    Console.WriteLine("=== Aby wyświetlić aktualne statystyki wpisz 'stats' bądź wybierz dowolny klawisz aby przejść do kolejnego skoczka!");
                    var input = Console.ReadLine();
                    if (input == "stats")
                    {                        
                        jumperData.ShowStatistics();
                        break;
                    }
                    else if (input != "stats")
                    {
                        continue;
                    }
                }
            }
           
            static string GetJumperData(string comment)
            {
                Console.WriteLine(comment);
                string userInput = Console.ReadLine();
                while (string.IsNullOrEmpty(userInput))
                {                
                    Console.WriteLine("Nie podałeś danych skoczka...");
                    userInput = Console.ReadLine();
                }
                return userInput;
            }

            static void AddDistanceToJumper(IJumper jumper)
            {
                var counter = 1;
                while (true)
                {
                    if (counter > 0 && counter < 2)
                    {
                        Console.WriteLine($"===Podaj na jaką odległość oddał skok {jumper.Name + " " + jumper.Surname} ...(m)");
                    }
                    jumper.JumpAdded += JumperDistanceAdded;
                    void JumperDistanceAdded(object sender, EventArgs args)
                    {
                        Console.WriteLine("===Dodano skok do statystyk!");
                    }
                    var input = Console.ReadLine();

                    if (input == "q")
                    {
                        counter = 1;
                        jumper.JumpAdded -= JumperDistanceAdded;
                        break;
                    }
                    try
                    {
                        jumper.AddDistance(input);
                        jumper.JumpAdded -= JumperDistanceAdded;
                        counter++;
                    }
                    catch (Exception e)
                    {
                        counter++;
                        jumper.JumpAdded -= JumperDistanceAdded;
                        Console.WriteLine(e.Message);
                    }
                    Console.WriteLine($"===Aby zakończyć dodawanie wartości temu zawodnikowi wybierz 'q'... lub dodaj kolejny wynik skoku {jumper.Name + " " + jumper.Surname} ...(m)");
                }
            }            
        }
    }
}






