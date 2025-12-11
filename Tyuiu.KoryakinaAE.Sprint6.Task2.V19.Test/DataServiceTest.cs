using Tyuiu.KoryakinaAE.Sprint6.Task2.V19.Lib;

namespace Tyuiu.KoryakinaAE.Sprint6.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMassFunctionLength()
        {
            DataService ds = new DataService();
            double[] TestArray = new double[] { 1.18, -14.95, -16.13, -7.17, -1.3, 0, -5.62, -0.52, 7.63, 5.97, -10.17 };
            CollectionAssert.AreEqual(TestArray, ds.GetMassFunction(-5, 5));
        }
    }
}