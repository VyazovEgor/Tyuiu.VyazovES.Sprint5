using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VyazovES.Sprint5.Task2.V12.Lib
{
    public class DataService : ISprint5Task2V12
    {
        public string SaveToFileTextData(int [,] array)
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array[i, j] > 0)
                        array[i, j] = 1;
                    else if (array[i, j] < 0)
                        array[i, j] = 0;
                }
            }

            string fileName = "OutPutFileTask2.csv";
            string tempPath = Path.GetTempPath();
            string fullPath = Path.Combine(tempPath, fileName);
            return fullPath;
        }
    }
}

