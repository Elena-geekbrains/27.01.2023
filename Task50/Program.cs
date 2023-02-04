/*Задача 50
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого элемента в массиве нет */

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

bool FindMatrixElem(int[,] matrix, int rows, int colums)
{
    return rows-1 < matrix.GetLength(0) && colums-1 < matrix.GetLength(1);
}

Console.WriteLine("Введите номер строки: ");
int rowsNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int columsNumber = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndItn(3, 4, 0, 10);
PrintMatrix(array2D);
bool result = FindMatrixElem(array2D,rowsNumber,columsNumber);

Console.WriteLine(result ? $"Значение искомого элемента {array2D [rowsNumber-1,columsNumber-1]}" 
                         : $"{rowsNumber},{columsNumber} -> такого элемента в массиве нет");