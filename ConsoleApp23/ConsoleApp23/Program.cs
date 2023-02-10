using ConsoleApp23;

Employee employee1 = new Employee("Joanna", "Kowal", 45);
Employee employee2 = new Employee("Anna", "Warzecha", 34);
Employee employee3 = new Employee("Mariusz", "Wąs", 29);

employee1.AddGrade(3.3566666);
employee1.AddGrade("8");
employee1.AddGrade("7");
employee1.AddGrade(4);
employee1.AddGrade(6);

var statisticsWithForeach = employee1.GetStatisticsWithForeach();
Console.WriteLine($"Average: {statisticsWithForeach.Average:N2} Max: {statisticsWithForeach.Max:N2} Min: {statisticsWithForeach.Min:N2}");

var statisticsWithFor = employee1.GetStatisticsWithFor();
Console.WriteLine($"Average: {statisticsWithFor.Average:N2}  Max:  {statisticsWithFor.Max:N2} Min: {statisticsWithFor.Min:N2}");

var statisticsWithDoWhile = employee1.GetStatisticsWithDoWhile();
Console.WriteLine($"Average: {statisticsWithDoWhile.Average:N2} Max: {statisticsWithDoWhile.Max:N2} Min: {statisticsWithDoWhile.Min:N2}");

var statisticsWithWhile = employee1.GetStatisticsWithForeach();
Console.WriteLine($"Average: {statisticsWithWhile.Average:N2} Max: {statisticsWithWhile.Max:N2} Min: {statisticsWithWhile.Min:N2}");

employee2.AddGrade(7);
employee2.AddGrade(2);
employee2.AddGrade(9);
employee2.AddGrade(9);
employee2.AddGrade(8);

employee3.AddGrade(8);
employee3.AddGrade(3);
employee3.AddGrade(8);
employee3.AddGrade(2);
employee3.AddGrade(1);