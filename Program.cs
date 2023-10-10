using System;

public class Calculator
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            double firstValue, secondValue;
            string action;
            try
            {
                Console.WriteLine("Первое число:");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Операция (+, -, *, /):");
                action = Console.ReadLine();

                Console.WriteLine("Второе число:");
                secondValue = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Введен неизвестный символ");
                Console.ReadLine();
                continue;
            }
            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;

                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;

                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;

                case "/":

                    if (secondValue == 0)
                    {
                        Console.WriteLine("Деление на 0 ошибочно");
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    break;

                default:
                    Console.WriteLine("Неизвестное действие");
                    break;
            }
            Console.ReadLine(); 
        }
    }
}