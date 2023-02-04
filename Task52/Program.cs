/*Задача 52
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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
}

//3. Метод, вычисляющий среднее арифметическое элементов в каждом столбце созданного в п.1 двумерного массива.
double[] GetAvgMatrixColumns(int[,] matr)
{
    double[] arr = new double[matr.GetLength(1)];
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double sum = 0.0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }

        arr[j] = Math.Round(sum / matr.GetLength(0), 1);
    }
    return arr;
}

//4. Метод, выводящий полученный в п.3 массив.
void PrintArray(double[] array)
{
    Console.Write("|");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i],4} | ");
        else Console.Write($"{array[i],4}");
    }
    Console.Write(" | ");
}

int[,] array2D = CreateMatrixRndItn(3, 4, 0, 10);
PrintMatrix(array2D);

double[] array = GetAvgMatrixColumns(array2D);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
PrintArray(array);