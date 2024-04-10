// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, 
// не использовать циклы.

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(arr[index]);
            PrintArrayReverse(arr, index - 1);
        }
    }

    static void Main(string[] args)
    {
        // Произвольный массив
        int[] array = { 1, 2, 5, 0, 10, 34 };

        Console.WriteLine("Элементы массива, начиная с конца:");
        PrintArrayReverse(array, array.Length - 1);
    }
}