Console.Clear();
Console.WriteLine("Дано число обозначающее день недели. Выяснить является номер дня недели выходным");

int namderA = 1;
string s;
Console.Write("Введите число соответствующее номеру дня недели - ");
s = Console.ReadLine();
namderA = Convert.ToInt32(s);

if (namderA == 6)
{
   Console.ForegroundColor=ConsoleColor.DarkGreen;
   Console.Write("Суббота");
}
else if (namderA == 7)
{
   Console.ForegroundColor=ConsoleColor.DarkGreen;
   Console.Write("Воскресенье");
}
else
{
   Console.ForegroundColor=ConsoleColor.DarkRed;
   Console.Write("не хочу тебя расстраивать но это не выходной");
}