using System;
using System.Windows.Forms;

namespace Artemkin.HomeWork._23._11
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task1 task1 = new Task1();
            task1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task2 task2 = new Task2();
            task2.Show();
        }
    }
}
