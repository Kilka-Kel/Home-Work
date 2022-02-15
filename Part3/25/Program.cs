Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Найти сумму чисел от 1 до А");

int namderA = 0;
string s;
int sum=0;

if (namderA < 0) namderA = namderA * -1;
//
Console.Write("введите число А - ");
s = Console.ReadLine();
namderA = Convert.ToInt32(s);


for (int i =1;i<=namderA;i++)
{
    sum = sum + i;
    System.Console.WriteLine(sum);
}

System.Console.WriteLine($"Сумма чисел от 1 до А = {sum}");