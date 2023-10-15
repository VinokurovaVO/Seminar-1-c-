Console.WriteLine("Введите первое число");
string? number1 = Console.ReadLine();
Console.WriteLine("Введите второе число");
string? number2 = Console.ReadLine();

if(Convert.ToInt32(number1) > Convert.ToInt32(number2))
{
Console.WriteLine("Первое число больше чем второе число");
}

if(Convert.ToInt32(number1) < Convert.ToInt32(number2))
{
Console.WriteLine("Первое число меньше чем второе число");
}

if(Convert.ToInt32(number1) == Convert.ToInt32(number2))
{
Console.WriteLine("Введеные числа равны");
}
