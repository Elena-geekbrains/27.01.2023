/*Задача 59
Задать двумерный массив из целых чисел.
Удалить строку и столбец, на пересечении наименьшего эл-та.*/

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

// Поиск минимального значения в двумерной матрице
int[] MinIndexElementsMatrix(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] arrayIndexMin = new int[2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                arrayIndexMin[0] = i;
                arrayIndexMin[1] = j;
            }
        }
    }
    return arrayIndexMin;
}

// Исключение строки и столбца на пересечении наименьшего эл-та
int[,] MatrixWithoutMinElem(int[,] matrix, int[] minIndex)
{
    int[,] matrixWithoutMinElem = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int m = 0, n = 0;
    for (int i = 0; i < matrixWithoutMinElem.GetLength(0); i++)
    {
        if (m == minIndex[0]) m++;
        for (int j = 0; j < matrixWithoutMinElem.GetLength(1); j++)
        {
            if (n == minIndex[1]) n++;
            matrixWithoutMinElem[i, j] = matrix[m, n];
            n++;
        }
        n = 0;
        m++;
    }
    return matrixWithoutMinElem;
}

int[,] array2D = CreateMatrixRndItn(4, 4, 0, 9);
PrintMatrix(array2D);
int[] minIndexElementsMatrix = MinIndexElementsMatrix(array2D);
Console.WriteLine();
int[,] matrixWithoutMinElem = MatrixWithoutMinElem(array2D, minIndexElementsMatrix);
PrintMatrix(matrixWithoutMinElem);
