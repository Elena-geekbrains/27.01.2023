/*Задача 36
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] CreateArrayRndItn(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] ");
}

int GetSumElemOddPos(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) sum += array[i];
    return sum;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndItn(size, -10, 10);
PrintArray(arr);

int sumElemOddPos = GetSumElemOddPos(arr);
Console.WriteLine($"-> {sumElemOddPos}");