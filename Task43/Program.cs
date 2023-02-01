/*Задача 43
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double GetArgument(double b1, double k1, double b2, double k2)
{
    double xc = Convert.ToDouble(b2 - b1) / (k1 - k2);
    double xcRound = Math.Round(xc, 2);
    return xcRound;
}

double GetFunctionValue(double b1, double k1, double x)
{
    double yc = Convert.ToDouble(k1 * x + b1);
    double ycRound = Math.Round(yc, 2);
    return ycRound;
}

Console.WriteLine("Введите значение b1: ");
double constb1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1: ");
double constk1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2: ");
double constb2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2: ");
double constk2 = Convert.ToDouble(Console.ReadLine());


double x = GetArgument(constb1, constk1, constb2, constk2);
double y = GetFunctionValue(constb1, constk1, /*constb2, constk2,*/ x);
Console.WriteLine($"Точка пересечения -> ({x}; {y})");