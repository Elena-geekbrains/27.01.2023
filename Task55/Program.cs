// Задача 55
// Вдвумерном массиве заменить столбцы настроки или вывести сообщение о невозможности

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

//3. Метод, заменяющий столбцы настроки
int[,] ChangeColumsToRows(int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[j, i] = matrix[i, j];
        }
    }
    return newMatrix;
}


int[,] array2D = CreateMatrixRndItn(4, 4, 0, 9);
PrintMatrix(array2D);

if (array2D.GetLength(0) == array2D.GetLength(1))
{
    int[,] columsToRows = ChangeColumsToRows(array2D);
    Console.WriteLine("Cтолбцы заменены на строки: ");
    PrintMatrix(columsToRows);
}
else Console.WriteLine("Заменить столбцы на строки без потери данных невозможно!");