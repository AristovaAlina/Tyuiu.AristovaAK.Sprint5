using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.AristovaAK.Sprint5.Task3.V13.Lib
{
    public class DataService : ISprint5Task3V13
    {
        public string SaveToFileTextData(int x)
        {
            double y = (double)x / (Math.Pow(x, 3) + 2);
            y = Math.Round(y, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(y);
            }

            return path;
        }
    }
}
