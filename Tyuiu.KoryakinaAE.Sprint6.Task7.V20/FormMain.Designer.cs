namespace Tyuiu.KoryakinaAE.Sprint6.Task7.V20
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_KAE = new Panel();
            buttonHelp_KAE = new Button();
            buttonSaveFile_KAE = new Button();
            buttonDone_KAE = new Button();
            buttonOpenFile_KAE = new Button();
            groupBoxTask_KAE = new GroupBox();
            textBox1 = new TextBox();
            groupBox1Task = new GroupBox();
            dataGridViewOut_KAE = new DataGridView();
            splitterTask = new Splitter();
            groupBoxTask = new GroupBox();
            dataGridViewIn_KAE = new DataGridView();
            openFileDialogTask_KAE = new OpenFileDialog();
            toolTipButton_KAE = new ToolTip(components);
            saveFileDialogMatrix_KAE = new SaveFileDialog();
            panelTop_KAE.SuspendLayout();
            groupBoxTask_KAE.SuspendLayout();
            groupBox1Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KAE).BeginInit();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KAE).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KAE
            // 
            panelTop_KAE.Controls.Add(buttonHelp_KAE);
            panelTop_KAE.Controls.Add(buttonSaveFile_KAE);
            panelTop_KAE.Controls.Add(buttonDone_KAE);
            panelTop_KAE.Controls.Add(buttonOpenFile_KAE);
            panelTop_KAE.Dock = DockStyle.Top;
            panelTop_KAE.Location = new Point(0, 0);
            panelTop_KAE.Margin = new Padding(3, 4, 3, 4);
            panelTop_KAE.Name = "panelTop_KAE";
            panelTop_KAE.Size = new Size(914, 83);
            panelTop_KAE.TabIndex = 0;
            // 
            // buttonHelp_KAE
            // 
            buttonHelp_KAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KAE.FlatStyle = FlatStyle.Flat;
            buttonHelp_KAE.Image = (Image)resources.GetObject("buttonHelp_KAE.Image");
            buttonHelp_KAE.Location = new Point(807, 4);
            buttonHelp_KAE.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_KAE.Name = "buttonHelp_KAE";
            buttonHelp_KAE.Size = new Size(77, 75);
            buttonHelp_KAE.TabIndex = 2;
            toolTipButton_KAE.SetToolTip(buttonHelp_KAE, "Сведения о программе");
            buttonHelp_KAE.UseVisualStyleBackColor = true;
            buttonHelp_KAE.Click += buttonHelp_KAE_Click;
            buttonHelp_KAE.MouseEnter += buttonHelp_KAE_MouseEnter;
            // 
            // buttonSaveFile_KAE
            // 
            buttonSaveFile_KAE.Enabled = false;
            buttonSaveFile_KAE.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_KAE.Image = (Image)resources.GetObject("buttonSaveFile_KAE.Image");
            buttonSaveFile_KAE.Location = new Point(222, 4);
            buttonSaveFile_KAE.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_KAE.Name = "buttonSaveFile_KAE";
            buttonSaveFile_KAE.Size = new Size(86, 75);
            buttonSaveFile_KAE.TabIndex = 1;
            toolTipButton_KAE.SetToolTip(buttonSaveFile_KAE, "Сохранить обработанные данные в файл в формате csv");
            buttonSaveFile_KAE.UseVisualStyleBackColor = true;
            buttonSaveFile_KAE.Click += buttonSaveFile_KAE_Click;
            buttonSaveFile_KAE.MouseEnter += buttonSaveFile_KAE_MouseEnter;
            // 
            // buttonDone_KAE
            // 
            buttonDone_KAE.Enabled = false;
            buttonDone_KAE.FlatStyle = FlatStyle.Flat;
            buttonDone_KAE.Image = (Image)resources.GetObject("buttonDone_KAE.Image");
            buttonDone_KAE.Location = new Point(117, 4);
            buttonDone_KAE.Margin = new Padding(3, 4, 3, 4);
            buttonDone_KAE.Name = "buttonDone_KAE";
            buttonDone_KAE.Size = new Size(86, 75);
            buttonDone_KAE.TabIndex = 1;
            toolTipButton_KAE.SetToolTip(buttonDone_KAE, "Выполнить обработку данных");
            buttonDone_KAE.UseVisualStyleBackColor = true;
            buttonDone_KAE.Click += buttonDone_KAE_Click;
            buttonDone_KAE.MouseEnter += buttonDone_KAE_MouseEnter;
            // 
            // buttonOpenFile_KAE
            // 
            buttonOpenFile_KAE.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_KAE.Image = (Image)resources.GetObject("buttonOpenFile_KAE.Image");
            buttonOpenFile_KAE.Location = new Point(14, 4);
            buttonOpenFile_KAE.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_KAE.Name = "buttonOpenFile_KAE";
            buttonOpenFile_KAE.Size = new Size(86, 75);
            buttonOpenFile_KAE.TabIndex = 0;
            toolTipButton_KAE.SetToolTip(buttonOpenFile_KAE, "Открыть файл для обработки данных в  формате csv");
            buttonOpenFile_KAE.UseVisualStyleBackColor = true;
            buttonOpenFile_KAE.Click += buttonOpenFile_KAE_Click;
            buttonOpenFile_KAE.MouseEnter += buttonOpenFile_KAE_MouseEnter;
            // 
            // groupBoxTask_KAE
            // 
            groupBoxTask_KAE.Controls.Add(textBox1);
            groupBoxTask_KAE.Dock = DockStyle.Top;
            groupBoxTask_KAE.Location = new Point(0, 83);
            groupBoxTask_KAE.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_KAE.Name = "groupBoxTask_KAE";
            groupBoxTask_KAE.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_KAE.Size = new Size(914, 97);
            groupBoxTask_KAE.TabIndex = 1;
            groupBoxTask_KAE.TabStop = false;
            groupBoxTask_KAE.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 25);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(910, 63);
            textBox1.TabIndex = 0;
            // 
            // groupBox1Task
            // 
            groupBox1Task.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1Task.Controls.Add(dataGridViewOut_KAE);
            groupBox1Task.Controls.Add(splitterTask);
            groupBox1Task.Location = new Point(455, 188);
            groupBox1Task.Margin = new Padding(3, 4, 3, 4);
            groupBox1Task.Name = "groupBox1Task";
            groupBox1Task.Padding = new Padding(3, 4, 3, 4);
            groupBox1Task.Size = new Size(459, 409);
            groupBox1Task.TabIndex = 2;
            groupBox1Task.TabStop = false;
            groupBox1Task.Text = "Вывод";
            // 
            // dataGridViewOut_KAE
            // 
            dataGridViewOut_KAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_KAE.Location = new Point(14, 25);
            dataGridViewOut_KAE.Margin = new Padding(3, 4, 3, 4);
            dataGridViewOut_KAE.Name = "dataGridViewOut_KAE";
            dataGridViewOut_KAE.RowHeadersWidth = 51;
            dataGridViewOut_KAE.Size = new Size(445, 371);
            dataGridViewOut_KAE.TabIndex = 0;
            // 
            // splitterTask
            // 
            splitterTask.Location = new Point(3, 24);
            splitterTask.Margin = new Padding(3, 4, 3, 4);
            splitterTask.Name = "splitterTask";
            splitterTask.Size = new Size(3, 381);
            splitterTask.TabIndex = 0;
            splitterTask.TabStop = false;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxTask.Controls.Add(dataGridViewIn_KAE);
            groupBoxTask.Location = new Point(3, 188);
            groupBoxTask.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask.Size = new Size(454, 409);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Ввод";
            // 
            // dataGridViewIn_KAE
            // 
            dataGridViewIn_KAE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_KAE.Location = new Point(3, 25);
            dataGridViewIn_KAE.Margin = new Padding(3, 4, 3, 4);
            dataGridViewIn_KAE.Name = "dataGridViewIn_KAE";
            dataGridViewIn_KAE.RowHeadersWidth = 51;
            dataGridViewIn_KAE.Size = new Size(445, 371);
            dataGridViewIn_KAE.TabIndex = 0;
            // 
            // openFileDialogTask_PMO
            // 
            openFileDialogTask_KAE.FileName = "openFileDialog1";
            // 
            // toolTipButton_PMO
            // 
            toolTipButton_KAE.IsBalloon = true;
            toolTipButton_KAE.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_KAE.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBox1Task);
            Controls.Add(groupBoxTask_KAE);
            Controls.Add(panelTop_KAE);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Спринт 6 Таск 7 Вариант 20 Корякина А.Э";
            toolTipButton_KAE.SetToolTip(this, "\r\n");
            WindowState = FormWindowState.Maximized;
            panelTop_KAE.ResumeLayout(false);
            groupBoxTask_KAE.ResumeLayout(false);
            groupBoxTask_KAE.PerformLayout();
            groupBox1Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_KAE).EndInit();
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_KAE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KAE;
        private Button buttonHelp_KAE;
        private Button buttonDone_KAE;
        private Button buttonOpenFile_KAE;
        private Button buttonSaveFile_KAE;
        private GroupBox groupBoxTask_KAE;
        private TextBox textBox1;
        private GroupBox groupBox1Task;
        private GroupBox groupBoxTask;
        private Splitter splitterTask;
        private DataGridView dataGridViewIn_KAE;
        private DataGridView dataGridViewOut_KAE;
        private OpenFileDialog openFileDialogTask_KAE;
        private ToolTip toolTipButton_KAE;
        private SaveFileDialog saveFileDialogMatrix_KAE;
    }
}
