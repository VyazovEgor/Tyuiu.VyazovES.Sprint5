using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VyazovES.Sprint5.Task0.V10.Lib
{
    public class DataService : ISprint5Task0V10
    {
        public string SaveToFileTextData(int a)
        {
            double x = 2;
            double result = 1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x;

            result = Math.Round(result, 3);

            string fileName = "OutPutFileTask0.txt";
            string tempPath = Path.GetTempPath();
            string fullPath = Path.Combine(tempPath, fileName);

            // Сохранение результата в файл
            File.WriteAllText(fullPath, result.ToString());

            return fullPath;
        }
    }
}

