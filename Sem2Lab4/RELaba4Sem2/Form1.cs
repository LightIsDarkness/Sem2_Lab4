using Logic;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace Sem2Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Нижний Регистр");
            comboBox1.Items.Add("Верхний Регистр");
            comboBox1.Items.Add("Заглавная буква + нижний Регистр");
        }

        private void GetDictinary_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Form1 = this;
            form2.Show();
        }

        private void GenerateText_Click(object sender, EventArgs e)
        {
            if (Logical.GetPhrace().Count == 0)
            {
                MessageBox.Show("СЛОВАРЬ ДАННЫХ ПУСТОЙ!");
            }
            else
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Введите количество слов!");
                }
                else if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Выберите Регистр!");
                }
                else
                {
                    richTextBox1.Text = Logical.GenerateText(Convert.ToInt32(textBox1.Text), checkBox1.Checked, comboBox1.SelectedItem.ToString());
                }
            }

            label3.Text = "Общее количество символов: " + Logical.GetTotalCharacters(richTextBox1.Text);
            label4.Text = "Общее количество слов: " + Logical.GetTotalWords(richTextBox1.Text);
            label5.Text = "Общее количество уникальных слов: " + Logical.GetUniqueWords(richTextBox1.Text);

            chart1.Series.Clear();
            if (checkBox1.Checked)
            {
                if (Logical.GetTotalWords(richTextBox1.Text) > 100)
                {
                    chart1.ChartAreas[0].AxisY.Maximum = Logical.GetTop5Words(richTextBox1.Text)[0].Item2;
                    foreach (var tuple in Logical.GetTop5Words(richTextBox1.Text))
                    {
                        Series series = chart1.Series.Add(tuple.Item1);
                        series.Points.Add(tuple.Item2);
                    }
                }
                else
                {
                    chart1.ChartAreas[0].AxisY.Maximum = Logical.GetTotalWords(richTextBox1.Text) /2;
                    foreach (var tuple in Logical.GetTop5Words(richTextBox1.Text))
                    {
                        Series series = chart1.Series.Add(tuple.Item1);
                        series.Points.Add(tuple.Item2);
                    }
                }
                
            }
            else
            {
                chart1.ChartAreas[0].AxisY.Maximum = Logical.GetTotalWords(richTextBox1.Text)/3;
                foreach (var tuple in Logical.GetTop5Words(richTextBox1.Text))
                {
                    Series series = chart1.Series.Add(tuple.Item1);
                    series.Points.Add(tuple.Item2);
                }
            }
            
        }

    }
}
