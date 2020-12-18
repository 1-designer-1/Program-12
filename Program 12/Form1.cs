using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.textBox1, "x1"); // Подсказки 
            toolTip1.SetToolTip(this.textBox2, "y1");
            toolTip1.SetToolTip(this.textBox3, "x2");
            toolTip1.SetToolTip(this.textBox4, "y2");
            toolTip1.SetToolTip(this.textBox5, "1 килобайт = 1024 байта");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Серегин Денис\n" +
               "гр.ИСП-31\n" +
               "Задание 1\n" +
               "Даны координаты двух противоположных вершин прямоугольника: (x1, y1), (x2,y2).Стороны прямоугольника параллельны осям координат.\n" +
               "Найти периметр иплощадь данного прямоугольника.\n" +
               "Задание 2\n" +
               "Дан размер файла в байтах. Используя операцию деления нацело, найти количество полных килобайтов, которые занимает данный файл.", "Задание 12", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateTime(object sender, EventArgs e)
        {
            Time();
        }
        public void Time()
        {
            DateTime t = DateTime.Now;
            statusTime.Text = "Время: " + t.ToString("HH:mm");
            statusData.Text = "Дата: " + t.ToString("dd.MM.yyyy");

        }

        private void numderTask(object sender, EventArgs e)//событие изменения номера задачи при переключении вкладок
        {

            if (tabControl1.SelectedIndex == 0)
            {
                statusTask.Text = "Номер задачи - " + 1;
            }
            else
            {
                statusTask.Text = "Номер задачи - " + 2;
            }
        }

        private void button1_Click(object sender, EventArgs e) // событие 1 рассчет периметра и площади прямоугольника 
        {
            int x1, y1, x2, y2, a, b;
            int per, s;
            bool k, l, m, n;
            k = int.TryParse(textBox1.Text, out x1);
            l = int.TryParse(textBox2.Text, out y1);
            m = int.TryParse(textBox3.Text, out x2);
            n = int.TryParse(textBox4.Text, out y2);
            if (k == true && l == true && m == true && n == true)
            {
                a = Math.Abs(x2 - x1);
                b = Math.Abs(y2 - y1);
                per = (a + b) * 2;
                s = a * b;
                textBox8.Text = Convert.ToString(s);
                textBox7.Text = Convert.ToString(per);
            }
            else MessageBox.Show("Введите правильное значение");
        }

        private void button2_Click(object sender, EventArgs e)// событие 2 рассчет количества полных килобайтов
        {
            int b, kb;
            bool a = int.TryParse(textBox5.Text, out b);
            if (a == true)
            {
                kb = b / 1024;
                textBox6.Text = kb.ToString();
            }
            else MessageBox.Show("Введите правельное значения");
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) // удаление значений  для событие 1
        {
            textBox1.Clear();
            textBox2.Clear(); 
            textBox3.Clear();
            textBox4.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox1.Focus();

        }

        private void очиститьToolStripMenuItem1_Click(object sender, EventArgs e)// удаление значений для событие 2
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox5.Focus();
        }

        private void получитьРезультатToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x1, y1, x2, y2, a, b;
            int per, s;
            bool k, l, m, n;
            k = int.TryParse(textBox1.Text, out x1);
            l = int.TryParse(textBox2.Text, out y1);
            m = int.TryParse(textBox3.Text, out x2);
            n = int.TryParse(textBox4.Text, out y2);
            if (k == true && l == true && m == true && n == true)
            {
                a = Math.Abs(x2 - x1);
                b = Math.Abs(y2 - y1);
                per = (a + b) * 2;
                s = a * b;
                textBox8.Text = Convert.ToString(s);
                textBox7.Text = Convert.ToString(per);
            }
            else MessageBox.Show("Введите правильное значение");
        } //событие 1 рассчет периметра и площади прямоугольника в контекстом меню

        private void заполнитьСлучайнымиЧисламиToolStripMenuItem_Click(object sender, EventArgs e) //  заполнияе случайными числами от 0 до 20 событие 1 в контекстном меню
        {
            Random random = new Random();
            textBox1.Text = Convert.ToString(random.Next(0, 20));
            textBox2.Text = Convert.ToString(random.Next(0, 20));
            textBox3.Text = Convert.ToString(random.Next(0, 20));
            textBox4.Text = Convert.ToString(random.Next(0, 20));
        }

        private void ввод1024ToolStripMenuItem_Click(object sender, EventArgs e) // ввод 1024 события 2 в контекстном меню
        {
            textBox5.Text = "1024";
        }

        private void значениеToolStripMenuItem_Click(object sender, EventArgs e)// событие 2 рассчет количества полных килобайтов  в контекстном меню
        {
            int b, kb;
            bool a = int.TryParse(textBox5.Text, out b);
            if (a == true)
            {
                kb = b / 1024;
                textBox6.Text = kb.ToString();
            }
            else MessageBox.Show("Введите правельное значения");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) // Закрытие формы
        {
            this.Close();
        }
    }
}
