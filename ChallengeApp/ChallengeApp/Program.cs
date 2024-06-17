using ChallengeApp;

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("A/a - 100   B/b - 80   C/c - 60  D/d = 40  E/e - 20  F/f - 0");
Console.WriteLine("Q/q wyjście z programu");
Console.WriteLine("=======================================");
Console.WriteLine("");

var employee1 = new EmployeeInMemory("Kuba", "Figurski");
var employee2 = new EmployeeInFile("Kuba", "Figurski");

if (File.Exists(EmployeeInFile.fileName))
{
    File.Delete(EmployeeInFile.fileName);
}
while (true)
{
    Console.WriteLine("Enter the employee's next grade. Range: 1-6(-/+) or A/a=100 B/b=80 C/c=60 D/d=40 E/e=20   (Q/q - quit): ");
    string? input = Console.ReadLine();
    if ((input == "q") ^ (input == "Q"))
    {
        break;
    }
    if ((input == "A") ^ (input == "a") ^ (input == "B") ^ (input == "b") ^ (input == "C") ^ (input == "c") ^ (input == "D") ^ (input == "d") ^ (input == "E") ^ (input == "e"))
    {
        try
        {
            employee1.AddGrade(input.ToCharArray(0, 1)[0]);
            employee2.AddGrade(input.ToCharArray(0, 1)[0]);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
    else
    {
        try
        {
            employee1.AddGrade(input);
            employee2.AddGrade(input);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
}
var statistics = employee1.GetStatistics();
Console.WriteLine("Statistics from memory:");
Console.WriteLine($"Avg: {statistics.Avarange}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Number of added grades: {statistics.Count}");
Console.WriteLine($"Sum of all grades: {statistics.Sum}");

statistics = employee2.GetStatistics();
Console.WriteLine("Statistics from file:");
Console.WriteLine($"Avg: {statistics.Avarange}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Number of added grades: {statistics.Count}");
Console.WriteLine($"Sum of all grades: {statistics.Sum}");






























/*
    while (true)
    {
        Console.WriteLine("Podaj kolejna ocene pracownika");
        var input = Console.ReadLine();
        if ((input == "q") ^ (input == "Q"))
        {
            break;
        }

        if ((input == "A") ^ (input == "a") ^ (input == "B") ^ (input == "b") ^ (input == "C") ^ (input == "c") ^ (input == "D") ^ (input == "d") ^ (input == "E") ^ (input == "e"))
        {
            try
            {
                supervisior.AddGrade(input.ToCharArray(0, 1)[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
            }
        }
        else
        {
            try
            {
                supervisior.AddGrade(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception catched: {e.Message}");
        }
    }
}
var statistics = supervisior.GetStatistics();
Console.WriteLine($"Averange {statistics.Avarange}");
Console.WriteLine($"Max {statistics.Max}");
Console.WriteLine($"Min {statistics.Min}");
Console.WriteLine($"Number of added grades: {statistics.Count}");
Console.WriteLine($"Sum of all grades: {statistics.Sum}");
 */