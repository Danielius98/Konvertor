using System;

public class InvalidTemperatureException : Exception
{
    public InvalidTemperatureException(string message) : base(message)
    {
    }
}


class Program
{
    static void Main()
    {
        TemperatureConverter converter = new TemperatureConverter();

        Console.WriteLine("Введите температуру:");
        double temperature = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите единицы измерения температуры (C, F, K):");
        string sourceUnit = Console.ReadLine();

        Console.WriteLine("Введите желаемые единицы конвертации (C, F, K):");
        string targetUnit = Console.ReadLine();

        try
        {
            double result = converter.ConvertTemperature(temperature, sourceUnit, targetUnit);
            Console.WriteLine($"Результат конвертации: {result}");
        }
        catch (InvalidTemperatureException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Ошибка: {e.Message}");
        }
    }
}