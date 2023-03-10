using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyGame
{
    public partial class Form1 : Form
    {
        // глобальные переменные
        int Score = 0;
        int timer = 20;
        bool isRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFly_Click(object sender, EventArgs e)
        {
            if (isRunning == false)
            {
                timerGame.Enabled = true;
                isRunning = true;
            }

            #region Move Fly

            // Random
            Random r = new Random();

            int x = r.Next(0, 850 - buttonFly.Width - 20);
            int y = r.Next(0, 600 - buttonFly.Height - 20);

            buttonFly.Left = x;
            buttonFly.Top = y;

            #endregion

            Score++;
            labelScore.Text = "Score: " + Score.ToString();

            //score = score + 1;
            //score += 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelTimer_Click(object sender, EventArgs e)
        {

        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            timer--;
            labelTimer.Text = "Timer: " + timer.ToString();

            if (timer == 0)
            {
                timerGame.Enabled = false; // останавливаем таймер
                buttonFly.Enabled = false; // отключаем нажатие на кнопку

                #region itog

                // итоги игры
                if (Score < 15)
                {
                    MessageBox.Show("Bad");
                }
                else if (Score < 20)
                {
                    MessageBox.Show("Normal");
                }
                else
                {
                    MessageBox.Show("Cool!");
                }
                #endregion

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
