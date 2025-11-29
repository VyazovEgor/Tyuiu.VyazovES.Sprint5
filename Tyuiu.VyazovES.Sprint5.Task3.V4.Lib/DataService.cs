using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VyazovES.Sprint5.Task3.V2.Lib
{
    public class DataService : ISprint5Task3V2
    {
        public string SaveToFileTextData(int start)
        {
            double x = 3;

            // Вычисление выражения y = e^x / x
            double result = Math.Exp(x) / x;

            // Округление до трёх знаков после запятой
            result = Math.Round(result, 3);

            // Сохранение в бинарный файл
            string fileName = "OutPutFileTask3.bin";
            string tempPath = Path.GetTempPath();
            string fullPath = Path.Combine(tempPath, fileName);

            using (BinaryWriter writer = new BinaryWriter(File.Open(fullPath, FileMode.Create)))
            {
                writer.Write(result);
            }

            return fullPath;
        }
    }
}

