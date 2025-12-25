using System.Security.Cryptography.X509Certificates;
using Tyuiu.AristovaAK.Sprint5.Task1.V14.Lib;
namespace Tyuiu.AristovaAK.Sprint5.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            DataService ds = new DataService();

            int x = -5;
            int y = 5;
            string Path = ds.SaveToFileTextData(x, y);
            FileInfo fileInfo = new FileInfo(Path);

            bool wait = true;
            bool res = fileInfo.Exists;
            Assert.AreEqual(wait, res);
        }
    }
}
