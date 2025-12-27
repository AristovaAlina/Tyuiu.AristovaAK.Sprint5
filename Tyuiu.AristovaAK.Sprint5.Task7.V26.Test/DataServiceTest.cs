using Tyuiu.AristovaAK.Sprint5.Task7.V26.Lib;
namespace Tyuiu.AristovaAK.Sprint5.Task7.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\OutPutDataFileTask7V26.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
