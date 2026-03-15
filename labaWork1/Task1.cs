using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace labaWork1
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }
        private double CalculateHarmonicSum(uint n)
        {
            double sum = 0;
            if (n == 0)
            {
                sum = 0;
            }
            else 
            {
                sum= 1.0 / n + CalculateHarmonicSum(n - 1);
            }
            return sum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(uint.TryParse(txt.Text, out uint n))
                {
                    double res = CalculateHarmonicSum(n);
                    
                        string detail = "";
                    if (n <= 10)
                    {
                        for (uint i = 1; i <= n; i++)
                        {
                            detail += $"1/{i}";
                            if (i < n) detail += " + ";
                        }
                        detail += $" = {res:F10}";
                    }

                    // Выводим результат
                    lblRes.Text = $"Результат: {res:F10}\n{detail}";
                }
                else
                {
                    MessageBox.Show("Введите целое неотрицательное число.",
                        "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
