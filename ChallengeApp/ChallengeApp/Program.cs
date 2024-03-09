using ChallengeApp;

var employee1 = new Employee("Kuba", "Figurski", 27);
employee1.AddGrade(2);
employee1.AddGrade("ddd");
employee1.AddGrade(25.25);
employee1.AddGrade(-142);
employee1.AddGrade(412312312);
//var statistics1 = employee1.GetStatistics();
//Console.WriteLine($"Pracownik {employee1.Name} {employee1.Surname} wiek {employee1.Age} ma punktów: ");
//Console.WriteLine($"Avarange:   {statistics1.Avarange:N2}");
//Console.WriteLine($"Min:   {statistics1.Min}");
//Console.WriteLine($"Max:   {statistics1.Max}");



var statistics2 = employee1.GetStatisticsWithForEach();
var statistics3 = employee1.GetStatisticsWithFor();
var statistics4 = employee1.GetStatisticsWithDoWhile();
var statistics5 = employee1.GetStatisticsWithWhile();


Console.WriteLine($"FroEach");
Console.WriteLine($"Pracownik {employee1.Name} {employee1.Surname} wiek {employee1.Age} ma punktów: ");
Console.WriteLine($"Averange: {statistics2.Avarange:N2}");
Console.WriteLine($"Min: {statistics2.Min:N2}");
Console.WriteLine($"Max: {statistics2.Max:N2}");

Console.WriteLine($"For");
Console.WriteLine($"Pracownik {employee1.Name} {employee1.Surname} wiek {employee1.Age} ma punktów: ");
Console.WriteLine($"Averange: {statistics3.Avarange:N2}");
Console.WriteLine($"Min: {statistics3.Min:N2}");
Console.WriteLine($"Max: {statistics3.Max:N2}");

Console.WriteLine($"DoWhile");
Console.WriteLine($"Pracownik {employee1.Name} {employee1.Surname} wiek {employee1.Age} ma punktów: ");
Console.WriteLine($"Averange: {statistics4.Avarange:N2}");
Console.WriteLine($"Min: {statistics4.Min:N2}");
Console.WriteLine($"Max: {statistics4.Max:N2}");

Console.WriteLine($"While");
Console.WriteLine($"Pracownik {employee1.Name} {employee1.Surname} wiek {employee1.Age} ma punktów: ");
Console.WriteLine($"Averange: {statistics5.Avarange:N2}");
Console.WriteLine($"Min: {statistics5.Min:N2}");
Console.WriteLine($"Max: {statistics5.Max:N2}");