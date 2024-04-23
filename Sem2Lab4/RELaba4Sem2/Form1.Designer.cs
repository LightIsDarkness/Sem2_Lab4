namespace Sem2Lab4
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            GetDictinary = new Button();
            GenerateText = new Button();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(13, 11);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(890, 577);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(GetDictinary);
            tabPage1.Controls.Add(GenerateText);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(882, 544);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Генерация текста";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // GetDictinary
            // 
            GetDictinary.Location = new Point(692, 331);
            GetDictinary.Margin = new Padding(3, 4, 3, 4);
            GetDictinary.Name = "GetDictinary";
            GetDictinary.Size = new Size(166, 65);
            GetDictinary.TabIndex = 7;
            GetDictinary.Text = "Получить словарь данных";
            GetDictinary.UseVisualStyleBackColor = true;
            GetDictinary.Click += GetDictinary_Click;
            // 
            // GenerateText
            // 
            GenerateText.Location = new Point(520, 331);
            GenerateText.Margin = new Padding(3, 4, 3, 4);
            GenerateText.Name = "GenerateText";
            GenerateText.Size = new Size(166, 65);
            GenerateText.TabIndex = 6;
            GenerateText.Text = "Сгенерировать текст";
            GenerateText.UseVisualStyleBackColor = true;
            GenerateText.Click += GenerateText_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(533, 192);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Случайный выбор";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(533, 134);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(228, 28);
            comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(553, 96);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 3;
            label2.Text = "Выберите регистр:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(553, 15);
            label1.Name = "label1";
            label1.Size = new Size(252, 20);
            label1.TabIndex = 2;
            label1.Text = "Количество предложений в тексте:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(17, 12);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(479, 497);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(533, 48);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(chart1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(882, 544);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Статистика";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 200);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(489, 133);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(489, 63);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(21, 35);
            chart1.Margin = new Padding(3, 4, 3, 4);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(389, 388);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Button GetDictinary;
        private Button GenerateText;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}
