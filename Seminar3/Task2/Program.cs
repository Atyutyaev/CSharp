﻿// Задайте  массив  из  10  элементов,  заполненный  числами  из 
// промежутка  [-10,  10].  Замените  отрицательные  элементы  на 
// положительные, а положительные на отрицательные.
// Пример
// [1 -5 6]
// => [-1 5 -6]


int[] arr = new int [10] {-5, -3, 2, 4, 5, -2, -7, 8, 10, 2};

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = arr[i] * -1; //arr[i] *= -1;
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}