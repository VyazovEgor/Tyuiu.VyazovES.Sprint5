using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VyazovES.Sprint5.Task1.V17.Lib
{
    public class DataService : ISprint5Task1V17
    {
        public string SaveToFileTextData(int start, int end)
        {
            int step = 1;
            string fileName = "OutPutFileTask1.txt";
            string tempPath = Path.GetTempPath();
            string fullPath = Path.Combine(tempPath, fileName);
            for (int x = start; x <= end; x += step)
            {
                double result;

                double denominator = Math.Sin(x) + 1;
                if (Math.Abs(denominator) < 1e-10)
                {
                    result = 0;
                }
                else
                {
                    result = 2 * x - 4 + (2 * x - 1) / denominator;
                }

                result = Math.Round(result, 2);

                File.AppendAllText(fullPath, $"{result}\n");
            }

                return fullPath;
        }
    }
}

