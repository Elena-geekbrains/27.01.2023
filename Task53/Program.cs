// Задача 53
// Поменять первую и прследнюю строки в двумерном массиве местами

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

//3. Метод, меняющий первую и прследнюю строки в массиве местами
void Replace(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

int[,] array2D = CreateMatrixRndItn(3, 4, 0, 9);
PrintMatrix(array2D);
Console.WriteLine("Массив с измененными строками: ");

Replace(array2D);
PrintMatrix(array2D);
