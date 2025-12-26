using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AristovaAK.Sprint5.Task5.V28.Lib
{
    public class DataService : ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] parts = text.Split(' ');

            int minNumber = int.MaxValue;

            foreach (string part in parts)
            {
                if (double.TryParse(part, out double num))
                {
                    if (num == (int)num && num > 0 && num % 5 == 0)
                    {
                        int n = (int)num;
                        if (n < minNumber) minNumber = n;
                    }
                }
            }

            double fact = 1;
            for (int i = 2; i <= minNumber; i++) fact *= i;

            return Math.Round(fact, 3);
        }
    }
}
