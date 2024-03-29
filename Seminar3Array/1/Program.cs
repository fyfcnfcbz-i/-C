﻿// Присутсвует ли заданное число в массиве


Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

// Console.WriteLine(array);


// while
int i = 0;
while (i < array.Length)
{
    Console.Write($"{array[i]} ");
    i++;
}
Console.WriteLine();


// for

for (int ind = 0; i < array.Length; i++)
{
    //array[ind] = 7;
    Console.Write($"{array[ind]} ");
}
Console.WriteLine();

// foreach

foreach (var item in array) // var - автоматически пределяет тип переменной, можно проставить свой
{
    Console.Write($"{item} ");
}
Console.WriteLine();

// функция

void PrintMas(int[] array)  // тип void означает функцию которая ничего не выводит 
{
    foreach (var item in array) // var - автоматически пределяет тип переменной, можно проставить свой
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
PrintMas(array);


int[] RandomMas(int[] col) //функция - возвращает целочисленное значение int
{
    for (int i = 0; i < col.Length; i++) //проходимся по массиву и каждому элементу с i индексом приваиваем рндомное значение
    {
        col[i] = new Random().Next(1, 9);
    }

    return col;
}

int[] arr = RandomMas(array);

PrintMas(arr);

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

int flag = 0;
foreach (var item in arr)
{
    if (item == m)
    {
        flag++;
    }
}

if (flag > 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

//

string S(int[] col, int m)
{
    foreach (var item in col)
    {
        if (item == m) return "Да";
    }
    return "Нет";
}
Console.WriteLine(S(array, m));