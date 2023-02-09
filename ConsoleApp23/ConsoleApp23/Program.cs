using ConsoleApp23;

Employee employee1 = new Employee("Joanna", "Kowal", 45);
Employee employee2 = new Employee("Anna", "Warzecha", 34);
Employee employee3 = new Employee("Mariusz", "Wąs", 29);

employee1.AddGrade(3);
//employee1.AddGrade(5);
//employee1.AddGrade(9);
employee1.AddGrade(4);
employee1.AddGrade(6);

var statistics  = employee1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2} Max: {statistics.Max} Min: {statistics.Min}");


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


