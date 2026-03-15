using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace labaWork1
{
    public partial class HomeWork : Form
    {
        public HomeWork()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            transl.Visible = true;
            orig.Visible = true;
        }
        public string  Tranform(int a, int b)
        {
            string res;
            if (a < b)
            {
                res = a.ToString();
            }
            else
            {
                res = Tranform(a / b, b) + (a % b).ToString();
            }
            return res;
            //double res = 0;
            //if (a >= b)Tranform(a/b, b);
            // res = a % b;
            //lab.Text += res.ToString();        
        }

        private void transl_Click(object sender, EventArgs e)
        {
            int chislo = 0;
            int stepen = 0;
            if (!int.TryParse(orig.Text, out  chislo)) { 
                label2.Text =chislo.ToString();
                MessageBox.Show("другое чилсо");
            }
            if (!int.TryParse(osnova.Text, out  stepen))
            {
                label2.Text += stepen.ToString();
                MessageBox.Show("Введите корректное основание системы!", "Ошибка");
               
            }
            if (stepen < 2 || stepen > 9)
            {
                MessageBox.Show("Основание системы должно быть от 2 до 9!", "Ошибка");
               
            }
            if (chislo == 0)
            {
                lab.Text = "0";
                return;
            }
            string result = Tranform(chislo, stepen);
            lab.Text = $"Число {chislo} в системе с основанием {stepen} = {result}";

        }
    }
}
