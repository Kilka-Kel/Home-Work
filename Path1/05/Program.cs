Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Найти максимальное из трех чисел");
double max = 0;
double namderA = 1;
double namderB = 1;
double namderC = 1;
string s;
//
Console.Write("введите число А - ");
s = Console.ReadLine();
namderA = Convert.ToDouble(s);

Console.Write("введите число B - ");
s = Console.ReadLine();
namderB = Convert.ToDouble(s);

Console.Write("введите число C - ");
s = Console.ReadLine();
namderC = Convert.ToDouble(s);
//
if (namderA > namderB)
{
    if (namderA > namderC)
    {
        max = namderA;
    }
    else
    {
        max = namderC;
    }
}
else
{
    if (namderB > namderC)
    {
        max = namderB;
    }
    else
    {
        max = namderC;
    }
}

Console.Write(max);
System.Console.WriteLine("- Самое большое");