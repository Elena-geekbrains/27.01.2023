/* Задача 45
Создать копию заданного массива с помощью поэлементного копирования. */

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
    Console.WriteLine("]");
}

int[] CoppyArray(int[] arr)
{
    int[] coppyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        coppyArray[i] = arr[i];
    }
    return coppyArray;
}

int[] firstArray = CreateArrayRndItn(5, 0, 10);
int[] coppyArray = CoppyArray(firstArray);
PrintArray(firstArray);
PrintArray(coppyArray);