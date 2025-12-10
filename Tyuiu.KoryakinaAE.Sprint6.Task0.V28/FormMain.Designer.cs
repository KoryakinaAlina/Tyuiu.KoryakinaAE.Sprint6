namespace Tyuiu.KoryakinaAE.Sprint6.Task0.V28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxTask_KAE = new TextBox();
            groupBoxOne_KAE = new GroupBox();
            pictureBoxFormuls_KAE = new PictureBox();
            textBoxTwo_KAE = new TextBox();
            textBoxVarX_KAE = new TextBox();
            textBoxResult_KAE = new TextBox();
            textBoxN2_KAE = new TextBox();
            groupBoxTwo_KAE = new GroupBox();
            buttonHelp_KAE = new Button();
            buttonDone_KAE = new Button();
            groupBoxtThree_KAE = new GroupBox();
            groupBoxOne_KAE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormuls_KAE).BeginInit();
            groupBoxTwo_KAE.SuspendLayout();
            groupBoxtThree_KAE.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTask_KAE
            // 
            textBoxTask_KAE.Location = new Point(6, 26);
            textBoxTask_KAE.Multiline = true;
            textBoxTask_KAE.Name = "textBoxTask_KAE";
            textBoxTask_KAE.ReadOnly = true;
            textBoxTask_KAE.Size = new Size(337, 93);
            textBoxTask_KAE.TabIndex = 0;
            textBoxTask_KAE.TabStop = false;
            textBoxTask_KAE.Text = "Дано выражение F(x) = 6. 1x + 0.23x + 1.04x, вычислить его значение при х = 3, результат вывести в TextBox. Округлить до трёх знаков после запятой.";
            // 
            // groupBoxOne_KAE
            // 
            groupBoxOne_KAE.Controls.Add(textBoxTask_KAE);
            groupBoxOne_KAE.Location = new Point(23, 12);
            groupBoxOne_KAE.Name = "groupBoxOne_KAE";
            groupBoxOne_KAE.Size = new Size(368, 229);
            groupBoxOne_KAE.TabIndex = 1;
            groupBoxOne_KAE.TabStop = false;
            groupBoxOne_KAE.Text = "Условие:";
            // 
            // pictureBoxFormuls_KAE
            // 
            pictureBoxFormuls_KAE.Image = (Image)resources.GetObject("pictureBoxFormuls_KAE.Image");
            pictureBoxFormuls_KAE.Location = new Point(416, 80);
            pictureBoxFormuls_KAE.Name = "pictureBoxFormuls_KAE";
            pictureBoxFormuls_KAE.Size = new Size(372, 51);
            pictureBoxFormuls_KAE.TabIndex = 2;
            pictureBoxFormuls_KAE.TabStop = false;
            // 
            // textBoxTwo_KAE
            // 
            textBoxTwo_KAE.Location = new Point(6, 33);
            textBoxTwo_KAE.Multiline = true;
            textBoxTwo_KAE.Name = "textBoxTwo_KAE";
            textBoxTwo_KAE.ReadOnly = true;
            textBoxTwo_KAE.Size = new Size(138, 31);
            textBoxTwo_KAE.TabIndex = 3;
            textBoxTwo_KAE.Text = "Переменная X:";
            // 
            // textBoxVarX_KAE
            // 
            textBoxVarX_KAE.Location = new Point(6, 70);
            textBoxVarX_KAE.Name = "textBoxVarX_KAE";
            textBoxVarX_KAE.Size = new Size(138, 27);
            textBoxVarX_KAE.TabIndex = 4;
            textBoxVarX_KAE.KeyPress += this.textBoxVarX_KeyPress;
            // 
            // textBoxResult_KAE
            // 
            textBoxResult_KAE.Location = new Point(25, 60);
            textBoxResult_KAE.Name = "textBoxResult_KAE";
            textBoxResult_KAE.ReadOnly = true;
            textBoxResult_KAE.Size = new Size(198, 27);
            textBoxResult_KAE.TabIndex = 5;
            // 
            // textBoxN2_KAE
            // 
            textBoxN2_KAE.Location = new Point(25, 27);
            textBoxN2_KAE.Name = "textBoxN2_KAE";
            textBoxN2_KAE.ReadOnly = true;
            textBoxN2_KAE.Size = new Size(120, 27);
            textBoxN2_KAE.TabIndex = 6;
            textBoxN2_KAE.Text = "Результат:";
            // 
            // groupBoxTwo_KAE
            // 
            groupBoxTwo_KAE.Controls.Add(textBoxN2_KAE);
            groupBoxTwo_KAE.Controls.Add(textBoxResult_KAE);
            groupBoxTwo_KAE.Location = new Point(490, 259);
            groupBoxTwo_KAE.Name = "groupBoxTwo_KAE";
            groupBoxTwo_KAE.Size = new Size(277, 132);
            groupBoxTwo_KAE.TabIndex = 7;
            groupBoxTwo_KAE.TabStop = false;
            groupBoxTwo_KAE.Text = "Вывод данных";
            // 
            // buttonHelp_KAE
            // 
            buttonHelp_KAE.FlatStyle = FlatStyle.Flat;
            buttonHelp_KAE.Location = new Point(592, 406);
            buttonHelp_KAE.Name = "buttonHelp_KAE";
            buttonHelp_KAE.Size = new Size(43, 32);
            buttonHelp_KAE.TabIndex = 8;
            buttonHelp_KAE.Text = "?";
            buttonHelp_KAE.UseVisualStyleBackColor = true;
            buttonHelp_KAE.Click += buttonHelp_Click;
            // 
            // buttonDone_KAE
            // 
            buttonDone_KAE.FlatStyle = FlatStyle.Flat;
            buttonDone_KAE.Location = new Point(641, 404);
            buttonDone_KAE.Name = "buttonDone_KAE";
            buttonDone_KAE.Size = new Size(115, 36);
            buttonDone_KAE.TabIndex = 9;
            buttonDone_KAE.Text = "Выполнить";
            buttonDone_KAE.UseVisualStyleBackColor = true;
            buttonDone_KAE.Click += buttonDone_Click;
            // 
            // groupBoxtThree_KAE
            // 
            groupBoxtThree_KAE.Controls.Add(textBoxTwo_KAE);
            groupBoxtThree_KAE.Controls.Add(textBoxVarX_KAE);
            groupBoxtThree_KAE.Location = new Point(23, 270);
            groupBoxtThree_KAE.Name = "groupBoxtThree_KAE";
            groupBoxtThree_KAE.Size = new Size(236, 159);
            groupBoxtThree_KAE.TabIndex = 10;
            groupBoxtThree_KAE.TabStop = false;
            groupBoxtThree_KAE.Text = "Ввод данных";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxtThree_KAE);
            Controls.Add(buttonDone_KAE);
            Controls.Add(buttonHelp_KAE);
            Controls.Add(groupBoxTwo_KAE);
            Controls.Add(pictureBoxFormuls_KAE);
            Controls.Add(groupBoxOne_KAE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 28 | Корякина А.Э. ";
            groupBoxOne_KAE.ResumeLayout(false);
            groupBoxOne_KAE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormuls_KAE).EndInit();
            groupBoxTwo_KAE.ResumeLayout(false);
            groupBoxTwo_KAE.PerformLayout();
            groupBoxtThree_KAE.ResumeLayout(false);
            groupBoxtThree_KAE.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxTask_KAE;
        private GroupBox groupBoxOne_KAE;
        private PictureBox pictureBoxFormuls_KAE;
        private TextBox textBoxTwo_KAE;
        private TextBox textBoxVarX_KAE;
        private TextBox textBoxResult_KAE;
        private TextBox textBoxN2_KAE;
        private GroupBox groupBoxTwo_KAE;
        private Button buttonHelp_KAE;
        private Button buttonDone_KAE;
        private GroupBox groupBoxtThree_KAE;
    }
}
