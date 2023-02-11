/*Задача 58
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

//3. Метод нахождения произведение двух матриц
int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplication = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                multiplication[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return multiplication;
}

int[,] firstMatrix = CreateMatrixRndItn(7, 5, 0, 9);
PrintMatrix(firstMatrix);

int[,] secondMatrix = CreateMatrixRndItn(3, 2, 0, 9);
PrintMatrix(secondMatrix);

if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
{
    Console.WriteLine("Умножение невозможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
}
else
{
    int[,] matrixMultiplication = MatrixMultiplication(firstMatrix, secondMatrix);
    PrintMatrix(matrixMultiplication);
}
