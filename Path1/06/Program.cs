// Написать программу вычисления функции y = f(a)
Console.Clear();
int a = 0;
int result = 0;
double F(double a)
{
    double result = a * a + 1;
    return result;
}

System.Console.WriteLine(F(2));