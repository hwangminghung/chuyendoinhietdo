using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("Menu:\n1. Fahrenheit to Celsius\n2. Celsius to Fahrenheit\n0. Exit");
            Console.WriteLine("Nhap lua chon cua ban:");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ConvertFahrenheitToCelsius();
                    break;
                case 2:
                    ConvertCelsiusToFahrenheit();
                    break;
                case 0:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le");
                    break;
            }

            Console.WriteLine();
        } while (choice != 0);
    }

    static void ConvertFahrenheitToCelsius()
    {
        Console.Write("Nhap gia tri Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine($"{fahrenheit} do Fahrenheit = {celsius} do Celsius");
    }

    static void ConvertCelsiusToFahrenheit()
    {
        Console.Write("Nhap gia tri Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;

        Console.WriteLine($"{celsius} do Celsius = {fahrenheit} do Fahrenheit");
    }
}