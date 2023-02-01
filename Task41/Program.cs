/*Задача 41
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine("Введите проверяемое число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine($"{arr[i]} ");
    }
}

int ReturnAmountPositivNumers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0) count++;
    }
    return count;
}

Console.WriteLine("Введите количество проверяемых чисел: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int[] array = GetArray(number);
    PrintArray(array);
    int amountPositivNumers = ReturnAmountPositivNumers(array);
    Console.WriteLine($"Количество чисел больше нуля -> {amountPositivNumers}");
}
else Console.WriteLine("Ошибка ввода!");



