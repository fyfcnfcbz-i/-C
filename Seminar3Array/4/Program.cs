// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр 
// этого числа. Младший разряд числа должен располагаться на 0-м индексе 
// массива, старший – на 2-м.

//int n = new Random().Next(100, 1000);

string n = Console.ReadLine();

int len = n.Length;

int[] arr = new int[len];

for(int i = 0; i < len; i++)
{
    arr[i] = Convert.ToInt32(Convert.ToString(n[i]));
}


void PrintMas(int[] t)  // тип void означает функцию которая ничего не выводит 
{
    foreach (var item in t) // var - автоматически пределяет тип переменной, можно проставить свой
    {

        Console.Write($"{item} ");
    }
    Console.WriteLine(); // для следующего вывода с новой строчки
}
PrintMas(arr);

int[] arr2 = new int[len];

for(int i = 0; i < len; i++)
{
    arr2[i] = Convert.ToInt32(Convert.ToString(n[len - i - 1]));
}
PrintMas(arr2);