int num = new Random().Next(100,1000);
Console.WriteLine(num);
int num1 = num % 10;
int num2 = num / 100;


// Console.WriteLine(num1);
// Console.WriteLine(num2);

// Console.WriteLine(num2 + "" + num1); // строка

// Console.WriteLine(num2 * 10 + num1); // целочисленный тип

int result = num2 * 10 + num1;
Console.WriteLine($"{num} -> {result}");

int result_2 = Convert.ToInt32((num_2 + "" + num_1));
Console.WriteLine($"{num} -> {result_2}");



// 2. второе число возвести в степень 3 числа
int num = new Random().Next(100,1000);
Console.WriteLine(num);
int num2 = num / 10 % 10;
int num3 = num % 10;

// Console.WriteLine($"результат - {Math.Pow(num2,num3)}");

// или без использования библиотеки Math для возведения в степень
int i = 1;
int c = num2;
Console.WriteLine();
while (i < num3)
{
    с * = num2;
    Console.WriteLine(c);
    i++;
}

3. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли первое число кратным второму. Если первое число некратно 
второму, то программа выводит остаток от деления

Console.Write("Введите первое число: ");
int o = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int t = Convert.ToInt32(Console.ReadLine());

if (t == 0)
{
    Console.Write("Деление на ноль!");
}
else
{
    int R = o % t;
    if(R == 0)
    {
         Console.Write("Да");
    }
    else
    {
         Console.Write($"Нет");
    }

}

4. Напишите программу, которая выводит третью слева цифру заданного числа 
или сообщает, что третьей цифры нет.

// Строковый тип в #С

Console.Write("Введите  число: ");
string num = Console.ReadLine()!; // переменная N принимает значение string, 
                                //т.к конструкция Console.ReadLine() имеет строковое значение 
                                //и отсутсвует Конвектор Convert.ToInt32

if (num.Length < 3) // если длина строки меньше трех
{
    Console.Write("Третьей циыры нет!");
}
else
{
    // Console.WriteLine(num[2]);
    Console.WriteLine(Convert.ToInt32(Convert.ToString(num[2])));  // и обратно в сторковое
}

int num = new Random().Next(0, 10000);
Console.WriteLine(num);

int res = 0;
if (num < 100) 
{ 
    Console.WriteLine($"третей цифры нет:{num}"); 
}
else
{
    while (num >= 100)
    {
        res = num % 10; // в случае трехзнач возьмется 3 цифра слева в конце цикла
        num /= 10; // отрезаем последнее число и так до числа трхзначного
        Console.WriteLine($"num:{num}");
        Console.WriteLine($"ответ:{res}");
        Console.WriteLine( );
    }
}    