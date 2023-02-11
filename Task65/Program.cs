/*Задача 63
Задайте значение N,M. Вывести все натуральные число в промежутке от M до N. */

Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(numberM, numberN);

void NaturalNumbers(int num1, int num2)
{
    Console.Write($"{num1} ");
    if (num1 == num2) return;
    if (num1 > num2) NaturalNumbers(num1 - 1, num2);
    else NaturalNumbers(num1 + 1, num2);
}