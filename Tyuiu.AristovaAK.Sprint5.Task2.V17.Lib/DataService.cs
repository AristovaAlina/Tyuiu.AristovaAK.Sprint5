using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AristovaAK.Sprint5.Task2.V17.Lib
{
    public class DataService : ISprint5Task2V17
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string res = "";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        res += "0;";
                    }
                    else
                    {
                        res += $"{matrix[i, j]};";
                    }
                    if (j == matrix.GetLength(1)) res.TrimEnd(';');
                    res += "\n";
                }
            }
            string folder = Path.GetTempPath();
            string str = "OutPutFileTask2.csv";
            string path = Path.Combine(folder, str);

            File.WriteAllText(path, res);

            return path;
        }
    }
}
