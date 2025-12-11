using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.KoryakinaAE.Sprint6.Task5.V10
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            panelOne_SVV = new Panel();
            buttonHelp_SVV = new Button();
            buttonOpen_SVV = new Button();
            buttonDone_SVV = new Button();
            groupBoxUslovie_SVV = new GroupBox();
            textBoxUslovie_SVV = new TextBox();
            panelTwo_SVV = new Panel();
            groupBoxResult_SVV = new GroupBox();
            dataGridViewResult_SVV = new DataGridView();
            splitterSP_SVV = new Splitter();
            panelThree_SVV = new Panel();
            chartFunction_SVV = new Chart();
            panelOne_SVV.SuspendLayout();
            groupBoxUslovie_SVV.SuspendLayout();
            panelTwo_SVV.SuspendLayout();
            groupBoxResult_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SVV).BeginInit();
            panelThree_SVV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_SVV).BeginInit();
            SuspendLayout();
            // 
            // panelOne_SVV
            // 
            panelOne_SVV.Controls.Add(buttonHelp_SVV);
            panelOne_SVV.Controls.Add(buttonOpen_SVV);
            panelOne_SVV.Controls.Add(buttonDone_SVV);
            panelOne_SVV.Controls.Add(groupBoxUslovie_SVV);
            panelOne_SVV.Dock = DockStyle.Top;
            panelOne_SVV.Location = new Point(0, 0);
            panelOne_SVV.Margin = new Padding(3, 4, 3, 4);
            panelOne_SVV.Name = "panelOne_SVV";
            panelOne_SVV.Size = new Size(913, 171);
            panelOne_SVV.TabIndex = 0;
            // 
            // buttonHelp_SVV
            // 
            buttonHelp_SVV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SVV.BackColor = SystemColors.MenuHighlight;
            buttonHelp_SVV.Location = new Point(799, 21);
            buttonHelp_SVV.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_SVV.Name = "buttonHelp_SVV";
            buttonHelp_SVV.Size = new Size(102, 96);
            buttonHelp_SVV.TabIndex = 1;
            buttonHelp_SVV.Text = "Справка";
            buttonHelp_SVV.UseVisualStyleBackColor = false;
            buttonHelp_SVV.Click += buttonHelp_SVV_Click;
            // 
            // buttonOpen_SVV
            // 
            buttonOpen_SVV.BackColor = SystemColors.Highlight;
            buttonOpen_SVV.Location = new Point(571, 21);
            buttonOpen_SVV.Margin = new Padding(3, 4, 3, 4);
            buttonOpen_SVV.Name = "buttonOpen_SVV";
            buttonOpen_SVV.Size = new Size(110, 96);
            buttonOpen_SVV.TabIndex = 1;
            buttonOpen_SVV.Text = "Открыть файл";
            buttonOpen_SVV.UseVisualStyleBackColor = false;
            buttonOpen_SVV.Click += buttonOpen_SVV_Click;
            // 
            // buttonDone_SVV
            // 
            buttonDone_SVV.BackColor = Color.Green;
            buttonDone_SVV.Location = new Point(456, 21);
            buttonDone_SVV.Margin = new Padding(3, 4, 3, 4);
            buttonDone_SVV.Name = "buttonDone_SVV";
            buttonDone_SVV.Size = new Size(109, 96);
            buttonDone_SVV.TabIndex = 1;
            buttonDone_SVV.Text = "Выполнить";
            buttonDone_SVV.UseVisualStyleBackColor = false;
            buttonDone_SVV.Click += buttonDone_SVV_Click;
            // 
            // groupBoxUslovie_SVV
            // 
            groupBoxUslovie_SVV.Controls.Add(textBoxUslovie_SVV);
            groupBoxUslovie_SVV.Location = new Point(3, 15);
            groupBoxUslovie_SVV.Margin = new Padding(3, 4, 3, 4);
            groupBoxUslovie_SVV.Name = "groupBoxUslovie_SVV";
            groupBoxUslovie_SVV.Padding = new Padding(3, 4, 3, 4);
            groupBoxUslovie_SVV.Size = new Size(447, 149);
            groupBoxUslovie_SVV.TabIndex = 0;
            groupBoxUslovie_SVV.TabStop = false;
            groupBoxUslovie_SVV.Text = "Условие:";
            // 
            // textBoxUslovie_SVV
            // 
            textBoxUslovie_SVV.BorderStyle = BorderStyle.None;
            textBoxUslovie_SVV.Location = new Point(9, 20);
            textBoxUslovie_SVV.Margin = new Padding(3, 4, 3, 4);
            textBoxUslovie_SVV.Multiline = true;
            textBoxUslovie_SVV.Name = "textBoxUslovie_SVV";
            textBoxUslovie_SVV.ReadOnly = true;
            textBoxUslovie_SVV.Size = new Size(432, 121);
            textBoxUslovie_SVV.TabIndex = 0;
            textBoxUslovie_SVV.Text = resources.GetString("textBoxUslovie_SVV.Text");
            // 
            // panelTwo_SVV
            // 
            panelTwo_SVV.Controls.Add(groupBoxResult_SVV);
            panelTwo_SVV.Dock = DockStyle.Left;
            panelTwo_SVV.Location = new Point(0, 171);
            panelTwo_SVV.Margin = new Padding(3, 4, 3, 4);
            panelTwo_SVV.Name = "panelTwo_SVV";
            panelTwo_SVV.Size = new Size(190, 505);
            panelTwo_SVV.TabIndex = 0;
            // 
            // groupBoxResult_SVV
            // 
            groupBoxResult_SVV.Controls.Add(dataGridViewResult_SVV);
            groupBoxResult_SVV.Dock = DockStyle.Left;
            groupBoxResult_SVV.Location = new Point(0, 0);
            groupBoxResult_SVV.Margin = new Padding(3, 4, 3, 4);
            groupBoxResult_SVV.Name = "groupBoxResult_SVV";
            groupBoxResult_SVV.Padding = new Padding(3, 4, 3, 4);
            groupBoxResult_SVV.Size = new Size(187, 505);
            groupBoxResult_SVV.TabIndex = 0;
            groupBoxResult_SVV.TabStop = false;
            groupBoxResult_SVV.Text = "Вывод данных:";
            // 
            // dataGridViewResult_SVV
            // 
            dataGridViewResult_SVV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SVV.Dock = DockStyle.Left;
            dataGridViewResult_SVV.Location = new Point(3, 24);
            dataGridViewResult_SVV.Margin = new Padding(3, 4, 3, 4);
            dataGridViewResult_SVV.Name = "dataGridViewResult_SVV";
            dataGridViewResult_SVV.RowHeadersVisible = false;
            dataGridViewResult_SVV.RowHeadersWidth = 51;
            dataGridViewResult_SVV.RowTemplate.Height = 24;
            dataGridViewResult_SVV.Size = new Size(181, 477);
            dataGridViewResult_SVV.TabIndex = 2;
            // 
            // splitterSP_SVV
            // 
            splitterSP_SVV.Location = new Point(190, 171);
            splitterSP_SVV.Margin = new Padding(3, 4, 3, 4);
            splitterSP_SVV.Name = "splitterSP_SVV";
            splitterSP_SVV.Size = new Size(3, 505);
            splitterSP_SVV.TabIndex = 1;
            splitterSP_SVV.TabStop = false;
            // 
            // panelThree_SVV
            // 
            panelThree_SVV.Controls.Add(chartFunction_SVV);
            panelThree_SVV.Dock = DockStyle.Fill;
            panelThree_SVV.Location = new Point(193, 171);
            panelThree_SVV.Margin = new Padding(3, 4, 3, 4);
            panelThree_SVV.Name = "panelThree_SVV";
            panelThree_SVV.Size = new Size(720, 505);
            panelThree_SVV.TabIndex = 2;
            // 
            // chartFunction_SVV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_SVV.ChartAreas.Add(chartArea1);
            chartFunction_SVV.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_SVV.Legends.Add(legend1);
            chartFunction_SVV.Location = new Point(0, 0);
            chartFunction_SVV.Margin = new Padding(3, 4, 3, 4);
            chartFunction_SVV.Name = "chartFunction_SVV";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.FromArgb(0, 192, 0);
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_SVV.Series.Add(series1);
            chartFunction_SVV.Size = new Size(720, 505);
            chartFunction_SVV.TabIndex = 0;
            chartFunction_SVV.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 676);
            Controls.Add(panelThree_SVV);
            Controls.Add(splitterSP_SVV);
            Controls.Add(panelTwo_SVV);
            Controls.Add(panelOne_SVV);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(820, 723);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 10 | Корякина А.Э.";
            panelOne_SVV.ResumeLayout(false);
            groupBoxUslovie_SVV.ResumeLayout(false);
            groupBoxUslovie_SVV.PerformLayout();
            panelTwo_SVV.ResumeLayout(false);
            groupBoxResult_SVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SVV).EndInit();
            panelThree_SVV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_SVV).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOne_SVV;
        private System.Windows.Forms.Panel panelTwo_SVV;
        private System.Windows.Forms.GroupBox groupBoxUslovie_SVV;
        private System.Windows.Forms.Button buttonHelp_SVV;
        private System.Windows.Forms.Button buttonOpen_SVV;
        private System.Windows.Forms.Button buttonDone_SVV;
        private System.Windows.Forms.TextBox textBoxUslovie_SVV;
        private System.Windows.Forms.GroupBox groupBoxResult_SVV;
        private System.Windows.Forms.DataGridView dataGridViewResult_SVV;
        private System.Windows.Forms.Splitter splitterSP_SVV;
        private System.Windows.Forms.Panel panelThree_SVV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SVV;
    }
}