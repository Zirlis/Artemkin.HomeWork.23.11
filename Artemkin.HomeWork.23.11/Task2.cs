using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artemkin.HomeWork._23._11
{
    public partial class Task2 : Form
    {
        private int _randomNumber;

        public Task2()
        {
            InitializeComponent();
            Random random = new Random();
            _randomNumber = random.Next(1, 100);
            mainTextBox.MaxLength = 3;
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(mainTextBox.Text, out int userNumber))
            {
                mainLabel.Text = "Введите число";
            }
            else if (userNumber == _randomNumber)
            {
                MessageBox.Show("Вы победили");
            }
            else if (userNumber > _randomNumber)
            {
                mainLabel.Text = "Ваше число больше загаданного";
            }
            else if (userNumber < _randomNumber)
            {
                mainLabel.Text = "Ваше число меньше загаданного";
            }
        }
    }
}
