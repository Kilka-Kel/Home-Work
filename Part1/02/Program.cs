// По двум заданным числам проверять является ли первое квадратом второго
Console.Clear();
Console.WriteLine("По двум заданным числам проверим, является ли первое квадратом второго");

double namderA = 1;
double namderB = 1;
string s;
Console.Write("Введите число А (можно дробное через ,) - ");
s = Console.ReadLine();
namderA = Convert.ToDouble(s);
namderA=namderA * namderA;

Console.Write("Введите число B (можно дробное через ,) - ");
s = Console.ReadLine();
namderB = Convert.ToDouble(s);

if (namderA == namderB)
{
   Console.ForegroundColor=ConsoleColor.DarkGreen;
   Console.Write("Вы ввели число B являющееся квадратом А ");
}
else
{
    Console.ForegroundColor=ConsoleColor.DarkRed;
    Console.Write("НЕТ! Число B не являеется квадратом А");

}    
// Console.Write("A*A=");
// Console.WriteLine(namderA);

