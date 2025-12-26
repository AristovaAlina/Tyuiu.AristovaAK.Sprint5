using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AristovaAK.Sprint5.Task5.V28.Lib
{
    public class DataService : ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
        {
            double min = Double.MaxValue;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (double.TryParse(line, out double number))
                    {
                        if ((number < min) && (number % 5 == 0) && (number > 0)) min = number;
                    }
                }
            }

            double factorial = 1;
            for (int i = 1; i <= (int)min; i++)
            {
                factorial *= i;
            }

            return Math.Round(factorial, 3);
            

        }
    }
}
