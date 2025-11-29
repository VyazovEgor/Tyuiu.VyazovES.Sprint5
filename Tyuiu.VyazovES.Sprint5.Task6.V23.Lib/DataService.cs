using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.VyazovES.Sprint5.Task6.V23.Lib
{
    public class DataService : ISprint5Task6V23
    {
        public int LoadFromDataFile(string filePath)
        {
            string text = File.ReadAllText(filePath);

            string content = File.ReadAllText(filePath);
            int dashCount = content.Count(c => c == '-');
            return dashCount;
        }
    }
}

