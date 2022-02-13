Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Задать массив из 8 элементов и вывести их на экран");
int [] Array = {1,2,3,4,5,6,7,8};
// int step = 0;
// int size = Array.Length;
//Вывод через for
for (int step = 0;step<Array.Length; step++)
    System.Console.Write($"{Array[step]} ");

//Вывод через while
// while (step!=size)
// {
//     System.Console.WriteLine(Array[step]);
//     step++;
// }
