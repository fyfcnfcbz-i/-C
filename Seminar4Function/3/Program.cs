// Заполните массив на N (вводится с консоли, не более 8) случайных целых 
// чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из массива. 
// Старший разряд числа находится на 0-м индексе, младший – на последнем.


using System.Globalization;

int[] RandomMas(int t) //функция 
{
    int[] col = new int[t];
    for (int i = 0; i < col.Length; i++) //проходимся по массиву и каждому элементу с i индексом приcваиваем рндомное значение
    {
        col[i] = new Random().Next(0, 10);
    }
    return col;
}

void PrintMas(int[] mas)  // тип void означает функцию которая ничего не выводит 
{
    foreach (var item in mas) // var - автоматически пределяет тип переменной, можно проставить свой
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine(); // для следующего вывода с новой строчки
}

// string FindNumber(int[] col)
// {
//     string num = "";
//     for (int i = 0; i < col.Length; i++)
//     {
//         num = num + Convert.ToString(col[i]);
//     }
//     return num;
// }

int FindNumber(int[] col)
{
    int num = 0;
    for (int i = 0; i < col.Length; i++)
    {
        num = num * 10 + col[i];
    }
    return num;
}


Console.Write("Введите размерность массива(не больше 8): ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomMas(n);


if (n <= 8)
{
    PrintMas(arr);
    Console.WriteLine($"{FindNumber(arr)}");
}
else
{
    Console.WriteLine("Размерность не подходит");
}


