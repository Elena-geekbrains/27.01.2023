/* Задача 29
Напишите программу, которая задаёт массив из 8 элементовb выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33] */

int[] ArrayGeneration(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

int[] array = ArrayGeneration(8);
for (int i = 0; i < array.Length; i++)
{
    if (i == array.Length - 1) Console.Write($"{array[i]} -> ");
    else Console.Write($"{array[i]}, ");
}
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (i == array.Length - 1) Console.Write($"{array[i]} ");
    else Console.Write($"{array[i]}, ");
}
Console.Write("]");