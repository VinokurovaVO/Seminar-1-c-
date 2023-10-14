// Задача №5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
Console.WriteLine("введите число");
int input = Convert.ToInt32(Console.ReadLine());
int minusInput = -input;
while (input >= minusInput)
{
Console.Write(minusInput);

minusInput += 1;
}
