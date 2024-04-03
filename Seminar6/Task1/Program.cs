// Задайте массив символов (тип char []). Создайте строку из 
// символов этого массива. 
// Указание
// Конструктор строки вида string(char []) не использовать.
// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

string CharrArrauToString(char[] chars)
{
    string strResult = string.Empty;

    for (int i = 0; i < chars.Length; i++)
    {
        strResult += chars[i]; // C#
                               // strResult = strResult + chars[i]; // Java
    }

    return strResult;
}

char[] chars = { 'a', 'b', 'c', 'd' };

string strResult = CharrArrauToString(chars);

Console.WriteLine(strResult);

