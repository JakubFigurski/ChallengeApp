using ChallengeApp;

Console.WriteLine("Witamy w Programie do oceny pracowników");
Console.WriteLine("A/a - 100   B/b - 80   C/c - 60  D/d = 40  E/e - 20  F/f - 0");
Console.WriteLine("Q/q wyjście z programu");
Console.WriteLine("=======================================");
Console.WriteLine("");

var supervisior = new Supervisior("kuba", "Figurski");

 
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