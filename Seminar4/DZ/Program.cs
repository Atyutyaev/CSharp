// Задача №1.
// Напишите программу, которая бесконечно 
// запрашивает  целые  числа  с  консоли.  Программа 
// завершается при вводе символа ‘q’ или при вводе 
// числа,  сумма  цифр  которого  четная.
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

// Console.WriteLine("Введите целые числа. Для завершения введите 'q' или число, сумма цифр которого чётная.");

// while (true)
// {
//     Console.Write("Введите число: ");
//     string input = Console.ReadLine();

//     if (input.ToLower() == "q") // Проверяем, является ли введенная строка символом 'q'
//     {
//         Console.WriteLine("Программа завершена по запросу пользователя.");
//         break;
//     }

//     if (IsEvenDigitsSum(input)) // Проверяем, является ли сумма цифр числа чётной
//     {
//         Console.WriteLine($"Сумма цифр числа {input} чётная. Программа завершена.");
//         break;
//     }
// }

// // Функция для определения, является ли сумма цифр числа чётной
// static bool IsEvenDigitsSum(string numberStr)
// {
//     int sum = 0;
//     foreach (char digitChar in numberStr)
//     {
//         if (!char.IsDigit(digitChar)) // Проверяем, является ли символ числом
//         {
//             return false; // Если не число, завершаем функцию и продолжаем цикл
//         }

//         int digit = digitChar - '0'; // Преобразуем символ в числовое значение
//         sum += digit; // Добавляем значение цифры к сумме
//     }

//     return sum % 2 == 0; // Проверяем, является ли сумма чётной
// }


// Задача №2
// Задайте массив заполненный случайными 
// трёхзначными  числами.  Напишите  программу, 
// которая  покажет  количество  чётных  чисел  в 
// массиве.
// [344 452 341 125] => 2

// Console.Write("Введите количество элементов массива: ");
// int a = Convert.ToInt32(Console.ReadLine());
// int[] randomArray = new int[a];

// void mas(int a)
// {
//     for (int i = 0; i < a; i++)
//     {
//         randomArray[i] = new Random().Next(99, 999);
//         Console.Write(randomArray[i] + " ");
//     }

// }

// int kol(int[] randomArray)
// {
//     int kol = 0;
//     for (int i = 0; i < randomArray.Length; i++)
//     {
//         if (randomArray[i] % 2 == 0)
//             kol = kol + 1;
//     }
//     return kol;
// }

// mas(a);
// Console.Write($"\nКоличество чётных чисел в массиве: { kol(randomArray)}");



