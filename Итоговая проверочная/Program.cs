Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Сначала выводим наш массив");
// int [] Array = {1,2,3,4,5,6,7,8}; // потом удали всё
// int step = 0;
// int size = Array.Length;
//Вывод через for
// for (int step = 0;step<Array.Length; step++)
//     System.Console.Write($"{Array[step]} ");

//Вывод через while
// while (step!=size)
// {
//     System.Console.WriteLine(Array[step]);
//     step++;
// }
int step2 = 0;

string [] str= { "Mon", "Tuesd", "Wednesday", "Thirsday", "Friday", "Saturday","Sun" };
int size = str.Length;
while (step2!=size)
{

    System.Console.Write($"{str[step2]} ");
    step2++;
}