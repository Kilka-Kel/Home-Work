// Самый простой вариант, как отрицательное число сменить на положительное и наоборот - это умножить число на -1.
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Показать числа от -N до N");
int namderA = 1;
int namderB = 1;
string s;
// step=0;
//
Console.Write("введите число N - ");
s = Console.ReadLine();
namderA = Convert.ToInt32(s);
if (namderA <0)  namderA=namderA*-1;
namderB = namderA * -1;

Console.Write(namderB);
while (namderA != namderB)
{
    namderB++;
    Console.Write(", ");
    Console.Write(namderB);
}
