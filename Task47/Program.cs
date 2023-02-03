/*Задача 47. 
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] CreateMatrixRndDouble(int rows, int colums, int min, int max)
{
    double[,] matrix = new double[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

Console.WriteLine("Введите количество строк матрицы (m): ");
int rowsM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов матрицы (n): ");
int columsN = Convert.ToInt32(Console.ReadLine());

double[,] array2D = CreateMatrixRndDouble(rowsM, columsN, -10, 10);
PrintMatrix(array2D);