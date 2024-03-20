﻿//Напишите программу, которая выводит третью с 
//конца цифру заданного числа или сообщает, что 
//третьей цифры нет.
//456  =>  6
//7812  =>  8
//91  =>  Третьей цифры нет

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
//Возьмем число 456789
if (num < 0)
{
    num = num * -1;
}
if (num > 99)
{
    while (num > 999) //45678 > 999; 4567 > 999; 456 > 999
    {
        num /= 10; //456789 / 10 = 45678; 45678 / 10 = 4567; 4567 / 10 = 456
    }
    Console.WriteLine($"Третья цифра = {num % 10}");
}

else
{
    Console.WriteLine("Нет третьей цифры");
}