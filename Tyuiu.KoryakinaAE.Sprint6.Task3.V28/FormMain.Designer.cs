namespace Tyuiu.KoryakinaAE.Sprint6.Task3.V28
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
            this.groupBoxTask_AAI = new System.Windows.Forms.GroupBox();
            this.labelTask_AAI = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewResult_AAI = new System.Windows.Forms.DataGridView();
            this.groupBoxOutPutData_AAI = new System.Windows.Forms.GroupBox();
            this.labelResult_AAI = new System.Windows.Forms.Label();
            this.buttonDone_AAI = new System.Windows.Forms.Button();
            this.buttonReference_AAI = new System.Windows.Forms.Button();
            this.groupBoxTask_AAI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAI)).BeginInit();
            this.groupBoxOutPutData_AAI.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_AAI
            // 
            this.groupBoxTask_AAI.Controls.Add(this.labelTask_AAI);
            this.groupBoxTask_AAI.Controls.Add(this.label1);
            this.groupBoxTask_AAI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_AAI.Name = "groupBoxTask_AAI";
            this.groupBoxTask_AAI.Size = new System.Drawing.Size(435, 240);
            this.groupBoxTask_AAI.TabIndex = 7;
            this.groupBoxTask_AAI.TabStop = false;
            this.groupBoxTask_AAI.Text = "Условие";
            // 
            // labelTask_AAI
            // 
            this.labelTask_AAI.AutoSize = true;
            this.labelTask_AAI.Location = new System.Drawing.Point(6, 16);
            this.labelTask_AAI.Name = "labelTask_AAI";
            this.labelTask_AAI.Size = new System.Drawing.Size(274, 91);
            this.labelTask_AAI.TabIndex = 1;
            this.labelTask_AAI.Text = "Дана матрица 5 на 5\r\n-9   8   9  16 -18\r\n-13 -11 -20 -15   9\r\n18  13 -12 -15 -11\r" +
    "\n10  -2  19  -4 -10\r\n6 -20  -4  13 -14\r\nЗаменить четные значения в четвертой стр" +
    "оке на 0.\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 0;
            // 
            // dataGridViewResult_AAI
            // 
            this.dataGridViewResult_AAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_AAI.ColumnHeadersVisible = false;
            this.dataGridViewResult_AAI.Location = new System.Drawing.Point(9, 33);
            this.dataGridViewResult_AAI.Name = "dataGridViewResult_AAI";
            this.dataGridViewResult_AAI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewResult_AAI.RowHeadersVisible = false;
            this.dataGridViewResult_AAI.Size = new System.Drawing.Size(186, 152);
            this.dataGridViewResult_AAI.TabIndex = 8;
            // 
            // groupBoxOutPutData_AAI
            // 
            this.groupBoxOutPutData_AAI.Controls.Add(this.dataGridViewResult_AAI);
            this.groupBoxOutPutData_AAI.Controls.Add(this.labelResult_AAI);
            this.groupBoxOutPutData_AAI.Location = new System.Drawing.Point(453, 12);
            this.groupBoxOutPutData_AAI.Name = "groupBoxOutPutData_AAI";
            this.groupBoxOutPutData_AAI.Size = new System.Drawing.Size(500, 300);
            this.groupBoxOutPutData_AAI.TabIndex = 9;
            this.groupBoxOutPutData_AAI.TabStop = false;
            this.groupBoxOutPutData_AAI.Text = "Вывод данных";
            // 
            // labelResult_AAI
            // 
            this.labelResult_AAI.AutoSize = true;
            this.labelResult_AAI.Location = new System.Drawing.Point(6, 12);
            this.labelResult_AAI.Name = "labelResult_AAI";
            this.labelResult_AAI.Size = new System.Drawing.Size(62, 13);
            this.labelResult_AAI.TabIndex = 0;
            this.labelResult_AAI.Text = "Результат:";
            // 
            // buttonDone_AAI
            // 
            this.buttonDone_AAI.BackColor = System.Drawing.Color.Green;
            this.buttonDone_AAI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDone_AAI.Location = new System.Drawing.Point(500, 212);
            this.buttonDone_AAI.Name = "buttonDone_AAI";
            this.buttonDone_AAI.Size = new System.Drawing.Size(91, 35);
            this.buttonDone_AAI.TabIndex = 11;
            this.buttonDone_AAI.Text = "ВЫПОЛНИТЬ";
            this.buttonDone_AAI.UseVisualStyleBackColor = false;
            this.buttonDone_AAI.Click += new System.EventHandler(this.buttonDone_AAI_Click);
    
            // 
            // buttonReference_AAI
            // 
            this.buttonReference_AAI.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonReference_AAI.Location = new System.Drawing.Point(462, 212);
            this.buttonReference_AAI.Name = "buttonREF_AAI";
            this.buttonReference_AAI.Size = new System.Drawing.Size(32, 35);
            this.buttonReference_AAI.TabIndex = 12;
            this.buttonReference_AAI.Text = "?";
            this.buttonReference_AAI.UseVisualStyleBackColor = false;
            this.buttonReference_AAI.Click += new System.EventHandler(this.buttonReference_AAI_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 256);
            this.Controls.Add(this.buttonReference_AAI);
            this.Controls.Add(this.buttonDone_AAI);
            this.Controls.Add(this.groupBoxOutPutData_AAI);
            this.Controls.Add(this.groupBoxTask_AAI);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Таск 3 | Вариант 28 | Корякина А.Э. ";
            this.groupBoxTask_AAI.ResumeLayout(false);
            this.groupBoxTask_AAI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_AAI)).EndInit();
            this.groupBoxOutPutData_AAI.ResumeLayout(false);
            this.groupBoxOutPutData_AAI.PerformLayout();
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.GroupBox groupBoxTask_AAI;
        private System.Windows.Forms.Label labelTask_AAI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewResult_AAI;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_AAI;
        private System.Windows.Forms.Label labelResult_AAI;
        private System.Windows.Forms.Button buttonDone_AAI;
        private System.Windows.Forms.Button buttonReference_AAI;
    }
}
    

