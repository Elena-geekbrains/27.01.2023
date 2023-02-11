/*Задача 67
Принимаем число и возвращаем сумму его цифр. */

int SumDigit(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigit(num / 10);
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);