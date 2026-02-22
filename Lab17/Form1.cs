using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Перевірка чи введенено цифру.
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }

            // Змінимо крапку на кому якщо користувач ввів крапку.
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }

            // Забороняємо ставити кому, якщо користувач вже вводив одну.
            if (e.KeyChar == ',')
            {
                if (inputTextBox.Text.IndexOf(",") == -1)
                {
                    return;
                }
            }

            // Встановлюємо контроль за допомогою esc, enter, backspace.
            if (char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    dollarButton.Focus();
                }
                return;
            }

            // Символи які не пройшли жодної перевірки забороняються.
            e.Handled = true;
        }

        private void dollarButton_Click(object sender, EventArgs e)
        {
            // Перевірка на коректне введення, чи поле не пусте, чи там не просто кома. 
            if ((inputTextBox.Text == "") || (inputTextBox.Text == ","))
            {
                return;
            }

            // Отримуємо значення з поля. 
            double value = Convert.ToDouble(inputTextBox.Text);

            // Створюємо об'єкт класу долар за допомогою конструктора. 
            Dollar dollar = new Dollar(value);

            // Виводимо значення у ListBox. 
            exportListBox.Items.Add("Створено об'єкт класу долар!");
            exportListBox.Items.Add(dollar.print());
            exportListBox.Items.Add($"Значення в гривнях: {dollar.toGRN()}");
        }

        private void euroButton_Click(object sender, EventArgs e)
        {
            // Перевірка на коректне введення, чи поле не пусте, чи там не просто кома. 
            if ((inputTextBox.Text == "") || (inputTextBox.Text == ","))
            {
                return;
            }

            // Отримуємо значення з поля. 
            double value = Convert.ToDouble(inputTextBox.Text);

            // Створюємо об'єкт класу євро за допомогою конструктора. 
            Euro euro = new Euro(value);

            // Виводимо значення у ListBox. 
            exportListBox.Items.Add("Створено об'єкт класу євро!");
            exportListBox.Items.Add(euro.print());
            exportListBox.Items.Add($"Значення в гривнях: {euro.toGRN()}");
        }
    }
}
