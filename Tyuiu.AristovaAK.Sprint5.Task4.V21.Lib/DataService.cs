using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AristovaAK.Sprint5.Task4.V21.Lib
{
    public class DataService : ISprint5Task4V21
    {
        public double LoadFromDataFile(string path)
        {
            {
                string strX = File.ReadAllText(path);
                double x = Convert.ToDouble(strX);
                double res = Math.Pow(x, 3) * Math.Cos(x) + 2 * x;
                res = Math.Round(res, 3);

                return res;
            }
        }
    }
}
