//Задача 1.
//Напишите программу, которая принимает 
//на вход число и проверяет, кратно ли оно 
//одновременно 7 и 23
//a=50   => нет
//a=7    => нет
//a=322  => да

//Console.WriteLine("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());

//int result1 = num % 7;
//int result2 = num % 23;
//if (result1 == 0 && result2 == 0)
//{
//    Console.WriteLine("да");
//}
//else
//{
//    Console.WriteLine("нет");
//}

//Задача 2.
//Напишите программу, которая принимает 
//на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 
//0 и выдаёт номер координатной четверти плоскости, 
//в которой находится эта точка.
//2,  3    =>   1
//-5, 3    =>   2
//-3, -2   =>   3
//4, -2    =>   4


//Console.WriteLine("Введите число x: ");
//int x = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите число y: ");
//int y = Convert.ToInt32(Console.ReadLine());

//if (x > 0 && y > 0)
//{
//    Console.WriteLine("1");
//}
//else if (x < 0 && y > 0)
//{
//    Console.WriteLine("2");
//}
//else if (x < 0 && y < 0)
//{
//    Console.WriteLine("3");
//}
//else if (x > 0 && y < 0)
//{
//    Console.WriteLine("4");
//}
//else
//{
//    Console.WriteLine("Некорректный ввод");
//}

//Задача 3.
// Напишите программу, которая принимает 
// на вход целое число из отрезка [10, 99] и показывает 
// наибольшую цифру числа.
// 40  => 4
// 96  => 9
// 72  => 7


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 10 && num <=99)
// {
//     int digit1 = num / 10;
//     int digit2 = num % 10;
//     int max = digit1;

//     if (digit2 > max)
//     {
//         Console.WriteLine(digit2);
//     }
//     else
//     {
//         Console.WriteLine(digit1);
//     }
// }
// else
// {
//     Console.WriteLine("Некорректный ввод");
// }

//Задача 4.
// Напишите программу, которая на вход 
// принимает натуральное число N, а на выходе 
// показывает его цифры через запятую.
// 568  => 5,6,8
// 8    => 8
// 9542 => 9,5,4,2


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num > 0)
// {
//     int digit1 = num / 100000;
//     Console.Write(digit1 + ",");    
//     int digit2 = num / 10000 - digit1 * 10;
//     Console.Write(digit2 + ",");
//     int digit3 = num / 1000 - digit1 * 100 - digit2 * 10;
//     Console.Write(digit3 + ",");
//     int digit4 = num / 100 - digit1 * 1000 - digit2 * 100 - digit3 * 10;
//     Console.Write(digit4 + ",");
//     int digit5 = num / 10 - digit1 * 10000 - digit2 * 1000 - digit3 * 100 - digit4 * 10;
//     Console.Write(digit5 + ",");
//     int digit6 = num % 10;  
//     Console.Write(digit6 + ",");
// }
// else
// {
//     Console.WriteLine("Некорректный ввод");
// }
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = 0;
int y =  (int)Math.Log10(num) + 1;
while (num > 0)
{
    result *= 10;
    result += num % 10;
    num /= 10;
}
for (int i = 0; i < y; i++)
{
    Console.Write(result % 10 + " ");
    result /= 10;
}


