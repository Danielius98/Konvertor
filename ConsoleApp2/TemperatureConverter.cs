using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


    // Метод для конвертации температуры
  using System;

public class TemperatureConverter
{
    public double ConvertTemperature(double temperature, string sourceUnit, string targetUnit)
    {
        if (sourceUnit.ToUpper() == "K" && temperature < 0)
        {
            throw new ArgumentException("Недопустимое значение температуры. Температура по Кельвину не может быть отрицательной.");
        }

        switch (sourceUnit.ToUpper())
        {
            case "C":
                if (targetUnit.ToUpper() == "F")
                {
                    return CelsiusToFahrenheit(temperature);
                }
                else if (targetUnit.ToUpper() == "K")
                {
                    return CelsiusToKelvin(temperature);
                }
                break;
            case "F":
                if (targetUnit.ToUpper() == "C")
                {
                    return FahrenheitToCelsius(temperature);
                }
                else if (targetUnit.ToUpper() == "K")
                {
                    return FahrenheitToKelvin(temperature);
                }
                break;
            case "K":
                if (targetUnit.ToUpper() == "C")
                {
                    return KelvinToCelsius(temperature);
                }
                else if (targetUnit.ToUpper() == "F")
                {
                    return KelvinToFahrenheit(temperature);
                }
                break;
            default:
                throw new InvalidTemperatureException("Недопустимая единица измерения температуры.");
        }

        throw new InvalidOperationException("Недопустимое преобразование температуры.");
    }

    private double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    private double CelsiusToKelvin(double celsius)
    {
        return celsius + 273.15;
    }

    private double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    private double FahrenheitToKelvin(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9 + 273.15;
    }

    private double KelvinToCelsius(double kelvin)
    {
        return kelvin - 273.15;
    }

    private double KelvinToFahrenheit(double kelvin)
    {
        return (kelvin - 273.15) * 9 / 5 + 32;
    }
}
