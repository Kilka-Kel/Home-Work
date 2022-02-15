Console.Clear();
Console.WriteLine("По заданному номеру дня недели вывести его название");

int namderA = 1;
string s;
Console.Write("Введите число соответствующее номеру дня недели - ");
s = Console.ReadLine();
namderA = Convert.ToInt32(s);

/*
if (namderA == namderB)
{
   Console.ForegroundColor=ConsoleColor.DarkGreen;
   Console.Write("Вы ввели число B являющееся квадратом А ");
}
*/

if (namderA == 1)
{
   Console.ForegroundColor=ConsoleColor.DarkGreen;
   Console.Write("Понедельник, будь он не ладен ");
}
else if (namderA == 2)
{
   Console.ForegroundColor=ConsoleColor.DarkGreen;
   Console.Write("Это Вторник детка");
}
else if (namderA == 3)
{
   Console.ForegroundColor=ConsoleColor.DarkGreen;
   Console.Write("Среда это маленькая пятница");
}
else if (namderA == 4)
{
   Console.ForegroundColor=ConsoleColor.DarkGreen;
   Console.Write("Ч - Четверг");
}
else if (namderA == 5)
{
   Console.ForegroundColor=ConsoleColor.DarkGreen;
   Console.Write("От греческого pente ‘пять’. Пятница");
}
else if (namderA == 6)
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
   Console.Write("В нашей системе счисления всего 7 дней недели, убеитесь что вы запускаете на правильной планете");
}