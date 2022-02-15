Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Возведите число А в натуральную степень B используя цикл");

int namderA = 0;
int namderB = 0;
string s;


if (namderB < 0) namderB = namderB * -1;
//
Console.Write("введите число А - ");
s = Console.ReadLine();
namderA = Convert.ToInt32(s);
//
Console.Write("введите число B - ");
s = Console.ReadLine();
namderB = Convert.ToInt32(s);

int sum=1;

for (int i =1;i<=namderB;i++)
{
    sum = sum * namderA;
    // System.Console.WriteLine(sum);
}

System.Console.WriteLine($"Возведите число А ({namderA}) в натуральную степень B ({namderB}) = {sum}");
