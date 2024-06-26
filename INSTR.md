# Инструкция по языку #C

**#C - язык статичиской типизации**

### Создание проекта
```sh
dotnet new console
```
_запуск в катологе в котором необходима срда_

_создается необходимый файл **Program.cs**_

### Компеляция
```sh
dotnet run
```
_осущетвляется в каталоге с проектом_

**Создание файла .gitignore**
```sh
dotnet new gitignore
```

___
___

 **Вывод инфо на консоль**.
В терминале введите команду:
- **Console.WriteLine**
- **Console.Write**
___
**" ; "** - в конце
___

### Тип данных  
1. **Целый**
>- int (5)
>- long

2. **Вещественный**
>- float (1.5)
>- double

3. **Символьный**
>- char ('!')

4. **Логический**
>- bool (true|false)

*_отличие в размерах_

-**Текстовый("Да")**
-**Символьный('!')**
___

**! Тип данных операндов одинаковый** 

_**-> тип данных у результата равен типу данных операндов**_ (int sum = i1 + i2)

**! Тип данных операндов разный**

_**-> тип данных результата формируется как наиболее объемный(вместительный)**_
___
_**Форматирование текста документа автоматически - Format Document**_
___

```sh
Console.Write("Введите первое число: ");
```
```sh
int number1 = Convert.ToInt32 (Console.ReadLine());
```
Ввод с клавиатуры - **Console.ReadLine()**

_по умолчанию работает в строку (string)_

Конвектор (string -> int) - **Convert.ToInt32**(Console.ReadLine())

_преобразовать можно и в другое значение_
___


```sh
Console.WriteLine($"Квадрат числа {number2} равен {number1}")
```
**< $ >** - для работы с переменными внутри вывода
 
 или

 ```sh
 Console.WriteLine("Квадрат числа {0} НЕ равен {1}", number2, number1);
 ```
 ___

 22 **/** 6 == 3.666667

 22 **//** 6 == 3 (6+6+6+4) 
 **Целочисленное деление**

 22 **%** 6 == 4 (6+6+6+4) **Остаток** от целочисленного деления

 **Чётное**  - **%2 == 0** (6 % 2 == (2+2+2+0) == 0)

  **НЕчётное**  - **%2 == 1** (7 % 2 == (2+2+2+1) == 1)

  **% -> mod**

______


### Unicode для вывода кириллицы
```sh
using System.Text;
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
```


 


