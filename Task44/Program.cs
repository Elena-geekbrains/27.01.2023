/* Задача 44
Не используя рекурсию, вывести первые N чисел Фибоначчи.
N = 5 -> 01123 */

int[] Fibonacci(int num)
{
    int[] array = new int[num];
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
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

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int[] fibonacci = Fibonacci(number);
    Console.Write($"Если N = {number} -> ");
    PrintArray(fibonacci);
}
else Console.WriteLine("Ошибка ввода!");