var imię = "Ewa";
var imię1 = "Tomek";

var wiek = 33; // zmień wiek na mniej niż 30 by zobaczyć inne rozwiązanie
var wiek1 = 17; // zmień wiek na 18 lub więcej by zobaczyć inne rozwiązanie
var płeć = "kobieta";
var płeć1 = "mężczyzna";


if (imię == "Ewa" && wiek == 33 && płeć == "kobieta")
{
    Console.WriteLine("33 letnia Kobieta o imieniu Ewa");
}
else if (płeć == "kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (imię1 == "Tomek" && wiek1 < 18 && płeć1 == "mężczyzna")
{
    Console.WriteLine("NIepełnoletni mężczyzna o imieniu Tomek");
}
else if (imię1 == "Tomek" && wiek1 >= 18 && płeć1 == "mężczyzna")
{
    Console.WriteLine("Pełnoletni mężczyzna");
}
