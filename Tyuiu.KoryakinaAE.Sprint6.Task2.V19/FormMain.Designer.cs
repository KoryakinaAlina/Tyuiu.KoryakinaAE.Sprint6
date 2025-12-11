using System.Windows.Forms.DataVisualization.Charting;
namespace Tyuiu.KoryakinaAE.Sprint6.Task2.V19
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOne_GRA = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxTwo_GRA = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_GRA = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartGrafik_GRA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxFree_GRA = new System.Windows.Forms.GroupBox();
            this.textBoxTwo_GRA = new System.Windows.Forms.TextBox();
            this.textBoxOne_GRA = new System.Windows.Forms.TextBox();
            this.textBoxStopVar_GRA = new System.Windows.Forms.TextBox();
            this.textBoxStartVar_GRA = new System.Windows.Forms.TextBox();
            this.buttonHelp_GRA = new System.Windows.Forms.Button();
            this.buttonStart_GRA = new System.Windows.Forms.Button();
            this.groupBoxOne_GRA.SuspendLayout();
            this.groupBoxTwo_GRA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GRA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafik_GRA)).BeginInit();
            this.groupBoxFree_GRA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOne_GRA
            // 
            this.groupBoxOne_GRA.Controls.Add(this.textBox1);
            this.groupBoxOne_GRA.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOne_GRA.Name = "groupBoxOne_GRA";
            this.groupBoxOne_GRA.Size = new System.Drawing.Size(578, 314);
            this.groupBoxOne_GRA.TabIndex = 0;
            this.groupBoxOne_GRA.TabStop = false;
            this.groupBoxOne_GRA.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(440, 39);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в DataGrid" +
    "View и построить график функции.";
            // 
            // groupBoxTwo_GRA
            // 
            this.groupBoxTwo_GRA.Controls.Add(this.dataGridViewRes_GRA);
            this.groupBoxTwo_GRA.Controls.Add(this.chartGrafik_GRA);
            this.groupBoxTwo_GRA.Location = new System.Drawing.Point(597, 13);
            this.groupBoxTwo_GRA.Name = "groupBoxTwo_GRA";
            this.groupBoxTwo_GRA.Size = new System.Drawing.Size(601, 425);
            this.groupBoxTwo_GRA.TabIndex = 1;
            this.groupBoxTwo_GRA.TabStop = false;
            this.groupBoxTwo_GRA.Text = "Вывод данных";
            // 
            // dataGridViewRes_GRA
            // 
            this.dataGridViewRes_GRA.AllowUserToOrderColumns = true;
            this.dataGridViewRes_GRA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_GRA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewRes_GRA.Location = new System.Drawing.Point(18, 19);
            this.dataGridViewRes_GRA.Name = "dataGridViewRes_GRA";
            this.dataGridViewRes_GRA.Size = new System.Drawing.Size(141, 399);
            this.dataGridViewRes_GRA.TabIndex = 1;
            this.dataGridViewRes_GRA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRes_GRA_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // chartGrafik_GRA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGrafik_GRA.ChartAreas.Add(chartArea1);
            this.chartGrafik_GRA.Location = new System.Drawing.Point(165, 20);
            this.chartGrafik_GRA.Name = "chartGrafik_GRA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "График f(x)";
            this.chartGrafik_GRA.Series.Add(series1);
            this.chartGrafik_GRA.Size = new System.Drawing.Size(430, 399);
            this.chartGrafik_GRA.TabIndex = 2;
            this.chartGrafik_GRA.Click += new System.EventHandler(this.chartGrafik_GRA_Click_1);
            // 
            // groupBoxFree_GRA
            // 
            this.groupBoxFree_GRA.Controls.Add(this.textBoxTwo_GRA);
            this.groupBoxFree_GRA.Controls.Add(this.textBoxOne_GRA);
            this.groupBoxFree_GRA.Controls.Add(this.textBoxStopVar_GRA);
            this.groupBoxFree_GRA.Controls.Add(this.textBoxStartVar_GRA);
            this.groupBoxFree_GRA.Location = new System.Drawing.Point(13, 334);
            this.groupBoxFree_GRA.Name = "groupBoxFree_GRA";
            this.groupBoxFree_GRA.Size = new System.Drawing.Size(327, 100);
            this.groupBoxFree_GRA.TabIndex = 2;
            this.groupBoxFree_GRA.TabStop = false;
            this.groupBoxFree_GRA.Text = "Ввод данных";
            // 
            // textBoxTwo_GRA
            // 
            this.textBoxTwo_GRA.Location = new System.Drawing.Point(180, 39);
            this.textBoxTwo_GRA.Multiline = true;
            this.textBoxTwo_GRA.Name = "textBoxTwo_GRA";
            this.textBoxTwo_GRA.ReadOnly = true;
            this.textBoxTwo_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxTwo_GRA.TabIndex = 3;
            this.textBoxTwo_GRA.Text = "Конец шага:";
            // 
            // textBoxOne_GRA
            // 
            this.textBoxOne_GRA.Location = new System.Drawing.Point(17, 39);
            this.textBoxOne_GRA.Multiline = true;
            this.textBoxOne_GRA.Name = "textBoxOne_GRA";
            this.textBoxOne_GRA.ReadOnly = true;
            this.textBoxOne_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxOne_GRA.TabIndex = 2;
            this.textBoxOne_GRA.Text = "Старт шага:";
            // 
            // textBoxStopVar_GRA
            // 
            this.textBoxStopVar_GRA.Location = new System.Drawing.Point(180, 65);
            this.textBoxStopVar_GRA.Multiline = true;
            this.textBoxStopVar_GRA.Name = "textBoxStopVar_GRA";
            this.textBoxStopVar_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopVar_GRA.TabIndex = 1;
            // 
            // textBoxStartVar_GRA
            // 
            this.textBoxStartVar_GRA.Location = new System.Drawing.Point(17, 65);
            this.textBoxStartVar_GRA.Multiline = true;
            this.textBoxStartVar_GRA.Name = "textBoxStartVar_GRA";
            this.textBoxStartVar_GRA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartVar_GRA.TabIndex = 0;
            // 
            // buttonHelp_GRA
            // 
            this.buttonHelp_GRA.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_GRA.Location = new System.Drawing.Point(346, 362);
            this.buttonHelp_GRA.Name = "buttonHelp_GRA";
            this.buttonHelp_GRA.Size = new System.Drawing.Size(90, 72);
            this.buttonHelp_GRA.TabIndex = 3;
            this.buttonHelp_GRA.Text = "СПРАВКА";
            this.buttonHelp_GRA.UseVisualStyleBackColor = false;
            this.buttonHelp_GRA.Click += new System.EventHandler(this.buttonHelp_GRA_Click);
            // 
            // buttonStart_GRA
            // 
            this.buttonStart_GRA.BackColor = System.Drawing.Color.Green;
            this.buttonStart_GRA.Location = new System.Drawing.Point(454, 362);
            this.buttonStart_GRA.Name = "buttonStart_GRA";
            this.buttonStart_GRA.Size = new System.Drawing.Size(127, 72);
            this.buttonStart_GRA.TabIndex = 4;
            this.buttonStart_GRA.Text = "ВЫПОЛНИТЬ";
            this.buttonStart_GRA.UseVisualStyleBackColor = false;
            this.buttonStart_GRA.Click += new System.EventHandler(this.buttonStart_GRA_Click);
            this.buttonStart_GRA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStart_MouseDown_GRA);
            this.buttonStart_GRA.MouseEnter += new System.EventHandler(this.buttonStart_MouseEnter_GRA);
            this.buttonStart_GRA.MouseLeave += new System.EventHandler(this.buttonStart_MouseLeave_GRA);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 450);
            this.Controls.Add(this.buttonStart_GRA);
            this.Controls.Add(this.buttonHelp_GRA);
            this.Controls.Add(this.groupBoxFree_GRA);
            this.Controls.Add(this.groupBoxTwo_GRA);
            this.Controls.Add(this.groupBoxOne_GRA);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "| Спринт 6 | Таск 2| Вариант 19 | Корякина А.Э. ";
            this.groupBoxOne_GRA.ResumeLayout(false);
            this.groupBoxOne_GRA.PerformLayout();
            this.groupBoxTwo_GRA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_GRA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafik_GRA)).EndInit();
            this.groupBoxFree_GRA.ResumeLayout(false);
            this.groupBoxFree_GRA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_GRA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxTwo_GRA;
        private System.Windows.Forms.GroupBox groupBoxFree_GRA;
        private System.Windows.Forms.TextBox textBoxTwo_GRA;
        private System.Windows.Forms.TextBox textBoxOne_GRA;
        private System.Windows.Forms.TextBox textBoxStopVar_GRA;
        private System.Windows.Forms.TextBox textBoxStartVar_GRA;
        private System.Windows.Forms.Button buttonHelp_GRA;
        private System.Windows.Forms.Button buttonStart_GRA;
        private System.Windows.Forms.DataGridView dataGridViewRes_GRA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafik_GRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}