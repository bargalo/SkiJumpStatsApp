using SkiStatsApp;

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
    JumperInFile jumperDataInFile = new("-", "-");
    jumperDataInFile.AddJumperDataAndDistanceToFile();
}
else if (input == "m")
{
    JumperInMemory jumperDataInMemory = new("-", "-");
    jumperDataInMemory.AddJumperDataAndDistanceToMemory();
}





