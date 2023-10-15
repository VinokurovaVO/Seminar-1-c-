using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {
        // Введите свое решение ниже

﻿Console.WriteLine("Введите первое число");
int firstNumber = Console.ReadLine();
Console.WriteLine("Введите второе число");
int secondNumber = Console.ReadLine();

        if(Convert.ToInt32(firstNumber)) > (Convert.ToInt32(secondNumber))
{
Console.WriteLine("Первое число `firstNumbe` больше чем второе число `secondNumber");
}

if(Convert.ToInt32(firstNumber)) < (Convert.ToInt32(secondNumber))
{
Console.WriteLine("Первое число `firstNumbe` меньше чем второе число `secondNumber");
}

if(Convert.ToInt32(firstNumber)) = (Convert.ToInt32(secondNumber))
{
Console.WriteLine("Введенные числа равны `firstNumbe`");
}

    }

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            firstNumber = 5;
            secondNumber = 5;
        }

        // Не удаляйте строки ниже
        CompareNumbers(firstNumber, secondNumber);
    }
}