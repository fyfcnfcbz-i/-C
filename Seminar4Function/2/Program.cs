// Задайте массив из N случайных целых чисел (N вводится с клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и делятся нацело на 7.

int[] RandomMas(int t) //функция 
{
    int[] col = new int[t];
    for (int i = 0; i < col.Length; i++) //проходимся по массиву и каждому элементу с i индексом приcваиваем рндомное значение
    {
        col[i] = new Random().Next(1, 200);
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

int Count(int[] col) //функция проверяющая числа
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
        if(col[i] % 10 == 1 && col[i] % 7 == 0) 
        {
            Console.WriteLine($"число {col[i]} "); 
            count++;
        }
    }
    return count;

} 



Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = RandomMas(n);

PrintMas(arr);

Console.WriteLine($"Колличество нужных чисел в массиве равно {Count(arr)}"); 
 