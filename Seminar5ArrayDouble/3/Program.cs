// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный 
// массив, состоящий из средних арифметических значений по строкам 
// двумерного массива.

using Microsoft.Win32.SafeHandles;

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

void PrintMasOne(int[] mas)  
{
    foreach (var item in mas)  
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine(); 
}

void PrintMasOneDouble(double[] mas)  
{
    foreach (var item in mas)  
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine(); 
}

int[] Sum ( int[,] col)
{
    int[] sma = new int [col.GetLength(0)];

    for (int i = 0; i < col.GetLength(0); i++)
    {
        int sm = 0;
        for (int  j = 0; j < col.GetLength(1); j++)
        {
            sm = sm + col[i,j]; 

        }
        sma[i] = sm;
    }
    return sma;
}

double[] Middle (int[] a, int [,] b)
{
    double[] fin = new double [b.GetLength(0)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        fin[i] = Convert.ToDouble(a[i]) / Convert.ToDouble(b.GetLength(0));
    }
    return fin;
}


Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];
int[,] arrRandom = RandomMas(array);

PrintMas(arrRandom);
Console.WriteLine();

int[] arrOne = Sum(arrRandom);
PrintMasOne(arrOne);

double[] mid = Middle(arrOne, arrRandom);
PrintMasOneDouble(mid);


