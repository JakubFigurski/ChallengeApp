using ChallengeApp;

var employee1 = new Employee("Kuba", "Figurski", 27);
employee1.AddGrade(2);
employee1.AddGrade("500");
employee1.AddGrade("ddd");
employee1.AddGrade(25.25);
employee1.AddGrade(-142);
employee1.AddGrade(412312312);
var statistics1 = employee1.GetStatistics();
Console.WriteLine($"Pracownik {employee1.Name} {employee1.Surname} wiek {employee1.Age} ma punktów: ");
Console.WriteLine($"Avarange:   {statistics1.Avarange:N2}");
Console.WriteLine($"Min:   {statistics1.Min}");
Console.WriteLine($"Max:   {statistics1.Max}");






