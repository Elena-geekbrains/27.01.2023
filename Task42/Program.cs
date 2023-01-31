/* Задача 42
Преобразовать десятичное в двоичное
45 -> 101101
3 -> 11*/

Console.WriteLine("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int BinaryNumber(int num)
{
    int res = 0;
    int count = 1;
    while (num > 0)
    {
        res += num % 2 * count;
        num /= 2;
        count *= 10;
    }
    return res;
}

int result = BinaryNumber(number);
Console.WriteLine(result);