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
    }
}
