// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной 
// диагонали (с индексами (0,0); (1;1) и т.д.


int[,] RandomMas(int[,] col) //функция 
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int  j = 0; j < col.GetLength(1); j++)
        {
            col[i,j] = new Random().Next(0, 10);
        }
    }
    return col;
}


void PrintMas(int[,] col)   
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int  j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i,j]} "); 
        }
    Console.WriteLine(); 
    }
}


int Diag(int[,] col) //функция 
{
    int sum = 0;
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int  j = 0; j < col.GetLength(1); j++)
        {
            if(i == j)
            {
                sum = sum + col[i,j];
            }
        }
    }
    return sum;
}

// //или
// int MinList(int[,] col) //функция определяющая что меньше количество строк или столбцов
// {
//     if (col.GetLength(0) < col.GetLength(1))
//     {
//         return col.GetLength(0);
//     }
//     return col.GetLength(1);
// }

// int DiagList(int[,] col, int min) //функция 
// {
//     int sum = 0;
//     for (int i = 0; i < min; i++)
//     {
//        sum = sum + col[i,i];
//     }
//     return sum;
// }
// int res = DiagList(arrRandom, MinList(arrRandom));

Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];
int[,] arrRandom = RandomMas(array);

PrintMas(arrRandom);
Console.WriteLine(); 
int res = Diag(arrRandom);
Console.WriteLine($"Сумма равна {res}");
