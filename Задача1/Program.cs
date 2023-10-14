// Задача №1. Напишите программу, которая на вход принимает
// два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5->да
// a = 2, b = 10->нет
// a = 9, b = -3->да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число 1");
string? number1 = Console.ReadLine();
Console.WriteLine("Введите число 2");
string? number2 = Console.ReadLine();


int resultNumber2 = Convert.ToInt32(number2) * Convert.ToInt32(number2);

if (Convert.ToInt32(number1) == resultNumber2)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}
