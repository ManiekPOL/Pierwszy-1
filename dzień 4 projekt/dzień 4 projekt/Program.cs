string name = "Karolina";
string gender = "Woman";
int age = 18;


if (gender == "Woman" && age<30) 
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}

if ( gender != "Woman" && age < 18 )
{
    Console.WriteLine("Niepełnoletni męszczyzna");
}