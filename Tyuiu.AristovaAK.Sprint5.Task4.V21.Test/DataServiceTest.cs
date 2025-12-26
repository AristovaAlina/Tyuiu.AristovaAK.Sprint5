using Tyuiu.AristovaAK.Sprint5.Task4.V21.Lib;
namespace Tyuiu.AristovaAK.Sprint5.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V21.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            // Assert
            bool wait = true;
            Assert.AreEqual(wait, fileExists, $"Файл не найден: {path}");
        }
    }
}
