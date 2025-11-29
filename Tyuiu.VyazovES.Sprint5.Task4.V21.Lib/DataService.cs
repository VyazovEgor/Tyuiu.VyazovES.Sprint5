using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VyazovES.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string s)
        {
            string data = File.ReadAllText(s);
            double x = double.Parse(data, CultureInfo.InvariantCulture);

            // Вычисление по формуле: y = x³ * cos(x) + 2x
            double result = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;

            // Округление до трёх знаков после запятой
            result = Math.Round(result, 3);
            return result;
        }
    }
}

