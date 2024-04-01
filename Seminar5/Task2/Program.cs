// Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и 
// т.д.
// Пример
//  2 3 4 3   
//  4 3 4 1    =>  2 + 3 + 5 = 10
//  2 9 5 4


using System.Numerics;

int[,] CreateNatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; //3 x 4
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows = 3
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns = 4
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       // Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }

        //Console.WriteLine("  |");
        Console.WriteLine( );
    }
}

int SumElementMainDiagonal(int[,] matrix)
{
    int sum = 0;
// {
//     int sum = matrix[0, 0];
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 1; j < matrix.GetLength(1); j++)
//         {
//            if (i == j) 
//            {
//             sum += matrix[i, j];
//            }
//         }
//         Console.WriteLine();
//     }
int size = 0;
if (matrix.GetLength(0) > matrix.GetLength(1))
    size = matrix.GetLength(1);
else
{
    size = matrix.GetLength(0);
}
    
for (int i = 0; i < size; i++)
{
    sum += matrix[i, i];
}
    return sum;
}

int[ , ] array2d = CreateNatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

int result = SumElementMainDiagonal(array2d);

Console.WriteLine($"Сумма элементов на главной диагонали = {result}");