using ChallengeApp;

Employee employee1 = new Employee("Kuba", "Figurski", 27);
Employee employee2 = new Employee("Mateusz", "Nowak", 28);
Employee employee3 = new Employee("Daniel", "Marciniak", 29);

employee1.AddScore(5);
employee1.AddScore(3);
employee1.AddScore(7);
employee1.AddScore(12);
employee1.AddScore(1);

employee2.AddScore(5);
employee2.AddScore(9);
employee2.AddScore(0);
employee2.AddScore(2);
employee2.AddScore(1);

employee3.AddScore(4);
employee3.AddScore(3);
employee3.AddScore(2);
employee3.AddScore(8);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int MaxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.MaxResult > MaxResult)
    {
        employeeWithMaxResult = employee;
        MaxResult = employee.MaxResult;
    }
}

Console.WriteLine("Pracownik z najwyższą liczbą punktów to: " + employeeWithMaxResult.Name + " " +
    employeeWithMaxResult.Surname + " " + employeeWithMaxResult.Age + " " + " lat " + "z wynikiem " + " " + MaxResult);






