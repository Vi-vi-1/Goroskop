using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Знаки_зодиака
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private static string Znak = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Znak = Goroskop (dateTimePicker1.Value.Day, dateTimePicker1.Value.Month);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        string Goroskop(int day, int month)
        {
            

            if (month == 12)
            {
                if (day < 22)
                {
                    label1.Text = "Стрелец";
                    pictureBox1.Image = Image.FromFile("Стрелец.jpg");
                }
                else
                {
                    label1.Text = "Козерог"; pictureBox1.Image = Image.FromFile("Козерог.jpg");
                }
            }
            else if (month == 1)
            {
                if (day < 20)
                {
                    label1.Text = "Козерог";
                    pictureBox1.Image = Image.FromFile("Козерог.jpg");
                }
                else
                {
                    label1.Text = "Водолей"; pictureBox1.Image = Image.FromFile("Водолей.jpg");
                }
            }
            else if (month == 2)
            {
                if (day < 19)
                {
                    label1.Text = "Водолей"; pictureBox1.Image = Image.FromFile("Водолей.jpg");
                }
                else
                {
                    label1.Text = "Рыбы"; pictureBox1.Image = Image.FromFile("Рыбы.jpg");
                }
            }
            else if (month == 3)
            {
                if (day < 21)
                {
                    label1.Text = "Рыбы"; pictureBox1.Image = Image.FromFile("Рыбы.jpg");
                }
                else
                {
                    label1.Text = "Овен"; pictureBox1.Image = Image.FromFile("Овен.jpg");
                }
            }
            else if (month == 4)
            {
                if (day < 20)
                {
                    label1.Text = "Овен"; pictureBox1.Image = Image.FromFile("Овен.jpg");
                }
                else
                {
                    label1.Text = "Телец"; pictureBox1.Image = Image.FromFile("Телец.jpg");
                }
            }
            else if (month == 5)
            {
                if (day < 21)
                {
                    label1.Text = "Телец"; pictureBox1.Image = Image.FromFile("Телец.jpg");
                }
                else
                {
                    label1.Text = "Близнецы"; pictureBox1.Image = Image.FromFile("Близнецы.jpg");
                }
            }
            else if (month == 6)
            {
                if (day < 21)
                {
                    label1.Text = "Близнецы"; pictureBox1.Image = Image.FromFile("Близнецы.jpg");
                }
                else
                {
                    label1.Text = "Рак"; pictureBox1.Image = Image.FromFile("Рак.jpg");
                }
            }
            else if (month == 7)
            {
                if (day < 23)
                {
                    label1.Text = "Рак"; pictureBox1.Image = Image.FromFile("Рак.jpg");
                }
                else
                {
                    label1.Text = "Лев"; pictureBox1.Image = Image.FromFile("Лев.jpg");
                }
            }
            else if (month == 8)
            {
                if (day < 23)
                {
                    label1.Text = "Лев"; pictureBox1.Image = Image.FromFile("Лев.jpg");
                }
                else
                {
                    label1.Text = "Дева"; pictureBox1.Image = Image.FromFile("Дева.jpg");
                }
            }
            else if (month == 9)
            {
                if (day < 23)
                {
                    label1.Text = "Дева"; pictureBox1.Image = Image.FromFile("Дева.jpg");
                }
                else
                {
                    label1.Text = "Весы"; pictureBox1.Image = Image.FromFile("Весы.jpg");
                }
            }
            else if (month == 10)
            {
                if (day < 23)
                {
                    label1.Text = "Весы"; pictureBox1.Image = Image.FromFile("Весы.jpg");
                }
                else
                {
                    label1.Text = "Скорпион"; pictureBox1.Image = Image.FromFile("Скорпион.jpg");
                }
            }
            else if (month == 11)
            {
                if (day < 22)
                {
                    label1.Text = "Скорпион"; pictureBox1.Image = Image.FromFile("Скорпион.jpg");
                }
                else
                {
                    label1.Text = "Стрелец"; pictureBox1.Image = Image.FromFile("Стрелец.jpg");
                }
            }


            return goro_sign;
        }
    
    }
}
