using Tyuiu.KoryakinaAE.Sprint6.Task4.V13.Lib;
namespace Tyuiu.KoryakinaAE.Sprint6.Task4.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDown_PDA_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_PDA.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_PDA.Text);
                int len = stopValue - startValue + 1;
                double[] res = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_PDA.Text = "";
                for (int i = 0; i < len; i++)
                {
                    textBoxResult_PDA.AppendText(res[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonQuestion_PDA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Спринт 6 Таск 4 Вариант 13 выполнил студент ИСТНб-25-1  Корякина Алина Эльдаяговна");
        }

        private void buttonSave_PDA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V13.txt");
                File.WriteAllText(path, textBoxResult_PDA.Text);

                DialogResult dr = MessageBox.Show("Файл " + path + " сохранен успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
   

