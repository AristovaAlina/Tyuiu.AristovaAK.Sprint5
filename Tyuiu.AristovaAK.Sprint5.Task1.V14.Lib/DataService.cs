using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AristovaAK.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string result = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = Math.Sin(x) / (x + 1.7) - Math.Cos(x) * 4 * x - 6;
                y = Math.Round(y, 2);

                string str = y.ToString("F2").Replace(".", ",").TrimEnd('0').TrimEnd(',');

                if (x > startValue)
                    result += "\n";
                result += str;
            }
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            File.WriteAllText(path, result);
            return path;
        }
    }
}
