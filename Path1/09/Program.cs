Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Показать четные числа от 1 до N");
int namderA = 0;
int namderB = 0;
string s;
int step = 0;

if (namderA < 0) namderA = namderA * -1;
//
Console.Write("введите число N - ");
s = Console.ReadLine();
namderA = Convert.ToInt32(s);

while (step != namderA)
{
namderB++;
    if (namderB % 2 == 0)
    {
        Console.Write(namderB);
        Console.Write(", ");
    }
step++;
}


