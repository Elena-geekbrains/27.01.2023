/*Задача 66
Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num1;
    return num1 < num2 ? num2 + SumNumbers(num1, num2 - 1) : num2 + SumNumbers(num1, num2 + 1);
}

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(numberM, numberN);

if (numberM > 0 && numberN > 0) Console.WriteLine($"M = {numberM}; N = {numberN} -> {sumNumbers}");
else Console.WriteLine("Ошибка ввода!");

