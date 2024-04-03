// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива. 

// char[,] CreateMatrixChar(int row, int column)
// {
//     Random rnd = new Random();
//     char[,] charMatrix = new char[row, column];
//     for (int i = 0; i < charMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < charMatrix.GetLength(1); j++)
//         {
//             charMatrix[i, j] = (char)rnd.Next('a', 'z' + 1);
//         }
//     }
//     return charMatrix;
// }

// void PrintCharMatrix(char[,] charMatrix)
// {
//     for (int i = 0; i < charMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < charMatrix.GetLength(1); j++)
//         {
//             Console.Write($"{charMatrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// string CharMatrixToString(char[,] charMatrix)
// {
//     string str = "";
//     for (int i = 0; i < charMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < charMatrix.GetLength(1); j++)
//         {
//             str += charMatrix[i, j];
//         }
//     }
//     return str;
// }

// char[,] charMatrix = CreateMatrixChar(2, 2);

// PrintCharMatrix(charMatrix);

// string str = CharMatrixToString(charMatrix);

// Console.WriteLine(str);

// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 

// Console.WriteLine(str);
// string result;

// string StringUpperToLower(string str)
// {
// string result = string.Empty;
// for (int i = 0; i < str.Length; i++)
// {
//     int value = (int)(str[i]);
//     if (value >= 65 && value <= 90)
//     {
//         result = result + (char)(value + 32);
//     }
//     else
//     {
//         result = result + str[i];
//     }
// }
// return result;
// }

// Console.WriteLine("Введите строку=");

// string str = Console.ReadLine();

// string result = StringUpperToLower(str);

// Console.WriteLine(result);

// // Задача 3: Задайте произвольную строку. Выясните,
// // является ли она палиндромом.


bool IsStringPalindrome(string str)
{
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[str.Length - i - 1])
            return false;
    }
    return true;

}

Console.WriteLine("Введите строку палиндром");
string str = Console.ReadLine();

// Console.WriteLine(IsStringPalindrome(str) ? "Строка палиндром" : "Строка не палиндром");
// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// // Задача 4*(не обязательная): Задайте строку, состоящую
// // из слов, разделенных пробелами. Сформировать строку,
// // в которой слова расположены в обратном порядке. В
// // полученной строке слова должны быть также разделены
// // пробелами.

// // “Hello my world” => “world my Hello”

// string ReverseWordInStrin(string str)
// {
//     string[] arrayWord = str.Split(' ');
//     string result = string.Empty;
//     for (int i = arrayWord.Length - 1; i >= 0; i--)
//     {
//         if (i != 0)
//         {
//             result += arrayWord[i] + " ";
//         }
//         else
//         {
//             result += arrayWord[i];
//         }
//     }
//     return result;
// }

// Console.WriteLine("Введите строку");

// string str = Console.ReadLine();

// string revesreWord = ReverseWordInStrin(str);

// Console.WriteLine(revesreWord);