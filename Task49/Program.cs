/*Задача 49
Двумерный массив. Элементы с четными индексами одновременно, заменить на их квадраты.
1 4 7 2       1 4 49 2
5 9 2 3       5 9 2 3
8 4 2 4       64 4 4 4
*/

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

void SquareEvenElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] array2D = CreateMatrixRndItn(3, 4, 0, 10);
PrintMatrix(array2D);
SquareEvenElem(array2D);
Console.WriteLine("Четные элементы заменены на их квадраты:");
PrintMatrix(array2D);