using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AristovaAK.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            string result = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = Math.Sin(x) / (x + 1.7) - Math.Cos(x) * 4 * x - 6;
                y = Math.Round(y, 2);

                if (x > startValue)
                    result += "\n";
                result += y.ToString("F2").Replace(".", ",");
            }

            File.WriteAllText(path, result);

            return path;
        }
    }
}
