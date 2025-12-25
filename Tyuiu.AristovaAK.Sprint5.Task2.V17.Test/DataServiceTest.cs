using Microsoft.ApplicationInsights;
using Tyuiu.AristovaAK.Sprint5.Task2.V17.Lib;
namespace Tyuiu.AristovaAK.Sprint5.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[3,3];

            string path = ds.SaveToFileTextData(matrix);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
             
            Assert.AreEqual(wait, fileExists);
        }
    }
}
