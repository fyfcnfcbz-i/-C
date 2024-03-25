
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
