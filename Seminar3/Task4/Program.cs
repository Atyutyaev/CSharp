// Дано натуральное трёхзначное число. Создайте массив, состоящий из 
// цифр этого числа. Младший разряд числа должен располагаться на 0-
// м индексе массива, старший – на 2-м. 
// Пример
// 456  =>  [6 5 4]
// 781  =>  [1 8 7]


Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
{
    Console.Write("Некорректный ввод");
    return;
}


    int[] result = new int[3];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = num % 10;
        num /= 10;
    }

    for (int i = 0; i < result.Length; i++)
    {
        Console.Write(result[i] + " ");
    }

