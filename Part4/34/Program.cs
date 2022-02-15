// if (namderB < 0) namderB = namderB * -1;
Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Написать программу замены элементов массива на противоположные");

int[] Array = new int[10]; //new Random().Next(0,2)

void FillArray(int[] collection)//заполняем массив значениями
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(-10, 10);
        index++;
    }
}

void PrintArray(int[] coll)//печатаем массив
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

void ReversArray(int[] collRevers)//Меняем значения на противоположные 
{
    int lenghtRevers = collRevers.Length;
    int indexRevers = 0;
    while (indexRevers < lenghtRevers)
    {
        collRevers[indexRevers] = collRevers[indexRevers] * -1;
        indexRevers++;
    }
}

FillArray(Array);
PrintArray(Array);
ReversArray(Array);
PrintArray(Array);
