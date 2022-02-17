// Пересобираем строчку в обратном порядке
Console.WriteLine("Пересобираем строчку в обратном порядке");


string s = Console.ReadLine();
string result = string.Empty;

for (int i = s.Length-1; i >=0; i--)
{
    result = result + s[i];
    // System.Console.Write(s[i]);

}
System.Console.WriteLine(result);