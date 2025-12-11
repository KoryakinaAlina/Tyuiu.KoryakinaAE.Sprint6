using Tyuiu.KoryakinaAE.Sprint6.Task2.V19.Lib;
namespace Tyuiu.KoryakinaAE.Sprint6.Task2.V19
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStart_GRA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartVar_GRA.Text);
                int stopStep = Convert.ToInt32(textBoxStopVar_GRA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartGrafik_GRA.Titles.Add(" График функиции F(X) ");
                this.chartGrafik_GRA.ChartAreas[0].AxisX.Title = " Ось X ";
                this.chartGrafik_GRA.ChartAreas[0].AxisY.Title = " Ось Y ";


                for (int i = 0; i <= len - 1; i++)
                {

                    this.dataGridViewRes_GRA.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartGrafik_GRA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;


                }

            }
            catch
            {
                MessageBox.Show(" Введены неверные данные ", " Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_GRA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-25-1 Корякина Алина Эльдаяговна ", "Сообщение");
        }

        private void chartGrafik_GRA_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRes_GRA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chartGrafik_GRA_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonStart_MouseEnter_GRA(object sender, EventArgs e)
        {
            buttonStart_GRA.BackColor = Color.Red;
        }
        private void buttonStart_MouseLeave_GRA(object sender, EventArgs e)
        {
            buttonStart_GRA.BackColor = Color.Green;
        }


        private void buttonStart_MouseDown_GRA(object sender, MouseEventArgs e)
        {
            buttonStart_GRA.BackColor = Color.Blue;
        }
    }
}