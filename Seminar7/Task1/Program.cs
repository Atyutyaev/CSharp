// Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в 
// промежутке от M до N. Использовать рекурсию, 
// не использовать циклы.

void NaturalNumbersBetweenMN(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m}");
        return;
    }

    Console.Write($"{m}, ");
    NaturalNumbersBetweenMN(m + 1, n);
}

void NaturalNumbersBetweenNM(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m}");
        return;
    }

    Console.Write($"{m}, ");
    NaturalNumbersBetweenNM(m - 1, n);
}

void GenerateSequence(int m, int n)
{
    if (m < n)
    {
        NaturalNumbersBetweenMN(m, n);
    }
    else if (m > n)
    {
        NaturalNumbersBetweenNM(m, n);
    }
    else
    {
        Console.Write(n); 
    }
}

Console.WriteLine("Введите первое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = Convert.ToInt32(Console.ReadLine());

GenerateSequence(m, n);