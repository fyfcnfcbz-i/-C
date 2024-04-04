// На основе символов строки (тип string) сформировать массив символов 
// (тип char[]). Вывести массив на экран.
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

char[] StringOfChar (string s)
{
    char[] mas = new char[s.Length];

    for (int i = 0; i < s.Length; i++)
    {
        mas[i] = s[i];
    }
   
    return mas;
}

void Print(char[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

string st = "Привет!";

Print(StringOfChar(st));