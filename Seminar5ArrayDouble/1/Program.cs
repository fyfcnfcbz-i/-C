// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
//  и замените эти элементы на их квадраты.

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

int[,] Sq(int[,] col) //функция 
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int  j = 0; j < col.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                col[i,j] = col[i,j] * col[i,j];
            }
           
        }
    }
    return col;
}


Console.Write("Введите размер m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];
int[,] arrRandom = RandomMas(array);

// int[,] arrRandom = {{2,3,4},{5,6,7}};

PrintMas(arrRandom);
Console.WriteLine(); 
PrintMas(Sq(arrRandom));