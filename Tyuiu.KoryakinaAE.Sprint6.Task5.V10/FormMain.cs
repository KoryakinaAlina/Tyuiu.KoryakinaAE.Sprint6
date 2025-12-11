using Tyuiu.KoryakinaAE.Sprint6.Task5.V10.Lib;
namespace Tyuiu.KoryakinaAE.Sprint6.Task5.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        string path = @"C:\Users\korya\source\repos\Tyuiu.KoryakinaAE.Sprint6\Tyuiu.KoryakinaAE.Sprint6.Task5.V10\bin\Debug\net8.0-windows\InPutDataFileTask5V10.txt";
        private void buttonDone_SVV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_SVV.ColumnCount = 2;
            dataGridViewResult_SVV.Columns[0].Width = 20;
            dataGridViewResult_SVV.Columns[1].Width = 50;

            this.chartFunction_SVV.ChartAreas[0].AxisX.Title = " Ось X";
            this.chartFunction_SVV.ChartAreas[0].AxisY.Title = " Ось Y";

            chartFunction_SVV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_SVV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_SVV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_SVV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИСТНб-25-1 Корякина Алина Эльдаяговна", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
