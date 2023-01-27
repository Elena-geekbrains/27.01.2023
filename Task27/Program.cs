/*Задача 27
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int CountDigit(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int countDigit = CountDigit(number);
int sum = 0;
for (int i = 0; i < countDigit; i++)
{
    sum += number % 10;
    number /= 10;
}
Console.WriteLine($"Сумма цифр в задвнном числе: {sum}.");
