using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VyazovES.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string filePath)
        {
            string inputFileName = "InPutDataFileTask7V4.txt";
            string outputFileName = "OutPutDataFileTask7V4.txt";

            // Используем временную директорию
            string tempPath = Path.GetTempPath();
            string inputFilePath = Path.Combine(tempPath, inputFileName);
            string outputFilePath = Path.Combine(tempPath, outputFileName);


            string content = File.ReadAllText(inputFilePath);
            StringBuilder result = new StringBuilder();

            foreach (char c in content)
            {
                if ((c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я') || c == 'Ё' || c == 'ё')
                {
                    result.Append('#');
                }
                else
                {
                    result.Append(c);
                }
            }

            File.WriteAllText(outputFilePath, result.ToString());
            return outputFilePath;
        }
            
    }
}

