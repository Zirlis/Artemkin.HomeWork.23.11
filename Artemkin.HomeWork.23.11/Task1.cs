using System;
using System.Collections.Generic;
using System.Windows.Forms;

//1.а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. 
//Игрок должен постараться получить это число за минимальное количество ходов.
//в) *Добавить кнопку «Отменить», которая отменяет последние ходы.

namespace Artemkin.HomeWork._23._11
{
    public partial class Task1 : Form
    {
        private int _randomNumber;
        private int _cNumber = 0;
        private int _cTry = 0;
        private List<int> _actions = new List<int>();

        public Task1()
        {
            InitializeComponent();

            Random random = new Random();
            _randomNumber = random.Next(10, 99);
            mainText.Text = $"Вам нужно получить число {_randomNumber}";
        }        

        private void plusOne_Click(object sender, EventArgs e)
        {
            _cNumber++;
            currentNumber.Text = _cNumber.ToString();
            _cTry++;
            currentTry.Text = _cTry.ToString();
            _actions.Add(1);

            if(_cNumber == _randomNumber)
            {
                MessageBox.Show("Вы победили");
            }
        }

        private void multiplyByTwo_Click(object sender, EventArgs e)
        {
            _cNumber *= 2;
            currentNumber.Text = _cNumber.ToString();
            _cTry++;
            currentTry.Text = _cTry.ToString();
            _actions.Add(2);

            if (_cNumber == _randomNumber)
            {
                MessageBox.Show("Вы победили");
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if(_actions.Count > 0)
            {
                if(_actions[_actions.Count - 1] == 1)
                {
                    _cNumber--;
                    currentNumber.Text = _cNumber.ToString();
                    _cTry--;
                    currentTry.Text = _cTry.ToString();
                    _actions.RemoveAt(_actions.Count - 1);
                }
                else if(_actions[_actions.Count - 1] == 2)
                {
                    _cNumber /= 2;
                    currentNumber.Text = _cNumber.ToString();
                    _cTry--;
                    currentTry.Text = _cTry.ToString();
                    _actions.RemoveAt(_actions.Count - 1);
                }
            }
        }

        private void discharge_Click(object sender, EventArgs e)
        {
            _cNumber = 0;
            currentNumber.Text = _cNumber.ToString();
            _cTry = 0;
            currentTry.Text = _cTry.ToString();
            _actions = new List<int>();
            Random random = new Random();
            _randomNumber = random.Next(10, 99);
            mainText.Text = $"Вам нужно получить число {_randomNumber}";
        }
    }
}
