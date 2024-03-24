// Найдите произведения пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новый массив.

int n = new Random().Next(2, 11);

int[] RandomMas(int[] col) //функция 
{
    for (int i = 0; i < col.Length; i++) //проходимся по массиву и каждому элементу с i индексом приcваиваем рндомное значение
    {
        col[i] = new Random().Next(-100, 101);
    }

    return col;
}

int[] arr = RandomMas(new int[n]);


void PrintMas(int[] t)  // тип void означает функцию которая ничего не выводит 
{
    foreach (var item in t) // var - автоматически пределяет тип переменной, можно проставить свой
    {

        Console.Write($"{item}\t");
    }
    Console.WriteLine(); // для следующего вывода с новой строчки
}
PrintMas(arr);

int index = 0;
int product = 0;
while (index < arr.Length / 2)
{
    product = arr[index] * arr[arr.Length - index -1];
    Console.WriteLine($"{product}" );
    index++;

}

