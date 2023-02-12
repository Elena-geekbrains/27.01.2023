/*Задача 69
Принимаем А и В, возвращаем А в натуральной степени В с помощью рекурсии.*/


int Powering(int num1, int num2)
{
    return num2 == 0 ? 1 : num1 = num1 * Powering(num1, num2 - 1);
}

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int powering = Powering(numberA, numberB);
Console.WriteLine(powering);