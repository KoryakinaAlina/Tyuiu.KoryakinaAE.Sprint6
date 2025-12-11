using Tyuiu.KoryakinaAE.Sprint6.Task3.V28.Lib;

namespace Tyuiu.KoryakinaAE.Sprint6.Task3.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonReference_AAI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-25-1 Корякина Алина Эльдаяговна", "Сообщение");
        }



        private void buttonDone_AAI_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { { -9, 8, 9, 16, -18 }, { -13, -11, -20, -15, 9 }, { 18, 13, -12, -15, -11 }, { 10, -2, 19, -4, -10 }, { 6, -20, -4, 13, -14 } };
            int[,] res = ds.Calculate(mtrx);

            int rows = mtrx.GetLength(0);
            int cols = mtrx.GetLength(1);
            dataGridViewResult_AAI.ColumnCount = cols;
            dataGridViewResult_AAI.RowCount = rows;

            //задаем ширину столбца 
            for (int i = 0; i < cols; i++)
            {
                dataGridViewResult_AAI.Columns[i].Width = 25;
            }

            //заполняем сетку данными из массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult_AAI.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
    }
}
