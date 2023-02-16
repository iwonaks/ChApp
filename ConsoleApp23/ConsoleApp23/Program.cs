using ConsoleApp23;

var employee = new EmployeeInFile();
//employee.AddGrade(70);
//employee.AddGrade(80);
//employee.AddGrade(10);
var supervisor = new Supervisor();

Console.WriteLine("Aby podać ocenę dla pracownika wciśnij 1\nAby podać ocenę dla supervisora wciśnij 2\nAby zakończyć q");

string input = Console.ReadLine().ToUpper();

switch (input)
{
    case "1":
        while (true)
        {
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
        }
        break;

    case "2":

        while (true)
        {
            Console.WriteLine("Podaj ocenę supervisora  (od 1 do 6, akceptowalne znaki +/-ocena), aby zakończyć i zobaczyć statystyki wciśnij 'q'");

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

