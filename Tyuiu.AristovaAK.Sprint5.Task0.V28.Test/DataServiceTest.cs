///using System.IO;
using Tyuiu.AristovaAK.Sprint5.Task0.V28.Lib;
namespace Tyuiu.AristovaAK.Sprint5.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(x);
             
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
