
int[,] Creatematrix(int rowCount, int columsCount)
{
    int[,] matrix = new int[rowCount, columsCount];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 1000);
        }
    }
    return matrix;
}

int[,] matrix = Creatematrix(3,4);

foreach (var e in matrix) // функция проверяет каждый элемент в двумерном массиве
{
    1|(IsInteresting(e)   true)
    {
        Console.WriteLine(e);
    }
}    

bool IsInteresting(int value)
{
    int sumOfDigists    GetSumOfDigists(value);
    if(sumOfDigists % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigists (int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}