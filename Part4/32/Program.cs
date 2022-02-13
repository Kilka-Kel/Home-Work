Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран");

int[] Array = new int[8]; //new Random().Next(0,2)

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(0, 2);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int lenghtPrint = coll.Length;
    int indexPrint = 0;
    while (indexPrint < lenghtPrint)
    {
        System.Console.WriteLine(coll[indexPrint]);
        indexPrint++;
    }
}

FillArray(Array);
PrintArray(Array);

//Так же решеине через for
for (int step = 0; step < Array.Length; step++)
    Array[step] = new Random().Next(0, 2);
    
for (int step = 0; step < Array.Length; step++)
    System.Console.Write($"{Array[step]} ");