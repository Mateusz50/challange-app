int number = 4565;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char letter in letters)
{
    if (letter == '0')
    {

        counter0++;
    }
    else if (letter == '1')
    {
        counter1++;
    }
    else if (letter == '2')
    {
        counter2++;
    }
    else if (letter == '3')
    {
        counter3++;
    }
    else if (letter == '4')
    {
        counter4++;
    }
    else if (letter == '5')
    {
        counter5++;
    }
    else if (letter == '6')
    {
        counter6++;
    }
    else if (letter == '7')
    {
        counter7++;
    }
    else if (letter == '8')
    {
        counter8++;
    }
    else if (letter == '9')
    {
        counter9++;
    }


}
Console.WriteLine(number);
Console.WriteLine("w tej liczbie jest -" + counter0 + "   zer");
Console.WriteLine("w tej liczbie jest -" + counter1 + "    jedynek");
Console.WriteLine("w tej liczbie jest -" + counter2 + "   dwujek");
Console.WriteLine("w tej liczbie jest -" + counter3 + "  trójek");
Console.WriteLine("w tej liczbie jest -" + counter4 + "  czwórek");
Console.WriteLine("w tej liczbie jest -" + counter5 + "   piątek");
Console.WriteLine("w tej liczbie jest -" + counter6 + "  szóstek");
Console.WriteLine("w tej liczbie jest -" + counter7 + "   siódemek");
Console.WriteLine("w tej liczbie jest -" + counter8 + "  ósemek");
Console.WriteLine("w tej liczbie jest -" + counter9 + "   dziewiątek");
