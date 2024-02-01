// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

// string CharsToString(char[] chars)
// {
//     string str = "";
//     for (int i = 0; i < chars.Length; i++)
//     {
//         str += chars[i];
//     }
//     return str;
// }

// char[] chars = {'a', 'b', 'c', 'd'};
// string str = new string(chars);
// System.Console.WriteLine(str);

// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать.
// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 

char[] StringToChars(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}

void PrintChars(char[] chars)
{   
    System.Console.Write("[");
    for (int i = 0; i < chars.Length - 1; i++)
    {
        System.Console.Write($"'{chars[i]}', ");
    }
    System.Console.WriteLine($"'{chars[chars.Length - 1]}' ]");
}

string str = "Hello!";
System.Console.WriteLine(str.ToCharArray());