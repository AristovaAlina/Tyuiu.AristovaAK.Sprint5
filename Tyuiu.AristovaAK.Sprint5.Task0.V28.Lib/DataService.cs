using tyuiu.cources.programming.interfaces.Sprint5;
///using System.IO;
namespace Tyuiu.AristovaAK.Sprint5.Task0.V28.Lib
{
    public class DataService : ISprint5Task0V28
    {
        public string SaveToFileTextData(int x)
        {
            double y = x * Math.Sqrt(x + 3);

            y = Math.Round(y, 3);

            string folder = Path.GetTempPath(); 
            string fileName = "OutPutFileTask0.txt";
            string fullPath = Path.Combine(folder, fileName);
            
            File.WriteAllText(fullPath, y.ToString());

            return fullPath;
        }
    }
}
