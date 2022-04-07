using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Algebraic_Form alg = new Algebraic_Form();
                alg.A1 = double.Parse(textBox1.Text);
                alg.A2 = double.Parse(textBox3.Text);
                alg.B1 = double.Parse(textBox2.Text);
                alg.B2 = double.Parse(textBox4.Text);
                if (radioButton1.Checked == true)
                {
                    var result = alg.Addition();
                    textBox5.Text += "Результат сложения = " + result.Item1 + "+" + result.Item2 + "i" + Environment.NewLine;
                }
                else if (radioButton2.Checked == true)
                {
                    var result = alg.Substruction();
                    textBox5.Text += "Результат вычитания = " + result.Item1 + "+" + result.Item2 + "i" + Environment.NewLine;
                }
                else if (radioButton3.Checked == true)
                {
                    var result = alg.Multiplication();
                    textBox5.Text += "Результат умножения = " + result.Item1 + "+" + result.Item2 + "i" + Environment.NewLine;
                }
                else if (radioButton4.Checked == true)
                {
                    if (alg.A2 != 0 && alg.B2 != 0)
                    {
                        var result = alg.Division();
                        textBox5.Text += "Результат деления = " + result.Item1 + "+" + result.Item2 + "i" + Environment.NewLine;
                    }
                    else
                    {
                        MessageBox.Show("Деление на 0 невозможно");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите действие");
                }
            }
            catch
            {
                MessageBox.Show("Вы ввели неправильный формат данных");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
