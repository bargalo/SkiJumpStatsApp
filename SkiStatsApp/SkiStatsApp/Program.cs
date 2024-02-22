using SkiStatsApp;
using static System.Runtime.InteropServices.JavaScript.JSType;

var janeAhonen = new JumperJAhonen("Jane", "Ahonen");
var kamilStoch = new JumperKStoch("Kamil", "Stoch");
var piotrŻyła = new JumperPŻyła("Piotr", "Żyła");
var noriakiKasai = new JumperNKasai("Noriaki", "Kasai");
var adamMałysz = new JumperAMałysz("Adam", "Małysz");

var counter1 = 1;
var counter2 = 1;
var counter3 = 1;
var counter4 = 1;
var counter5 = 1;

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

while (true)
{
    while (true)
    {
        if (counter1 > 0 && counter1 < 2)
        {
            Console.WriteLine("===Podaj na jaką odległość oddał skok Jane Ahonen ...(m)");
        }
        janeAhonen.JumpAdded += JumperDistanceAdded;
        void JumperDistanceAdded(object sender, EventArgs args)
        {
            Console.WriteLine("===Dodano skok do statystyk!");
        }
        var input = Console.ReadLine();
        if (input == "q")
        {
            counter1 = 1;
            janeAhonen.JumpAdded -= JumperDistanceAdded;
            break;
        }
        try
        {
            janeAhonen.AddDistance(input);
            janeAhonen.JumpAdded -= JumperDistanceAdded;
            counter1++;
        }
        catch (Exception e)
        {
            counter1++;
            janeAhonen.JumpAdded -= JumperDistanceAdded;
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("===Aby zakończyć dodawanie wartości temu zawodnikowi wybierz 'q'... lub dodaj kolejny wynik skoku Jane Ahonen'a ...(m)");
    }
    Console.WriteLine("===Aby wyświetlić aktualne statystyki wpisz 'stats' bądź wybierz dowolny klawisz aby przejść do kolejnego skoczka!");
    var endInput = Console.ReadLine();

    if (endInput == "stats")
    {
        break;
    }
    else if (endInput != "stats")
    {
        Console.WriteLine("NASTĘPNY SKOCZEK!");
    }

    while (true)
    {

        if (counter2 > 0 && counter2 < 2)
        {
            Console.WriteLine("===Podaj na jaką odległość oddał skok Kamil Stoch ...(m)");
        }
        kamilStoch.JumpAdded += JumperDistanceAdded;
        void JumperDistanceAdded(object sender, EventArgs args)
        {
            Console.WriteLine("===Dodano skok do statystyk!");
        }
        var input = Console.ReadLine();
        if (input == "q")
        {
            counter2 = 1;
            kamilStoch.JumpAdded -= JumperDistanceAdded;
            break;
        }
        try
        {
            kamilStoch.AddDistance(input);
            kamilStoch.JumpAdded -= JumperDistanceAdded;
            counter2++;
        }
        catch (Exception e)
        {
            counter2++;
            kamilStoch.JumpAdded -= JumperDistanceAdded;
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("===Aby zakończyć dodawanie wartości temu zawodnikowi wybierz 'q'... lub dodaj kolejny wynik skoku Kamila Stocha ...(m)");
    }
    Console.WriteLine("===Aby wyświetlić aktualne statystyki wpisz 'stats' bądź wybierz dowolny klawisz aby przejść do kolejnego skoczka!");
    var endInput1 = Console.ReadLine();

    if (endInput1 == "stats")
    {
        break;
    }
    else if (endInput1 != "stats")
    {
        Console.WriteLine("NASTĘPNY SKOCZEK!");
    }

    while (true)
    {

        if (counter3 > 0 && counter3 < 2)
        {
            Console.WriteLine("===Podaj na jaką odległość oddał skok Piotr Żyła ...(m)");
        }
        piotrŻyła.JumpAdded += JumperDistanceAdded;
        void JumperDistanceAdded(object sender, EventArgs args)
        {
            Console.WriteLine("===Dodano skok do statystyk!");
        }
        var input = Console.ReadLine();
        if (input == "q")
        {
            counter3 = 1;
            piotrŻyła.JumpAdded -= JumperDistanceAdded;
            break;
        }
        try
        {
            piotrŻyła.AddDistance(input);
            piotrŻyła.JumpAdded -= JumperDistanceAdded;
            counter3++;
        }
        catch (Exception e)
        {
            counter3++;
            piotrŻyła.JumpAdded -= JumperDistanceAdded;
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("===Aby zakończyć dodawanie wartości temu zawodnikowi wybierz 'q'... lub dodaj kolejny wynik skoku Piotra Żyły ...(m)");
    }
    Console.WriteLine("===Aby wyświetlić aktualne statystyki wpisz 'stats' bądź wybierz dowolny klawisz aby przejść do kolejnego skoczka!");
    var endInput2 = Console.ReadLine();

    if (endInput2 == "stats")
    {
        break;
    }
    else if (endInput2 != "stats")
    {
        Console.WriteLine("NASTĘPNY SKOCZEK!");
    }

    while (true)
    {

        if (counter4 > 0 && counter4 < 2)
        {
            Console.WriteLine("===Podaj na jaką odległość oddał skok Noriaki Kasai ...(m)");
        }
        noriakiKasai.JumpAdded += JumperDistanceAdded;
        void JumperDistanceAdded(object sender, EventArgs args)
        {
            Console.WriteLine("===Dodano skok do statystyk!");
        }
        var input = Console.ReadLine();
        if (input == "q")
        {
            counter4 = 1;
            noriakiKasai.JumpAdded -= JumperDistanceAdded;
            break;
        }
        try
        {
            noriakiKasai.AddDistance(input);
            noriakiKasai.JumpAdded -= JumperDistanceAdded;
            counter4++;
        }
        catch (Exception e)
        {
            counter4++;
            noriakiKasai.JumpAdded -= JumperDistanceAdded;
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("===Aby zakończyć dodawanie wartości temu zawodnikowi wybierz 'q'... lub dodaj kolejny wynik skoku Noriaki Kasai'ego...(m)");
    }
    Console.WriteLine("===Aby wyświetlić aktualne statystyki wpisz 'stats' bądź wybierz dowolny klawisz aby przejść do kolejnego skoczka!");
    var endInput3 = Console.ReadLine();

    if (endInput3 == "stats")
    {
        break;
    }
    else if (endInput3 != "stats")
    {
        Console.WriteLine("NASTĘPNY SKOCZEK!");
    }

    while (true)
    {

        if (counter5 > 0 && counter5 < 2)
        {
            Console.WriteLine("===Podaj na jaką odległość oddał skok Adam Małysz ...(m)");
        }
        adamMałysz.JumpAdded += JumperDistanceAdded;
        void JumperDistanceAdded(object sender, EventArgs args)
        {
            Console.WriteLine("===Dodano skok do statystyk!");
        }
        var input = Console.ReadLine();
        if (input == "q")
        {
            counter5 = 1;
            adamMałysz.JumpAdded -= JumperDistanceAdded;
            break;
        }
        try
        {
            adamMałysz.AddDistance(input);
            adamMałysz.JumpAdded -= JumperDistanceAdded;
            counter5++;
        }
        catch (Exception e)
        {
            counter5++;
            adamMałysz.JumpAdded -= JumperDistanceAdded;
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("===Przejdz do kolejnego zawodnika wybierając 'q'...lub dodaj wynik kolejnego skoku Adama Małysza");
    }
    Console.WriteLine("===Aby wyświetlić aktualne statystyki wpisz 'stats' bądź wybierz dowolny klawisz aby przejść do kolejnego skoczka!");
    var endInput4 = Console.ReadLine();

    if (endInput4 == "stats")
    {
        break;
    }
    else if (endInput4 != "stats")
    {
        Console.WriteLine("NASTĘPNY SKOCZEK!");
    }
}

Console.WriteLine();
Console.WriteLine("========== STATYSTYKI SKOCZKÓW: ==========");
Console.WriteLine("==========================================");

var stats1 = janeAhonen.GetStatistics();
Console.WriteLine();
Console.WriteLine("====== JANE AHONEN ======");
Console.WriteLine($"====== Średnia długość skoku: {stats1.Average:N2}m");
Console.WriteLine($"====== Najdłuższy skok: {stats1.Longest}m");
Console.WriteLine($"====== Najkrótszy skok: {stats1.Shortest}m");
Console.WriteLine($"====== Całkowita odległość pokonana w powietrzu: {stats1.TotalLenght}m");
Console.WriteLine($"====== Całkowita liczba oddanych skoków: {stats1.Count} skoków");
Console.WriteLine($"====== Końcowa ocena skoczka: Poziom - {stats1.JumperLevel}");
Console.WriteLine();
Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
Console.WriteLine();

var stats2 = kamilStoch.GetStatistics();
Console.WriteLine();
Console.WriteLine("====== KAMIL STOCH ======");
Console.WriteLine($"====== Średnia długość skoku: {stats2.Average:N2}m");
Console.WriteLine($"====== Najdłuższy skok: {stats2.Longest}m");
Console.WriteLine($"====== Najkrótszy skok: {stats2.Shortest}m");
Console.WriteLine($"====== Całkowita odległość pokonana w powietrzu: {stats2.TotalLenght}m");
Console.WriteLine($"====== Całkowita liczba oddanych skoków: {stats2.Count} skoków");
Console.WriteLine($"====== Końcowa ocena skoczka: Poziom - {stats2.JumperLevel}");
Console.WriteLine();
Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
Console.WriteLine();

var stats3 = piotrŻyła.GetStatistics();
Console.WriteLine();
Console.WriteLine("====== PIOTR ŻYŁA ======");
Console.WriteLine($"====== Średnia długość skoku: {stats3.Average:N2}m");
Console.WriteLine($"====== Najdłuższy skok: {stats3.Longest}m");
Console.WriteLine($"====== Najkrótszy skok: {stats3.Shortest}m");
Console.WriteLine($"====== Całkowita odległość pokonana w powietrzu: {stats3.TotalLenght}m");
Console.WriteLine($"====== Całkowita liczba oddanych skoków: {stats3.Count} skoków");
Console.WriteLine($"====== Końcowa ocena skoczka: Poziom - {stats3.JumperLevel}");
Console.WriteLine();
Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
Console.WriteLine();

var stats4 = noriakiKasai.GetStatistics();
Console.WriteLine();
Console.WriteLine("====== NORIAKI KASAI ======");
Console.WriteLine($"====== Średnia długość skoku: {stats4.Average:N2}m");
Console.WriteLine($"====== Najdłuższy skok: {stats4.Longest}m");
Console.WriteLine($"====== Najkrótszy skok: {stats4.Shortest}m");
Console.WriteLine($"====== Całkowita odległość pokonana w powietrzu: {stats4.TotalLenght}m");
Console.WriteLine($"====== Całkowita liczba oddanych skoków: {stats4.Count} skoków");
Console.WriteLine($"====== Końcowa ocena skoczka: Poziom - {stats4.JumperLevel}");
Console.WriteLine();
Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
Console.WriteLine();

var stats5 = adamMałysz.GetStatistics();
Console.WriteLine();
Console.WriteLine("====== ADAM MAŁYSZ ======");
Console.WriteLine($"====== Średnia długość skoku: {stats5.Average:N2}m");
Console.WriteLine($"====== Najdłuższy skok: {stats5.Longest}m");
Console.WriteLine($"====== Najkrótszy skok: {stats5.Shortest}m");
Console.WriteLine($"====== Całkowita odległość pokonana w powietrzu: {stats5.TotalLenght}m");
Console.WriteLine($"====== Całkowita liczba oddanych skoków: {stats5.Count} skoków");
Console.WriteLine($"====== Końcowa ocena skoczka: Poziom - {stats5.JumperLevel}");
Console.WriteLine();
Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
Console.WriteLine();

float[] bestAverageStats = { stats1.Average, stats2.Average, stats3.Average, stats4.Average, stats5.Average };
float maxAverage = bestAverageStats[0];

foreach (var stats in bestAverageStats)
{
    if (stats > maxAverage)
    {
        maxAverage = stats;
    }
}

for (int i = 0; i < bestAverageStats.Length; i++)
{
    if (maxAverage == bestAverageStats[i])
    {
        var number = i;
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine($"====== Najlepszą średnia długość skoku uzyskał Jane Ahonen!: {maxAverage:N2}m");
                    break;
                case 1:
                    Console.WriteLine($"====== Najlepszą średnia długość skoku uzyskał Kamil Stoch!: {maxAverage:N2}m");
                    break;
                case 2:
                    Console.WriteLine($"====== Najlepszą średnia długość skoku uzyskał Piotr Żyła!: {maxAverage:N2}m");
                    break;
                case 3:
                    Console.WriteLine($"====== Najlepszą średnia długość skoku uzyskał Noriaki Kasai!: {maxAverage:N2}m");
                    break;
                case 4:
                    Console.WriteLine($"====== Najlepszą średnia długość skoku uzyskał Adam Małysz!: {maxAverage:N2}m");
                    break;
            }
        }
    }
}

float[] bestLongestStats = { stats1.Longest, stats2.Longest, stats3.Longest, stats4.Longest, stats5.Longest };
float maxLongest = bestLongestStats[0];

foreach (var stats in bestLongestStats)
{
    if (stats > maxLongest)
    {
        maxLongest = stats;
    }
}

for (int i = 0; i < bestLongestStats.Length; i++)
{
    if (maxLongest == bestLongestStats[i])
    {
        var number = i;
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine($"====== Najdłuższy skok w sezonie oddał Jane Ahonen!: {maxLongest}m");
                    break;
                case 1:
                    Console.WriteLine($"====== Najdłuższy skok w sezonie oddał Kamil Stoch!: {maxLongest}m");
                    break;
                case 2:
                    Console.WriteLine($"====== Najdłuższy skok w sezonie oddał Piotr Żyła!: {maxLongest}m");
                    break;
                case 3:
                    Console.WriteLine($"====== Najdłuższy skok w sezonie oddał Noriaki Kasai!: {maxLongest}m");
                    break;
                case 4:
                    Console.WriteLine($"====== Najdłuższy skok w sezonie oddał Adam Małysz!: {maxLongest}m");
                    break;
            }
        }
    }
}

float[] lowestShortestStats = { stats1.Shortest, stats2.Shortest, stats3.Shortest, stats4.Shortest, stats5.Shortest };
float minShortest = lowestShortestStats[0];

foreach (var stats in lowestShortestStats)
{
    if (stats < minShortest)
    {
        minShortest = stats;
    }
}

for (int i = 0; i < lowestShortestStats.Length; i++)
{
    if (minShortest == lowestShortestStats[i])
    {
        var number = i;
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine($"====== Najkrótszy skok w sezonie oddał Jane Ahonen!: {minShortest}m");
                    break;
                case 1:
                    Console.WriteLine($"====== Najkrótszy skok w sezonie oddał Kamil Stoch!: {minShortest}m");
                    break;
                case 2:
                    Console.WriteLine($"====== Najkrótszy skok w sezonie oddał Piotr Żyła!: {minShortest}m");
                    break;
                case 3:
                    Console.WriteLine($"====== Najkrótszy skok w sezonie oddał Noriaki Kasai!: {minShortest}m");
                    break;
                case 4:
                    Console.WriteLine($"====== Najkrótszy skok w sezonie oddał Adam Małysz!: {minShortest}m");
                    break;
            }
        }
    }
}