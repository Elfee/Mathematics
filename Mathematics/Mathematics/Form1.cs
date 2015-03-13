using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameForBaby2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 0;
        int b = 0;
        int c = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Primer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int otvet;
            int.TryParse(textBox1.Text,out otvet);
            if (c == 0)
            {
                if (a + b == otvet)
                {
                    MessageBox.Show("Молодец!Чмоки-Чмоки!");
                    Primer();
                }
                else
                {
                    MessageBox.Show("Неправильно(");
                }
            }
            else
            {
                if (a - b == otvet)
                {
                    MessageBox.Show("Молодец!");
                    Primer();
                }
                else
                {
                    MessageBox.Show("Неправильно(");
                }
            }

            textBox1.Text = "";
        }
        public void Primer()
        {
            Random r = new Random();
            a = r.Next(10);
            b = r.Next(10);
            c = r.Next(0,2);
            if (c == 0)
            {
                label1.Text = a + "+" + b;
            }
            else
            {
                a = r.Next(10);
                b = r.Next(a);
                label1.Text = a + "-" + b;
            }
        }

    }
}
