using SkiStatsApp;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

var counter1 = 1;

Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");
Console.WriteLine("====== WITAMY W PROGRAMIE DO PROWADZENIA STATYSTYK 5 NAJLEPSZYCH SKOCZKÓW NARCIARSKICH w HISTORII TEGO SPORTU ======");
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
var input = Console.ReadLine();

while (input != "f" && input != "m")
{
    Console.WriteLine("Wrong button!");
    input = Console.ReadLine();
    continue;
}
if (input == "f")
{
    while (true)
    {
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
else if (input == "m")
{
    while (true)
    {
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