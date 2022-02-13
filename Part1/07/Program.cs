Console.Clear();
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("Чёт или нечет?");
int namderA = 1;
string s;

Console.Write("введите число - ");
s = Console.ReadLine();
namderA = Convert.ToInt32(s);



bool EvenOrDdd (int a)
{
    return a % 2 == 0;
}

EvenOrDdd(namderA);
if (EvenOrDdd(namderA)) System.Console.WriteLine("Чёт");
else System.Console.WriteLine("Нечёт");


// if (namderA % 2 == 1)
// {
//     System.Console.WriteLine("Нечёт");
// }
// else
// {
//     System.Console.WriteLine("Чёт");
// }




// Этот кусок работает
// int a1 = 5;
// int b1 = 6;

// int Sum (int a, int b)
// {
//     return a+b;
// }

// System.Console.WriteLine(Sum(a1,b1));
