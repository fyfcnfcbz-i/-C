// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки

void Consonants (string s)
{
    if(s.Length == 0) return;
    string st = "aoyuei";
    if (st.Contains(s[0]) == false) Console.Write($"{s[0]}");// функция Contains проверяет элемент  с индексом в строке st -> 1. если есть(истина) - лож -> Лож (не выводим на печать) / 2. если не(лож) - лож -> Истина (выводим на печать)
    Consonants (s[1..]); // с 1 символа строки s
}

void Consonants2 (string s, int i = 0)
{
    string st = "aouei";
    if(i == st.Length) return;
    if (st.Contains(s[i]) == false) Console.Write($"{s[i]}");
    Consonants2 (s, i + 1);
}


// // отрицание при помощи !
// void Consonants2 (string s, int i = 0)
// {
//     string st = "aouei";
//     if(i == st.Length) return;
//     if (!st.Contains(s[i])) Console.Write($"{s[i]}");
//     Consonants2 (s, i + 1);
// }
// Console.WriteLine(false); //вывод -> false
// Console.WriteLine(!false); //вывод -> true



string n = Console.ReadLine();
Consonants(n);
Console.WriteLine();
Consonants2(n);
