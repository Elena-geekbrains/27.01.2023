/*Задача 34
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] CreateArrayRndItn(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
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

int ReturnAmountOfEvenNumers(int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) amount++;
    }
    return amount;
}

int[] arr = CreateArrayRndItn(4);
PrintArray(arr);
int amountOfEvenNumers = ReturnAmountOfEvenNumers(arr);
Console.WriteLine($"-> {amountOfEvenNumers}");