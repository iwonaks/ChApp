using ConsoleApp23;

Employee employee1 = new Employee("Joanna", "Kowal", 45);
Employee employee2 = new Employee("Anna", "Warzecha", 34);
Employee employee3 = new Employee("Mariusz", "Wąs", 29);

List<Employee> employees = new List<Employee>();

employee1.AddJobEvaluation(5);
employee1.AddJobEvaluation(5);
employee1.AddJobEvaluation(9);
employee1.AddJobEvaluation(4);
employee1.AddJobEvaluation(6);
employees.Add(employee1);


employee2.AddJobEvaluation(7);
employee2.AddJobEvaluation(2);
employee2.AddJobEvaluation(9);
employee2.AddJobEvaluation(9);
employee2.AddJobEvaluation(8);
employees.Add(employee2);

employee3.AddJobEvaluation(8);
employee3.AddJobEvaluation(3); 
employee3.AddJobEvaluation(8);
employee3.AddJobEvaluation(2);
employee3.AddJobEvaluation(1);
employees.Add(employee3);

int result1 = employee1.Result2;
int result2 = employee2.Result2;
int result3 = employee3.Result2;

int maxResult = -1;
Employee employeeWithBestEvaluation = null;

foreach (var employee in employees)
{
    if (employee.Result2>maxResult)
    {
        maxResult = employee.Result2;
        employeeWithBestEvaluation= employee;
    }
}
Console.WriteLine($"Osoba z najwyższą ilością punktów: {employeeWithBestEvaluation.Name} {employeeWithBestEvaluation.Surname}, otrzymała {employeeWithBestEvaluation.Result2} punktów");

