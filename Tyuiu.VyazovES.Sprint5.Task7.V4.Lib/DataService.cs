using System.Globalization;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VyazovES.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string filePath)
        {


            string outputFilePath = @"С:\DataSprint5\OutPutDataFileTask7V4.txt";


            string content = File.ReadAllText(filePath);
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

