// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от 1 до N.


string Len(int stop, int start = 1)
{
    if(start == stop) return Convert.ToString(stop);
    return start + " " + Len(stop, start + 1);

}

void Len2(int num)
{
    if(num == 0) return;
    //Console.Write($"{num} "); // печать ноборот от N до 1 (5 4 3 2 1)
    Len2(num - 1);
    Console.Write($"{num} "); // печать (1 2 3 4 5)
}



Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Len(n));

Len2(n);


