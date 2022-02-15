Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Показать таблицу квадратов чисел от 1 до N");

int namderA = 0;
string s;

if (namderA < 0) namderA = namderA * -1;
//
Console.Write("введите число N - ");
s = Console.ReadLine();
namderA = Convert.ToInt32(s);


for (int i =1;i<=namderA;i++)
{
 System.Console.WriteLine($"{i} в квадрате = {i*i}");
    // System.Console.WriteLine();
}

