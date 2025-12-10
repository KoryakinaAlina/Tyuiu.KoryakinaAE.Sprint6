using Tyuiu.KoryakinaAE.Sprint6.Task0.V28.Lib;

namespace Tyuiu.KoryakinaAE.Sprint6.Task0.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            // Arrange (Подготовка)
            DataService ds = new DataService();
            int x = 3;

            // Act (Действие)
            double result = ds.Calculate(x);

            // Assert (Проверка)
            double wait = 169.890;  // Ожидаемый результат после округления

            // Проверяем с учетом округления до 3 знаков
            Assert.AreEqual(wait, result);

            // Дополнительная проверка: вывод для отладки
            System.Diagnostics.Debug.WriteLine($"x = {x}, результат = {result}, ожидалось = {wait}");
        }

    }
}
