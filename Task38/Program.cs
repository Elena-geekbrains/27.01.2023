/*Задача 38
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2 */

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("] ");
}

double GetMaxMinDif(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    double dif = max - min;
    double result = Math.Round(dif, 2);
    return result;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArrayRndDouble(size, 0, 10);
PrintArray(arr);

double difMaxMin = GetMaxMinDif(arr);
Console.WriteLine($"-> {difMaxMin}");