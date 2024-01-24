using challange_app;
Console.WriteLine("Witamy w programie XYZ do oceny pracowników");
Console.WriteLine("==============================================");
Console.WriteLine();
Console.WriteLine("Wpisz Q lub q by zakończyć dodawanie ocen");
Console.WriteLine();

var employee = new Employee("Tomasz", "Misiak", "M");
var supervisor = new Supervisor("Marian", "Pyzdra", "M");

while (true)
{
    Console.WriteLine("Podaj ocenę pracownika.");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);

    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched    {e.Message}");
    }
}

while (true)
{
    Console.WriteLine("Podaj ocenę kierownika.");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {

        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched    {e.Message}");
    }
}


var statistics = employee.GetStatistics();


var statistics1 = supervisor.GetStatistics();


Console.WriteLine("Dane pracownika");
Console.WriteLine($"Average  {statistics.Average}");
Console.WriteLine($"Min   {statistics.Min}");
Console.WriteLine($"Max   {statistics.Max}");
Console.WriteLine($"Average Letter   {statistics.AverageLetter}");

Console.WriteLine("Dane Kierownika");
Console.WriteLine($"Average  {statistics1.Average}");
Console.WriteLine($"Min   {statistics1.Min}");
Console.WriteLine($"Max   {statistics1.Max}");
Console.WriteLine($"Average Letter   {statistics1.AverageLetter}");