// Присутсвует ли заданное число в массиве


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

// Console.WriteLine(array);


// while
int ind = 0;
while (ind < array.Length)
{
    Console.Write($"{array[ind]} ");
    ind++;
}
Console.WriteLine();


// for

for (int i = 0; i < array.Length; i++)
{
    //array[i] = 7;
    Console.Write($"{array[i]} ");
}
Console.WriteLine();

// foreach

foreach (var item in array) // var - автоматически пределяет тип переменной, можно проставить свой
{
    Console.Write($"{item} ");
}
Console.WriteLine();

// функция

