// Даны два числа. Показать большее и меньшее число

Console.Clear();
Console.WriteLine("Введите 2 числа и я покажу какое из них больше");

double namderA = 1;
double namderB = 1;
string s;
Console.Write("Введите число А (можно дробное через ,) - ");
s = Console.ReadLine();
namderA = Convert.ToDouble(s);

Console.Write("Введите число B (можно дробное через ,) - ");
s = Console.ReadLine();
namderB = Convert.ToDouble(s);

if (namderA > namderB)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("А больше В");
}
else if (namderA < namderB)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write("В больше А");

}  
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.Write("Хотел меня подловить, ХА ХА, не вышло! Они равны");

}    
