﻿// // Задайте двумерный массив. Найдите элементы, у которых оба 
// // индекса чётные, и замените эти элементы на их квадраты.
// // Пример

//     0  1  2  3

// 0   2  3  4  3   
// 1   4  3  4  1      
// 2   2  9  5  4

// //  4  3  4  3 
// //  4  3  4  1
// //  2  9  25 4



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

void ReplaceElemEvenIdxToSquare (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; i < matrix.GetLength(1); i+=2)
        {
            //if(i % 2 = 0 && j % 2 = 0)
            //{
               matrix[i, j] *= matrix[i, j];
            //}
        }
    }
}

int[ , ] array2d = CreateNatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();

ReplaceElemEvenIdxToSquare(array2d);
PrintMatrix(array2d);
