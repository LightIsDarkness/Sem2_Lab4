using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace Sem2Lab4
{
    public partial class Form2 : Form
    {
        public Form Form1 { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = Logical.GetPhrace()[0];
            richTextBox2.Text = Logical.GetPhrace()[1];
            richTextBox3.Text = Logical.GetPhrace()[2];
            richTextBox4.Text = Logical.GetPhrace()[3];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Logical.Save(richTextBox1.Text,richTextBox2.Text,richTextBox3.Text,richTextBox4.Text);
        }
    }
}
