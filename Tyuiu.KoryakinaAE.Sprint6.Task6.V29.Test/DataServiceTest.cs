using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.KoryakinaAE.Sprint6.Task6.V29.Lib;

namespace Tyuiu.KoryakinaAE.Sprint6.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            // arrange
            string path = @"C:\Users\korya\source\repos\Tyuiu.KoryakinaAE.Sprint6\Tyuiu.KoryakinaAE.Sprint6.Task5.V10\bin\Debug\InPutDataFileTask6V29.txt";
            DataService ds = new DataService();

            // act
            string result = ds.CollectTextFromFile(path);

            // assert
            string expected = "gMxrJi rvzAEwiXzIsLRa xakZKciG";
            Assert.AreEqual(expected, result);
        }
    }
}