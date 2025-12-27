using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.AristovaAK.Sprint5.Task7.V26.Lib
{
    public class DataService : ISprint5Task7V26
    {
        public string LoadDataAndSave(string path)
        {
            string savePath = Path.Combine(@"C:\DataSprint5", "OutPutDataFileTask7V26.txt");

            FileInfo fileInfo = new FileInfo(savePath);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(savePath);
            }

            string text = File.ReadAllText(path);

            string result = "";
            string currentWord = "";

            foreach (char c in text)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    currentWord += c;
                }
                else
                {
                    if (currentWord.Length > 0)
                    {
                        result += "word"; 
                        currentWord = "";
                    }
                    result += c;
                }
            }

            if (currentWord.Length > 0)
            {
                result += "word";
            }

            File.WriteAllText(savePath, result);
            return savePath;
        }
    }
}