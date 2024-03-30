// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2 * number2)
{
    Console.WriteLine($"Квадрат числа {number2} равен {number1}");
}
else Console.WriteLine("Квадрат числа {0} НЕ равен {1}", number2, number1);

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int negative = -N;
while(negative <= N)
{ 
Console.Write($"{negative}\t"); //знак "/"(табуляция) - большие пробелы
    negative++;
}


// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа

Console.Write("Введите трехзначное целое число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int f = N % 10; //третье число
// int t = N / 10 % 10; //второе число
int o = N / 100; //первое чисто
int sum = o + f;

if (N < 100 || N > 1000)
{
    Console.Write("Число не трехначное!");
}
else Console.Write($"Сумма первого и третьего числа {N} равна {sum}");

// Console.WriteLine(f);
// Console.WriteLine(t);
// Console.WriteLine(o);
// Console.WriteLine(sum);



// Строковый тип в #С

Console.Write("Введите трехзначное целое число N: ");
string N = Console.ReadLine()!; // переменная N принимает значение string, 
                                //т.к конструкция Console.ReadLine() имеет строковое значение 
                                //и отсутсвует Конвектор Convert.ToInt32

if (N.Length != 3) // если длина строки не равна трем
{
    Console.Write("Число не трехначное!");
}
else
{
    // Console.WriteLine(N[0]); // выводим нулевой элемент строки
    // Console.WriteLine(N[1]);
    // Console.WriteLine(N[2]);

    // Console.WriteLine(N[0] + N[2]); // при 123 выводит 100
    // Console.WriteLine(N[0] + " " + N[2]); // при 123 выводит 1  

    // Console.WriteLine(Convert.ToInt32(N[0]) + Convert.ToInt32(N[2]));//преобразуем числа из строкового значения в целочисленные
                                                                    // Результат по прежнему 100
    Console.WriteLine(Convert.ToInt32(Convert.ToString(N[0]))                 
                              + Convert.ToInt32(Convert.ToString(N[2])));  // и обратно в сторковое
}