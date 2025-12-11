using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KoryakinaAE.Sprint6.Task3.V28.Lib
{
    public class DataService : ISprint6Task3V28
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] a = new int[5, 5] { { -9, 8, 9, 16, -18 }, { -13, -11, -20, -15, 9 }, { 18, 13, -12, -15, -11 }, { 10, -2, 19, -4, -10 }, { 6, -20, -4, 13, -14 } };


            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (a[3, j] % 2 == 0)
                {
                    a[3, j] = 0;
                }
            }
            return a;
        }
    }
}
