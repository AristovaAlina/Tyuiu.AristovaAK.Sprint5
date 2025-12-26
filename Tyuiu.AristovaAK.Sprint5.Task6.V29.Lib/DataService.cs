using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AristovaAK.Sprint5.Task6.V29.Lib
{
    public class DataService : ISprint5Task6V29
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] parts = text.Split(' ');

            int count = 0;

            foreach (string part in parts)
            {
                if (part.Length == 7) count += 1;
            }

            return count;
        }
    }
}
