using Tyuiu.KoryakinaAE.Sprint6.Task6.V29.Lib;

namespace Tyuiu.KoryakinaAE.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path;

        private void buttonStart_BAA_Click(object sender, EventArgs e)
        {
            textBoxOutput_KAE.Text = ds.CollectTextFromFile(path);
        }

        private void buttonLoad_BAA_Click(object sender, EventArgs e)
        {
            openFileDialog_BAA.ShowDialog();
            path = openFileDialog_BAA.FileName;
            textBoxInput_KAE.Text = File.ReadAllText(path);
            groupBoxInput_KAE.Text = groupBoxInput_KAE.Text + " " + path;
            buttonStart_KAE.Enabled = true;
        }

        private void buttonHelp_BAA_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void textBoxOutput_BAA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
