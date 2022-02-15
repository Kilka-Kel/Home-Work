Console.Clear();
// //Виды метоедов

// //Вид 1 

// void Metod1()
// {
//     System.Console.WriteLine("Текст выводимый методом 1");
// }
// Metod1();

// //Вид 2 
// void Metod2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Metod2("Текст выводимый методом 2");

// void Metod21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }

// }
// Metod21("Текст выводимый методом 21", 2); //или
// Metod21( count: 2, msg: "ещё один Текст выводимый методом 21");//порядок не важен

// //Вид 3
// int Metod3()
// {
//     return DateTime.Now.Year;
// }

// int year = Metod3();
// System.Console.WriteLine(year);

// //Вид 4
// string Metod4(int count, string text)
// {
//     int i=0;
//     string result = string.Empty;
//     while(i<count)
//     {
//         result= result+ text;
//         i++;
//     }
//     return result;
// }

// string res = Metod4(10, "anyfing ");
// System.Console.WriteLine(res);

//Цикл в цикле
// for (int i =2;i<=10;i++)
// {
//     for(int j=2; j<=10;j++)
//     {
//         System.Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     System.Console.WriteLine();
// }

string text = "Шел Шива по Шоссе сокрушая сущее, "
            + "А на встречу Саша шла, круглое сусущая";

// sting s "qwerty"
//          012
//s[3]//r

string replase(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = replase(text, 'Ш', 'ш');
System.Console.WriteLine(newText);
