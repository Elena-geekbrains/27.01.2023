/* Задача 40
Пинимает 3 числа, может ли существовать трекгольник с такими сторонами. */

Console.WriteLine("Введите первую сторону трекгольника: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону трекгольника: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону трекгольника: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool Triangle(int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
}

bool result = Triangle(number1, number2, number3);
Console.WriteLine(result
? "да, трекгольник с такими сторонами существует"
: "нет, трекгольника с такими сторонами не существует");