using Tyuiu.KoryakinaAE.Sprint6.Task7.V20.Lib;

namespace Tyuiu.KoryakinaAE.Sprint6.Task7.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_KAE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KAE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_KAE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_KAE_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_KAE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_KAE.Enabled = true;
        }

        private void buttonOpenFile_KAE_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KAE.ShowDialog();
            openFilePath = openFileDialogTask_KAE.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_KAE.ColumnCount = columns;
            dataGridViewIn_KAE.RowCount = rows;
            dataGridViewOut_KAE.ColumnCount = columns;
            dataGridViewOut_KAE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_KAE.Columns[i].Width = 25;
                dataGridViewOut_KAE.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_KAE.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonDone_KAE.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_KAE.ColumnCount = 50;
            dataGridViewOut_KAE.ColumnCount = 50;

            dataGridViewIn_KAE.RowCount = 50;
            dataGridViewOut_KAE.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_KAE.Columns[i].Width = 25;
                dataGridViewOut_KAE.Columns[i].Width = 25;
            }
        }

        private void buttonSaveFile_KAE_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KAE.FileName = "OutPutFileTask7V20.csv";
            saveFileDialogMatrix_KAE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KAE.ShowDialog();

            string path = saveFileDialogMatrix_KAE.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_KAE.RowCount;
            int columns = dataGridViewOut_KAE.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_KAE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_KAE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_KAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAE.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_KAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAE.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_KAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAE.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_KAE_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KAE.ToolTipTitle = "Справка";
        }
    }
}
