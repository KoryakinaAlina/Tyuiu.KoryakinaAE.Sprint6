namespace Tyuiu.KoryakinaAE.Sprint6.Task6.V29
{
    partial class FormAbout
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
            textBox1 = new TextBox();
            buttonClose = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 16);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1084, 641);
            textBox1.TabIndex = 0;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(576, 667);
            buttonClose.Margin = new Padding(3, 4, 3, 4);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(86, 31);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "Ок";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(664, 643);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Location = new Point(684, 258);
            label1.Name = "label1";
            label1.Size = new Size(402, 176);
            label1.TabIndex = 3;
            label1.Text = "Разработчик: Корякина А.Э.\r\nГруппа ИСТНб-25-1\r\n\r\nТюменский Индустриальный Университет\r\nВысшая школа цифровых технологий\r\nИнформационные системы и технологии в геологии и нефтегазовой отрасли\r\n";
            label1.Click += label1_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 725);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonClose);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button buttonClose;
        private PictureBox pictureBox1;
        private Label label1;
    }
}