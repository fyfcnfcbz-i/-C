
// int firstNumber = 6;
// int secondNumber = 7;

// // Введите свое решение ниже
// if (firstNumber == secondNumber)
// {
//     Console.WriteLine("числа равны");
// }
// else
// {
//     if (firstNumber > secondNumber)
//     {
//         Console.WriteLine("первое число больше");
//     }
//     else
//     {
//         Console.WriteLine("второе число больше");
//     }
// }

////2

// int a = -3;
// int b = 9;
// int c = 9;

// int max = a;

// if (b > max)
// {
//     max = b;
// }
// if (c > max)
// {
//     max = c;
// }
// Console.WriteLine($"{max}");

// //3

// int number = -9;

// if (number % 2 == 0)
// {
//     Console.WriteLine("четное");
// }
// else 
// {
//     Console.WriteLine("нечетное");
// }


// //4.

// int number = 8;
// int i = 1;

// while (i <= number)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write($"{i} ");
//         i++;
//     }
//     else 
//     {
//         i++;
//     }
// }

//// или

// for (int count = 2; count <= number; count += 2)
//         {
//             Console.Write($"{count} ");
//         }

// //dz2 Array

////1.
// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
//     // Подсчет количества элементов массива, попадающих в заданный диапазон
//     // numbers - массив, в котором ведется подсчет
//     // minRange - минимальная граница диапазона
//     // maxRange - максимальная граница диапазона
//     public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
//     {
//          //Введите сюда свое решение

//         int count = 0;
//          foreach (var num in numbers)
//         {
//             if (num >= minRange && num <=maxRange)
//                 count++;
//         }  
//         return count;

//     }

//     public static void PrintResult(int[] array)
//     {

//           //Введите сюда свое решение

//         // foreach (var item in array)
//         // {
//         //     Console.Write($"{item} ");
//         // }  
//         // Console.WriteLine();

//         // int count = CountItemsRange (array, 10, 90);
//     //    Console.WriteLine($"{count}");
//        Console.WriteLine(CountItemsRange (array, 10, 90));
//     }
// }


// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;


//         if (args.Length >= 1) {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         } else {
//            // Если аргументов на входе нет
//             array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }

////2.

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Подсчет количества четных элементов массива
//     // numbers - массив, в котором ведется подсчет
//     public static int CountEvenItems(int[] numbers)
//     {
//         //Напишите свое решение здесь
//         int count = 0;
//         foreach (var num in numbers)
//         {
//             if (num % 2 == 0)
// {
//     //                 count++;
// }
//         }
//         return count;
//     }

//     public static void PrintResult(int[] array)
//     {
//         //Напишите свое решение здесь
//         Console.WriteLine(CountEvenItems(array));
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[] array;


//         if (args.Length >= 1)
//         {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(int.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         }
//         else
//         {
//             // Если аргументов на входе нет
//             array = new int[] { 2, 5, 2, 3, 6, 3, 7, 8, 2, 4 }; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }

////3.

// using System;
// using System.Linq;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Разница между максимальным и минимальным элементами массива

//     // Нахождение минимума массива
//     public static double FindMin(double[] numbers)
//     {
//         double min = numbers[0];
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] < min)
//             {
//                 min = numbers[i];
//             }
//         }

//         return min;
//     }

//     // Нахождение максимума массива
//     public static double FindMax(double[] numbers)
//     {
//         double max = numbers[0];
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] > max)
//             {
//                 max = numbers[i];
//             }
//         }
//         return max;
//     }



//     public static void PrintResult(double[] array)
//     {
//         double result = FindMax(array) - FindMin(array);
//         Console.WriteLine($"{result}");
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         double[] array;


//         if (args.Length >= 1)
//         {
//             // Объединяем все аргументы командной строки в одну строку
//             string joinedArgs = string.Join(" ", args);

//             // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
//             array = joinedArgs.Split(", ")
//                                   .Select(double.Parse)
//                                   .ToArray();

//             // Теперь arr содержит преобразованные в целые числа из командной строки

//         }
//         else
//         {
//             // Если аргументов на входе нет
//             array = new double[] { 0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01 }; // Создание массива
//         }
//         UserInputToCompileForTest.PrintResult(array);
//     }
// }

////array double
////1


// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//     // Поиск элемента по позициям
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь х-1 и y-1
//         if (ValidatePosition(array, x, y))
//         {
//             return array[x - 1, y - 1];
//         }
//         else
//         {
//             return -1;
//         }
//     }

//     // Проверка позиций на вхождение в массив
//     public static bool ValidatePosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь фолс тру
//         if (x >= 1 && y >= 1 && x <= array.GetLength(0) && y <= array.GetLength(1))
//         {
//             return true;
//         }
//         return false;
//     }

//     public static void PrintResult(int[,] numbers, int x, int y)
//     {
//         //Напишите свое решение здесь
//         if (ValidatePosition(numbers, x, y))
//         {
//             int res = FindElementByPosition(numbers, x, y);
//             Console.WriteLine($"{res}");
//         }
//         else
//         {
//             if (x < 1 || x > numbers.GetLength(0))
//             {
//                 Console.WriteLine("Позиция по рядам выходит за пределы массива");
//             }
//             if (y < 1 || y > numbers.GetLength(1))
//             {
//                 Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//             }
//         }



//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {

//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 5;
//             y = 8;

//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }
//     }
// }

////2
///

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Печать массива
//     public static void PrintArray(int[,] array)
//     {
//         //Напишите свое решение здесь
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]}\t ");
//             }
//             Console.WriteLine();
//         }
//     }

//     // Обмен первой с последней строкой
//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         //Напишите свое решение здесь
//         int[] temp = new int[array.GetLength(1)];
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             temp[j] = array[0, j];
//         }

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[0, j] = array[array.GetLength(0) - 1, j];
//         }


//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[array.GetLength(0) - 1, j] = temp[j];
//         }


//         return array;
//     }

//     // Обмен элементами массива
//     public static void SwapItems(int[,] array, int i)
//     {
//         //Напишите свое решение здесь

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int temp = array[i, j];
//             array[i, j] = array[array.GetLength(0) - 1, j];
//             array[array.GetLength(0) - 1, j] = temp;
//         }

//     }

//     public static void PrintResult(int[,] numbers)
//     {
//         //Напишите свое решение здесь
//         PrintArray(SwapFirstLastRows(numbers));
//     }

//     //Не удаляйте и не меняйте класс Answer!
//     class Answer
//     {
//         public static void Main(string[] args)
//         {
//             int[,] numbers;

//             if (args.Length >= 1)
//             {
//                 // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//                 string[] rows = args[0].Split(',');

//                 int rowCount = rows.Length;
//                 int colCount = rows[0].Trim().Split(' ').Length;

//                 numbers = new int[rowCount, colCount];

//                 for (int i = 0; i < rowCount; i++)
//                 {
//                     string[] rowElements = rows[i].Trim().Split(' ');

//                     for (int j = 0; j < colCount; j++)
//                     {
//                         if (int.TryParse(rowElements[j], out int result))
//                         {
//                             numbers[i, j] = result;
//                         }
//                         else
//                         {
//                             Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                             return;
//                         }
//                     }
//                 }
//             }
//             else
//             {
//                 // Если аргументов на входе нет, используем примерный массив
//                 numbers = new int[,]
//                 {
//                 {6, 100, -2, 0},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//                 };
//             }
//             UserInputToCompileForTest.PrintResult(numbers);
//         }
//     }
// }

////3

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     /// Вычисление сумм по строкам (на выходе массив с суммами строк)
//     public static int[] SumRows(int[,] array)
//     {
//         //Напишите свое решение здесь
//         int[] temp = new int[array.GetLength(0)];
        
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int sum = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sum = sum + array[i, j];
//             }
//             temp[i] = sum;
//         }
//         return temp;
//     }

//     // Получение индекса минимального элемента в одномерном массиве
//     public static int MinIndex(int[] array)
//     {
//         //Напишите свое решение здесь
//         int minI = 0;
//         for (int i = 1; i < array.Length; i++)
//         {

//             if(array[i] < array[minI])
//             {
//                 minI = i;
//             }
//         }
//         return minI;
//     }
//     public static void PrintResult(int[,] numbers)
//     {
//         //Напишите свое решение здесь
//         int[] sum = SumRows(numbers);
//         int MinIn = MinIndex(sum);
//         Console.Write($"{MinIn}");
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив

//             numbers = new int[,] {
//                 {1, 2, 3},
//                 {1, 1, 0},
//                 {7, 8, 2},
//                 {9, 10, 11}
//     };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }