using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            pictureBoxCar1.Left = pictureBoxCar1.Left + r.Next(0, 10);
            pictureBoxCar2.Left = pictureBoxCar2.Left + r.Next(0, 10);
            pictureBoxCar3.Left = pictureBoxCar3.Left + r.Next(0, 10);
            pictureBoxCar4.Left = pictureBoxCar4.Left + r.Next(0, 10);

            /*if (pictureBoxCar1.Right >= buttonFinish.Left ||
                pictureBoxCar2.Right >= buttonFinish.Left ||
                pictureBoxCar3.Right >= buttonFinish.Left ||
                pictureBoxCar4.Right >= buttonFinish.Left)
            {
                timerGame.Enabled= false;
            } */

            if (pictureBoxCar1.Right >= buttonFinish.Left)
            {
                timerGame.Enabled = false;
                MessageBox.Show("Green car has wone!");
            }
            else if (pictureBoxCar2.Right >= buttonFinish.Left)
            {
                timerGame.Enabled = false;
                MessageBox.Show("Yellow car has wone!");
            }
            else if (pictureBoxCar3.Right >= buttonFinish.Left)
            {
                timerGame.Enabled = false;
                MessageBox.Show("Red car has wone!");
            }
            else if (pictureBoxCar4.Right >= buttonFinish.Left)
            {
                timerGame.Enabled = false;
                MessageBox.Show("Green car 2 has wone!");
            }
        }

        private void pictureBoxCar1_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerGame.Enabled= true;
        }
    }
}
