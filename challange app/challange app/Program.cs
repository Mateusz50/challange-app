using challange_app;


Employee employer1 = new Employee("Kamil", "Woźniak", "28");
Employee employer2 = new Employee("Tomek", "Źniak", "30");
Employee employer3 = new Employee("Emil", "Kniak", "45");


employer1.AddScore(5);
employer1.AddScore(7);
employer1.AddScore(1);
employer1.AddScore(4);
employer1.AddScore(9);
var result = employer1.Result;


employer2.AddScore(10);
employer2.AddScore(2);
employer2.AddScore(3);
employer2.AddScore(4);
employer2.AddScore(10);
var result2 = employer2.Result;


employer3.AddScore(5);
employer3.AddScore(1);
employer3.AddScore(1);
employer3.AddScore(1);
employer3.AddScore(1);
var result3 = employer3.Result;


if (result > result2 && result > result3)
{
    Console.WriteLine("Osoba " + employer1.Name + " " + employer1.Surname + " w wieku " + employer1.Age + " lat " + " uzyskał/a punktów " + result + " co klasyfikuje go/ją na pierwsze miejsce");
}
else if (result2 > result3 && result2 > result)
{
    Console.WriteLine("Osoba " + employer2.Name + " " + employer2.Surname + " w wieku " + employer2.Age + " lat " + " uzyskał/a punktów " + result2 + " co klasyfikuje go/ją na pierwsze miejsce");
}
else if (result3 > result && result3 > result2)
{
    Console.WriteLine("Osoba " + employer3.Name + " " + employer3.Surname + " w wieku " + employer3.Age + " lat " + " uzyskał/a punktów " + result3 + " co klasyfikuje go/ją na pierwsze miejsce");
}


