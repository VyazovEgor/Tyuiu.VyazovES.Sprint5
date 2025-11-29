using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VyazovES.Sprint5.Task5.V22.Lib
{
    public class DataService : ISprint5Task5V22
    {
        public double LoadFromDataFile(string filePath)
        {
            // Чтение всего текста из файла
            string text = File.ReadAllText(filePath);

            // Разделение на числа (предполагаем разделитель - запятая)
            string[] numberStrings = text.Split(new char[] {' ', '\t', '\n', '\r' },
                                                StringSplitOptions.RemoveEmptyEntries);

            double? minDivisibleBy4 = null; // Используем nullable double

            foreach (string numberStr in numberStrings)
            {
                // Пытаемся распарсить как целое число
                if (int.TryParse(numberStr.Trim(), out int intNumber))
                {
                    if (intNumber % 4 == 0)
                    {
                        if (minDivisibleBy4 == null || intNumber < minDivisibleBy4)
                        {
                            minDivisibleBy4 = intNumber;
                        }
                    }
                }
                // Если не целое, пробуем как вещественное и округляем
                else if (double.TryParse(numberStr.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double doubleNumber))
                {
                    int roundedNumber = (int)Math.Round(doubleNumber, 0);

                    if (roundedNumber % 4 == 0)
                    {
                        if (minDivisibleBy4 == null || roundedNumber < minDivisibleBy4)
                        {
                            minDivisibleBy4 = roundedNumber;
                        }
                    }
                }
            }

            // Если не найдено чисел, кратных 4, возвращаем 0 или бросаем исключение
            return minDivisibleBy4 ?? 0;
        }
    }
}

