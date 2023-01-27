/*Задача 25
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int RaiseToPower(int num, int power)
{
    int result = 1;
    for (int i = 0; i < power; i++)
    {
        result *= num;
    }
    return result;
}

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
    int raiseToPower = RaiseToPower(a, b);
    Console.WriteLine($"{a} в степени {b} равно {raiseToPower}.");
}
else Console.WriteLine("Ошибка ввода!");