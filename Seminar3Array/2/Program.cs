
// Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10]. 
// Замените отрицательные элементы на положительные, а положительные на отрицательные.

// Console.Write("Введите размерность массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[n];

// for (int i = 0; i < array.Length; i++) //проходимся по массиву и каждому элементу с i индексом приваиваем рндомное значение
//     {
//         array[i] = new Random().Next(-10, 11);
//         Console.Write($"{array[i]} ");
//     }

// Console.WriteLine();

// for (int i = 0; i < array.Length; i++) //проходимся по массиву и каждому элементу с i индексом приваиваем рндомное значение
//     {
//         array[i] = array[i] * -1;
//         Console.Write($"{array[i]} ");
//     }

int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];

int[] RandomMas(int[] col) //функция - возвращает целочисленное значение int
{
    for (int i = 0; i < col.Length; i++) //проходимся по массиву и каждому элементу с i индексом приваиваем рндомное значение
    {
        col[i] = new Random().Next(-10, 11);
    }

    return col;
}

// int[] arr = new int[n];
// int[] array = RandomMas(arr);
int[] arr = RandomMas(new int[n]);


void PrintMas(int[] t)  // тип void означает функцию которая ничего не выводит 
{
    foreach (var item in t) // var - автоматически пределяет тип переменной, можно проставить свой
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine(); // для следующего вывода с новой строчки
}
// PrintMas(array);
PrintMas(arr);

for (int i = 0; i < arr.Length; i++) //проходимся по массиву и каждому элементу с i индексом приваиваем рндомное значение
    {
        arr[i] = arr[i] * -1;
        // Console.Write($"{arr[i]} ");
    }
PrintMas(arr);