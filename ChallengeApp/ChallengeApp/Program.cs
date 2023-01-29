string name = "Ewa";
bool female = false;
int age = 18;


if (female && age < 30)
{
    Console.WriteLine("Kobieta w wieku poniżej 30. lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Kobieta o imieniu Ewa w wieku 33. lat");
}
else if (!female && age <= 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}