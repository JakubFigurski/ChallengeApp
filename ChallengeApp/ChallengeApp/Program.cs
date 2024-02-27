using ChallengeApp;

var employee1 = new Employee("Kuba", "Figurski", 27);
employee1.AddGrade(2);
employee1.AddGrade(2);
employee1.AddGrade(4);
employee1.AddGrade(3);
employee1.AddGrade(4);
var statistics1 = employee1.GetStatistics();
Console.WriteLine($"Pracownik {employee1.Name} {employee1.Surname} wiek {employee1.Age} ma punktów: ");
Console.WriteLine($"Avarange:   {statistics1.Avarange:N2}");
Console.WriteLine($"Min:   {statistics1.Min}");
Console.WriteLine($"Max:   {statistics1.Max}");



var employee2 = new Employee("Kamil", "Figurski", 28);
employee2.AddGrade(5);
employee2.AddGrade(2);
employee2.AddGrade(1);
employee2.AddGrade(4);
employee2.AddGrade(3);
var statistics2 = employee2.GetStatistics();    
Console.WriteLine($"Pracownik {employee2.Name} {employee2.Surname} wiek {employee2.Age} ma punktów: ");
Console.WriteLine($"Avarange:   {statistics2.Avarange:N2}");
Console.WriteLine($"Min:   {statistics2.Min}");
Console.WriteLine($"Max:   {statistics2.Max}");



var employee3 = new Employee("Ola", "Figurska", 28);
employee3.AddGrade(100);
employee3.AddGrade(2);
employee3.AddGrade(1);
employee3.AddGrade(4);
employee3.AddGrade(3);
var statistics3 = employee3.GetStatistics();
Console.WriteLine($"Pracownik {employee3.Name} {employee3.Surname} wiek {employee3.Age} ma punktów: ");
Console.WriteLine($"Avarange:   {statistics3.Avarange:N2}");
Console.WriteLine($"Min:   {statistics3.Min}");
Console.WriteLine($"Max:   {statistics3.Max}");


