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
    public partial class Form3 : Form
    {
        Label label10 = new Label() { Location = new Point(28, 124), Text = "Степень" };
        TextBox textBox8 = new TextBox() { Location = new Point(31, 152) };
        public Form3()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            label1.Text = "Число";
            this.Controls.Add(label10);
            this.Controls.Add(textBox8);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            label1.Text = "Число";
            this.Controls.Add(label10);
            this.Controls.Add(textBox8);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Show();
            label1.Text = "Первое число";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Show();
            label1.Text = "Первое число";
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox3.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox5.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Trigonometric_Form tri = new Trigonometric_Form();
                tri.R1 = double.Parse(textBox1.Text);
                tri.Angle1 = double.Parse(textBox2.Text);

                if (radioButton1.Checked == true)
                {
                    tri.R2 = double.Parse(textBox6.Text);
                    tri.Angle2 = double.Parse(textBox4.Text);
                    var result = tri.Multiplication();
                    textBox7.Text = ($"{Math.Round(result.Item2, 2)}(cos({Math.Round(result.Item1, 0)}) " + $"+ isin({Math.Round(result.Item1, 0)}))" + Environment.NewLine);
                }
                else if (radioButton2.Checked == true)
                {
                    tri.R2 = double.Parse(textBox6.Text);
                    tri.Angle2 = double.Parse(textBox4.Text);
                    var result = tri.Division();
                    textBox7.Text = ($"{Math.Round(result.Item2, 2)}(cos({Math.Round(result.Item1, 0)}) " + $"+ isin({Math.Round(result.Item1, 0)}))" + Environment.NewLine);
                }
                else if (radioButton3.Checked == true)
                {
                    tri.N = double.Parse(textBox8.Text);
                    var result = tri.Power();
                    textBox7.Text = ($"{Math.Round(result.Item2, 2)}(cos({Math.Round(result.Item1, 0)}) " + $"+ isin({Math.Round(result.Item1, 0)}))" + Environment.NewLine);
                }
                else if (radioButton4.Checked == true)
                {
                    tri.N = double.Parse(textBox8.Text);
                    var result = tri.Root();
                    textBox7.Text += ($"{Math.Round(result.Item2, 2)}(cos({Math.Round(result.Item1, 0)}) " + $"+ isin({Math.Round(result.Item1, 0)}))" + Environment.NewLine);
                }
                else
                {
                    MessageBox.Show("Выберите действие");
                }
            }
            catch
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
