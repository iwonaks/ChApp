using ConsoleApp23;

var employee = new Employee();
//employee.AddGrade(70);
//employee.AddGrade(80);
//employee.AddGrade(10);

while (true)
{
    Console.WriteLine("Podaj oceny dla pracownika, aby zakończyć i zobaczyć statystyki wciśnij 'q'");
    Console.WriteLine("...........................");
    string input = Console.ReadLine();
    if (input=="q" || input =="Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Kontynuujemy");
    }
}
var statistics = employee.GetStatistics();

Console.WriteLine($"Najniższa ocena: {statistics.Min},\nnajwyższa: {statistics.Max},\nŚrednia ocen: {statistics.Average:N2}, co daje ocenę końcową: {statistics.AverageLetter}");