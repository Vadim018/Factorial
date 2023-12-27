using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримуємо рядок з останнього рядка в dataGridView
            DataGridViewRow lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 2]; // -2, оскільки індекси починаються з 0

            // Отримуємо значення останнього елемента
            int lastValue = Convert.ToInt32(lastRow.Cells[0].Value);

            // Обчислюємо факторіал
            int factorial = CalculateFactorial(lastValue);

            // Виводимо результат у textBox
            textBox1.Text = factorial.ToString();
        }

        private int CalculateFactorial(int n)
        {
            if (n == 0)
                return 1;

            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}