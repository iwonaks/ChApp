using ConsoleApp23;

//var employee = new EmployeeInMemory();
var employee = new EmployeeInFile();
var supervisor = new Supervisor();

employee.GradeAddedToStatistics+=EmployeeGradeAdded;
employee.GradeSaveToFile+= EmployeeGradeSaveToFile;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano ocenę");
}

void EmployeeGradeSaveToFile(object sender, EventArgs args)
{
    Console.WriteLine("Zapisano ocenę w pliku");
}


Console.WriteLine("Aby podać ocenę dla pracownika wybierz P\nAby podać ocenę dla supervisora wybierz S\nAby zakończyć Q\nPo dodaniu oceny klawisz V podaje statystyki dla danej grupy");
Console.WriteLine("======================================================================================");
while (true)
{
    Console.WriteLine("Ocena pracownika wybierz P\nOcena supervisora wybierz  S\n");
    string input = Console.ReadLine().ToUpper();

    switch (input)
    {
        case "P":

            Console.WriteLine("Podaj ocenę pracownika, Aby zobaczyć statystyki wciśnij V");
            var inputEmployee = Console.ReadLine().ToUpper();

            if (inputEmployee != "Q" && inputEmployee !="V")
            {
                try
                {
                    employee.AddGrade(inputEmployee);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"We catched exception {ex.Message}");
                }
            }
            else if (inputEmployee == "V")
            {
                var statisticsEmployee = employee.GetStatistics();

                Console.WriteLine($"Najniższa ocena: {statisticsEmployee.Min},\nnajwyższa: {statisticsEmployee.Max},\nŚrednia ocen: {statisticsEmployee.Average:N2}");

                if (statisticsEmployee.Max>=30)
                {
                    Console.WriteLine($"Ocena końcowa: {statisticsEmployee.AverageLetter}");
                }
            }
            else
            {
                System.Environment.Exit(0);
            }

            break;

        case "S":

            while (true)
            {
                Console.WriteLine("Podaj ocenę supervisora  (od 1 do 6, akceptowalne znaki +/-ocena)");

                var inputSupervisor = Console.ReadLine().ToUpper();

                if (inputSupervisor != "Q" && inputSupervisor !="V")
                {
                    try
                    {
                        supervisor.AddGrade(inputSupervisor);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"We catched exception {ex.Message}");
                    }
                }
                else if (inputSupervisor == "V")
                {
                    var statisticsSupervisor = supervisor.GetStatistics();
                    Console.WriteLine($"Najniższa ocena: {statisticsSupervisor.Min},\nnajwyższa: {statisticsSupervisor.Max},\nŚrednia ocen: {statisticsSupervisor.Average:N2}");
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            break;

        case "Q":
            System.Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Wprowadź właściwy klawisz");
            break;
    }
}