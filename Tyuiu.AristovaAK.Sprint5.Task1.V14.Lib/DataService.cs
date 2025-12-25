using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AristovaAK.Sprint5.Task1.V14.Lib
{
    public class DataService : ISprint5Task1V14
    {
        public double[,] GetFunctionTable(int startValue, int stopValue)
        {
            int pointCount = stopValue - startValue + 1;

            double[,] table = new double[pointCount, 2];

            for (int i = 0; i < pointCount; i++)
            {
                int x = startValue + i;
                double y = CalculateFunction(x);
                y = Math.Round(y, 2);

                table[i, 0] = x;
                table[i, 1] = y;
            }

            return table;
        }

        public string SaveToFileTextData(int startValue, int stopValue)
        {
            double[,] table = GetFunctionTable(startValue, stopValue);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Табулирование функции F(x) = sin(x)/(x+1.7) - cos(x)*4x - 6");
                writer.WriteLine($"Диапазон: [{startValue}; {stopValue}], шаг: 1");
                writer.WriteLine();
                writer.WriteLine("  x   |   F(x)   ");
                writer.WriteLine("-----------------");

                for (int i = 0; i < table.GetLength(0); i++)
                {
                    writer.WriteLine($"{table[i, 0],5:F1} | {table[i, 1],8:F2}");
                }
            }

            return path;
        }
        private double CalculateFunction(double x)
        {
            if (Math.Abs(x + 1.7) < 0.000001)
            {
                return 0;
            }

            return Math.Sin(x) / (x + 1.7) - Math.Cos(x) * 4 * x - 6;
        }
    }
}
