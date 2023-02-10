/*Задача 56
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

//1. Метод, задающий двумерный массив из целых чисел.
int[,] CreateMatrixRndItn(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//2. Метод, выводящий созданный в п.1 двумерный массив.
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine(" | ");
    }
    Console.WriteLine();
}

// 3. Метод, находящий сумму элементов по строкам
int[] GetRowElemSum(int[,] matrix)
{
    int[] rowElemSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowElemSum[i] += matrix[i, j];
        }
    }
    return rowElemSum;
}

//4. Метод, выводящий полученный в п.3 массив.
void PrintArray(int[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],4} | ");
        else Console.Write($"{array[i],4}");
    }
    Console.Write(" | ");
    Console.WriteLine();
}

// 5. Метод поиска строки с наименьшей суммой элементов
int GetRowNumberMinSum(int[] arr)
{
    int minSum = arr[0];
    int rowIndex = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (minSum > arr[i])
        {
            minSum = arr[i];
            rowIndex = i;
        }
    }
    return rowIndex;
}
int[,] array2D = CreateMatrixRndItn(5, 5, 0, 9);
PrintMatrix(array2D);

int[] rowElemSumArray = GetRowElemSum(array2D);
PrintArray(rowElemSumArray);

int rowNumber = GetRowNumberMinSum(rowElemSumArray);
Console.WriteLine($"Cтрока с наименьшей суммой элементов: {rowNumber + 1}");