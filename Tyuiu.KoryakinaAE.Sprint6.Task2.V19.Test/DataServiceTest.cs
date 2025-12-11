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
            double[] TestArray = new double[] { -0.62, -16.79,-17.77, -6.3, -5.04, -6.0, -7.85, -2.43, 5.91, 4.33, -11.82 };
            CollectionAssert.AreEqual(TestArray, ds.GetMassFunction(-5, 5));
        }
    }
}