string name = "Ewa";
string gender = "kobieta";
int age = 30;

if (gender == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (gender == "mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{

}