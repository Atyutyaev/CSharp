﻿// Задайте  массив.  Напишите  программу,  которая  определяет, 
// присутствует  ли  заданное  число  в  массиве.  Программа 
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// 1. Получаем/задаем исходные данные.
//int[] array = new int[6]{1, 3, 4, 19, 3, 8};
int[] array = {1, 3, 4, 19, 3, 8};
int num = 8;

// 2. Проверка исходных данных (при необходимости).

// 3. Реализация логики.
bool res = false;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] == num)
    {
        res = true;
        break;
    }
}

// 4. Вывод результата.
Console.WriteLine(res ? "Да" : "Нет");

