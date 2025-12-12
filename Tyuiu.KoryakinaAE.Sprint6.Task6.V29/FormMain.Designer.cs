namespace Tyuiu.KoryakinaAE.Sprint6.Task6.V29
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
            panelUP_BAA = new Panel();
            buttonHelp_KAE = new Button();
            buttonLoad_KAE = new Button();
            buttonStart_KAE = new Button();
            groupBoxTask_KAE = new GroupBox();
            textBoxTask_BAA = new TextBox();
            panelFill_BAA = new Panel();
            groupBoxOutput_KAE = new GroupBox();
            textBoxOutput_KAE = new TextBox();
            panelLeft_BAA = new Panel();
            groupBoxInput_KAE = new GroupBox();
            textBoxInput_KAE = new TextBox();
            splitter1 = new Splitter();
            openFileDialog_BAA = new OpenFileDialog();
            toolTipHelp_BAA = new ToolTip(components);
            panelUP_BAA.SuspendLayout();
            groupBoxTask_KAE.SuspendLayout();
            panelFill_BAA.SuspendLayout();
            groupBoxOutput_KAE.SuspendLayout();
            panelLeft_BAA.SuspendLayout();
            groupBoxInput_KAE.SuspendLayout();
            SuspendLayout();
            // 
            // panelUP_BAA
            // 
            panelUP_BAA.Controls.Add(buttonHelp_KAE);
            panelUP_BAA.Controls.Add(buttonLoad_KAE);
            panelUP_BAA.Controls.Add(buttonStart_KAE);
            panelUP_BAA.Controls.Add(groupBoxTask_KAE);
            panelUP_BAA.Dock = DockStyle.Top;
            panelUP_BAA.Location = new Point(0, 0);
            panelUP_BAA.Margin = new Padding(3, 4, 3, 4);
            panelUP_BAA.Name = "panelUP_BAA";
            panelUP_BAA.Size = new Size(896, 216);
            panelUP_BAA.TabIndex = 0;
            // 
            // buttonHelp_KAE
            // 
            buttonHelp_KAE.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KAE.Location = new Point(791, 16);
            buttonHelp_KAE.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_KAE.Name = "buttonHelp_KAE";
            buttonHelp_KAE.Size = new Size(91, 107);
            buttonHelp_KAE.TabIndex = 2;
            buttonHelp_KAE.Text = "Справка";
            toolTipHelp_BAA.SetToolTip(buttonHelp_KAE, "Информация об авторе приложения");
            buttonHelp_KAE.UseVisualStyleBackColor = true;
            buttonHelp_KAE.Click += buttonHelp_BAA_Click;
            // 
            // buttonLoad_KAE
            // 
            buttonLoad_KAE.Location = new Point(14, 16);
            buttonLoad_KAE.Margin = new Padding(3, 4, 3, 4);
            buttonLoad_KAE.Name = "buttonLoad_KAE";
            buttonLoad_KAE.Size = new Size(91, 107);
            buttonLoad_KAE.TabIndex = 2;
            buttonLoad_KAE.Text = "Загрузить";
            toolTipHelp_BAA.SetToolTip(buttonLoad_KAE, "Загрузка файла");
            buttonLoad_KAE.UseVisualStyleBackColor = true;
            buttonLoad_KAE.Click += buttonLoad_BAA_Click;
            // 
            // buttonStart_KAE
            // 
            buttonStart_KAE.Enabled = false;
            buttonStart_KAE.Location = new Point(112, 16);
            buttonStart_KAE.Margin = new Padding(3, 4, 3, 4);
            buttonStart_KAE.Name = "buttonStart_KAE";
            buttonStart_KAE.Size = new Size(91, 107);
            buttonStart_KAE.TabIndex = 2;
            buttonStart_KAE.Text = "Выполнить";
            toolTipHelp_BAA.SetToolTip(buttonStart_KAE, "Запуск обработки файла");
            buttonStart_KAE.UseVisualStyleBackColor = true;
            buttonStart_KAE.Click += buttonStart_BAA_Click;
            // 
            // groupBoxTask_KAE
            // 
            groupBoxTask_KAE.Controls.Add(textBoxTask_BAA);
            groupBoxTask_KAE.Dock = DockStyle.Bottom;
            groupBoxTask_KAE.Location = new Point(0, 131);
            groupBoxTask_KAE.Margin = new Padding(3, 4, 3, 4);
            groupBoxTask_KAE.Name = "groupBoxTask_KAE";
            groupBoxTask_KAE.Padding = new Padding(3, 4, 3, 4);
            groupBoxTask_KAE.Size = new Size(896, 85);
            groupBoxTask_KAE.TabIndex = 0;
            groupBoxTask_KAE.TabStop = false;
            groupBoxTask_KAE.Text = "Условие";
            // 
            // textBoxTask_BAA
            // 
            textBoxTask_BAA.BackColor = SystemColors.Control;
            textBoxTask_BAA.BorderStyle = BorderStyle.None;
            textBoxTask_BAA.Dock = DockStyle.Fill;
            textBoxTask_BAA.Location = new Point(3, 24);
            textBoxTask_BAA.Margin = new Padding(3, 4, 3, 4);
            textBoxTask_BAA.Multiline = true;
            textBoxTask_BAA.Name = "textBoxTask_BAA";
            textBoxTask_BAA.ReadOnly = true;
            textBoxTask_BAA.Size = new Size(890, 57);
            textBoxTask_BAA.TabIndex = 0;
            // 
            // panelFill_BAA
            // 
            panelFill_BAA.Controls.Add(groupBoxOutput_KAE);
            panelFill_BAA.Dock = DockStyle.Fill;
            panelFill_BAA.Location = new Point(450, 216);
            panelFill_BAA.Margin = new Padding(3, 4, 3, 4);
            panelFill_BAA.Name = "panelFill_BAA";
            panelFill_BAA.Size = new Size(446, 465);
            panelFill_BAA.TabIndex = 1;
            // 
            // groupBoxOutput_KAE
            // 
            groupBoxOutput_KAE.Controls.Add(textBoxOutput_KAE);
            groupBoxOutput_KAE.Dock = DockStyle.Fill;
            groupBoxOutput_KAE.Location = new Point(0, 0);
            groupBoxOutput_KAE.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_KAE.Name = "groupBoxOutput_KAE";
            groupBoxOutput_KAE.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_KAE.Size = new Size(446, 465);
            groupBoxOutput_KAE.TabIndex = 0;
            groupBoxOutput_KAE.TabStop = false;
            groupBoxOutput_KAE.Text = "Вывод:";
            // 
            // textBoxOutput_KAE
            // 
            textBoxOutput_KAE.BackColor = SystemColors.Window;
            textBoxOutput_KAE.Dock = DockStyle.Fill;
            textBoxOutput_KAE.Location = new Point(3, 24);
            textBoxOutput_KAE.Margin = new Padding(3, 4, 3, 4);
            textBoxOutput_KAE.Multiline = true;
            textBoxOutput_KAE.Name = "textBoxOutput_KAE";
            textBoxOutput_KAE.ReadOnly = true;
            textBoxOutput_KAE.ScrollBars = ScrollBars.Vertical;
            textBoxOutput_KAE.Size = new Size(440, 437);
            textBoxOutput_KAE.TabIndex = 0;
            textBoxOutput_KAE.TextChanged += textBoxOutput_BAA_TextChanged;
            // 
            // panelLeft_BAA
            // 
            panelLeft_BAA.Controls.Add(groupBoxInput_KAE);
            panelLeft_BAA.Dock = DockStyle.Left;
            panelLeft_BAA.Location = new Point(0, 216);
            panelLeft_BAA.Margin = new Padding(3, 4, 3, 4);
            panelLeft_BAA.Name = "panelLeft_BAA";
            panelLeft_BAA.Size = new Size(447, 465);
            panelLeft_BAA.TabIndex = 2;
            // 
            // groupBoxInput_KAE
            // 
            groupBoxInput_KAE.Controls.Add(textBoxInput_KAE);
            groupBoxInput_KAE.Dock = DockStyle.Fill;
            groupBoxInput_KAE.Location = new Point(0, 0);
            groupBoxInput_KAE.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_KAE.Name = "groupBoxInput_KAE";
            groupBoxInput_KAE.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_KAE.Size = new Size(447, 465);
            groupBoxInput_KAE.TabIndex = 0;
            groupBoxInput_KAE.TabStop = false;
            groupBoxInput_KAE.Text = "Ввод:";
            // 
            // textBoxInput_KAE
            // 
            textBoxInput_KAE.BackColor = SystemColors.Window;
            textBoxInput_KAE.Dock = DockStyle.Fill;
            textBoxInput_KAE.Location = new Point(3, 24);
            textBoxInput_KAE.Margin = new Padding(3, 4, 3, 4);
            textBoxInput_KAE.Multiline = true;
            textBoxInput_KAE.Name = "textBoxInput_KAE";
            textBoxInput_KAE.ReadOnly = true;
            textBoxInput_KAE.ScrollBars = ScrollBars.Vertical;
            textBoxInput_KAE.Size = new Size(441, 437);
            textBoxInput_KAE.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(447, 216);
            splitter1.Margin = new Padding(3, 4, 3, 4);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 465);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // openFileDialog_BAA
            // 
            openFileDialog_BAA.FileName = "openFileDialogLoad";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 681);
            Controls.Add(panelFill_BAA);
            Controls.Add(splitter1);
            Controls.Add(panelLeft_BAA);
            Controls.Add(panelUP_BAA);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(912, 651);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 29 | Корякина А.Э.";
            panelUP_BAA.ResumeLayout(false);
            groupBoxTask_KAE.ResumeLayout(false);
            groupBoxTask_KAE.PerformLayout();
            panelFill_BAA.ResumeLayout(false);
            groupBoxOutput_KAE.ResumeLayout(false);
            groupBoxOutput_KAE.PerformLayout();
            panelLeft_BAA.ResumeLayout(false);
            groupBoxInput_KAE.ResumeLayout(false);
            groupBoxInput_KAE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUP_BAA;
        private Panel panelFill_BAA;
        private Panel panelLeft_BAA;
        private Splitter splitter1;
        private GroupBox groupBoxTask_KAE;
        private TextBox textBoxTask_BAA;
        private GroupBox groupBoxInput_KAE;
        private TextBox textBoxInput_KAE;
        private Button buttonHelp_KAE;
        private Button buttonLoad_KAE;
        private Button buttonStart_KAE;
        private GroupBox groupBoxOutput_KAE;
        private TextBox textBoxOutput_KAE;
        private OpenFileDialog openFileDialog_BAA;
        private ToolTip toolTipHelp_BAA;
    }
}
