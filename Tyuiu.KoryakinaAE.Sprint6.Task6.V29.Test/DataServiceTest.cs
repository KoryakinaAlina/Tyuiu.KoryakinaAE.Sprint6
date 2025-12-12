using Tyuiu.KoryakinaAE.Sprint6.Task6.V29.Lib;

namespace Tyuiu.KoryakinaAE.Sprint6.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\korya\source\repos\Tyuiu.KoryakinaAE.Sprint6\Tyuiu.KoryakinaAE.Sprint6.Task5.V10\bin\Debug\InPutDataFileTask6V29.txt";
            var res = ds.CollectTextFromFile(path);
            string wait = "gMxrJi rvzAEwiXzIsLRa xakZKciG";
            Assert.AreEqual(wait, res);
        }
    }
}
