/* Задача 57
Составить частотны словарь в двумерном массиве (сколько раз встречается эл-т)*/

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

//  Метод, создания одномерного массива из матрицы
int[] MatrixToArray(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count++] = matrix[i, j];
        }
    }
    return result;
}

//  Метод, печати одномерного массива из матрицы
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void GetSameCountNumbers(int[] arr)
{
    int num = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (num == arr[i]) count++;
        else
        {
            Console.WriteLine($"Число {num} встречается {count} раз(а).");
            num = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Число {num} встречается {count} раз(а).");
}

int[,] array2D = CreateMatrixRndItn(2, 2, 0, 9);
PrintMatrix(array2D);
int[] matrixToArray = MatrixToArray(array2D);
Array.Sort(matrixToArray);
PrintArray(matrixToArray);
GetSameCountNumbers(matrixToArray);