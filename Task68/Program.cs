/* Задача 68
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int AckermannFunktion(int n, int m)
{
    if (n == 0) return m + 1;
    else if ((n != 0) && (m == 0)) return AckermannFunktion(n - 1, 1);
    else return AckermannFunktion(n - 1, AckermannFunktion(n, m - 1));
}

Console.WriteLine("Введите неотрицательное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0)
{
    int ackermannFunktion = AckermannFunktion(numberM, numberN);
    Console.WriteLine($"m = {numberM}, n= {numberN} -> A ({numberM},{numberN}) = {ackermannFunktion}");
}
else Console.WriteLine("Ошибка ввода!");