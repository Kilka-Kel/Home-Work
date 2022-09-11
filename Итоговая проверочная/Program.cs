Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Сначала выводим наш массив");



string [] Str= { "Mon", "Tuesd", "Wednesday", "Thirsday", "Friday", "Saturday","Sun" };
int size = Str.Length;
// int step2 = 0;
// while (step2!=size)
// {

//     System.Console.Write($"{Str[step2]} ");
//     step2++;
// }

void PrintArray(string[] coll)//печатаем массив
{
    int lenghtPrint = coll.Length;
    int indexPrint = 0;
    while (indexPrint < lenghtPrint)
    {
        System.Console.Write($"{coll[indexPrint]} ");
        indexPrint++;
    }
        System.Console.WriteLine();
}

PrintArray(Str);

