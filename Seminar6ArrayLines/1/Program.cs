// Задайте массив символов (тип char []). 
// Создайте строку из символов этого массива.


string CharsOfSttring(char[] arr)
{
    string st = "";
    foreach (var i in arr)
    {
        st += i;
    }
    return st;
}

// string CharsOfSttring(char[] arr)
// {
//     string st = "";
//     for (int i = 0; i < arr.Length; i++)
//     {
//         st += arr[i];
//     }
//     return st;
// }





char[] chars = new char[] {'a', 'b', 'c', 'd'};

Console.WriteLine(CharsOfSttring(chars));

