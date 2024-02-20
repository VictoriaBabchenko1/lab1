using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        delegate void ButtonAction(object sender, EventArgs e);

        public Form1()
        {
            InitializeComponent();
            button1.Text = "Прозорість";
            button2.Text = "Колір тла";
            button3.Text = "Hello world";
            button4.Text = "Супермегакнопка";

            checkBox1.Text = "\"Супермегакнопка\" поглинає \"прозорість\"";
            checkBox2.Text = "\"Супермегакнопка\" поглинає \"колір тла\"";
            checkBox3.Text = "\"Супермегакнопка\" поглинає \"Hello world\"";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                this.Opacity -= 0.5;
            }
            else
            {
                this.Opacity += 0.5;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Lavender)
            {
                this.BackColor = Color.Thistle;
            }
            else
            {
                this.BackColor = Color.Lavender;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");

            ButtonAction action = null;

            if (checkBox1.Checked)
            {
                action += button1_Click;
            }

            if (checkBox2.Checked)
            {
                action += button2_Click;
            }

            if (checkBox3.Checked)
            {
                action += button3_Click;
            }

            action?.Invoke(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
