// Задайте одномерный массив, заполненный случайными числами. 
// Определите количество простых чисел в этом массиве.



int[] RandomMas(int[] col) //функция 
{
    for (int i = 0; i < col.Length; i++) //проходимся по массиву и каждому элементу с i индексом приcваиваем рндомное значение
    {
        col[i] = new Random().Next(1, 200);
    }
    return col;
}
// //или
// int[] RandomMas(int m) //функция 
// {
//     int[] col = new int[m];
//     for (int i = 0; i < col.Length; i++) //проходимся по массиву и каждому элементу с i индексом приcваиваем рндомное значение
//     {
//         col[i] = new Random().Next(1, 200);
//     }
//     return col;
// }
// int[] arr = RandomMas(n);



void PrintMas(int[] mas)  // тип void означает функцию которая ничего не выводит 
{
    foreach (var item in mas) // var - автоматически пределяет тип переменной, можно проставить свой
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine(); // для следующего вывода с новой строчки
}



 bool prost(int num)
 {
    for (int i = 2; i < num; i++)
    {
        if(num % i == 0) 
        {
            return false; // если число делется без остатк в процессе то оно не простое - false, -> берем следующие число
        } 
    }
    Console.WriteLine($"{num}"); // выводим простое число
    return true; //числов в цикле не поделилось ни на что -> число простое(деление на 1 и остается только на себя)
 }


int Count(int[] colll) //функция проверяющая числа
{
    int count = 0;
    foreach (var itm in colll)
    {
        if(prost(itm)) // каждое число - itm отправляем в функцию prost на проверку простоты число. в случае true плюсуеи счетчик count
        {
            count++;
        }
    }
    return count;
} 

// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
int n = new Random().Next(2, 16);

//int[] array = new int[n];
// int[] arr = RandomMas(array);
int[] arr = RandomMas(new int[n]);

PrintMas(arr);

Console.WriteLine($"Колличество простых чисел в массиве равно {Count(arr)}"); // функция Count сразу идет на вывод (не присваиваем ей значение переменной)
 



