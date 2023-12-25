using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rally
{
    public partial class Rally : Form
    {
        int roadSpeed;
        int trafficSpeed;
        int playerSpeed = 10;
        int score_count;
        int carImage;

        Random carImgRand = new Random();
        Random carPosition = new Random();

        bool goleft, goright;

        public Rally()
        {
            InitializeComponent();
            resetGame();
        }


        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void gameTimeEvent(object sender, EventArgs e)
        {
            score.Text = "Score: " + score_count;
            score_count++;

            if (goleft == true && player.Left > 34)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Right < 320)
            {
                player.Left += playerSpeed;
            }

            road.Top += roadSpeed;
            road2.Top += roadSpeed;

            if (road2.Top > 400)
            {
                road2.Top = -400;
            }

            if (road.Top > 400)
            {
                road.Top = -400;
            }

            AIcar1.Top += trafficSpeed;
            AIcar2.Top += trafficSpeed;

            if (AIcar1.Top > 530)
            {
                changeAIcars(AIcar1);
            }

            if (AIcar2.Top > 530)
            {
                changeAIcars(AIcar2);
            }

            if (player.Bounds.IntersectsWith(AIcar1.Bounds) || player.Bounds.IntersectsWith(AIcar2.Bounds))
            {
                gameOver();
            }

            if (score_count % 250 == 0)
            {
                roadSpeed += 1;
                trafficSpeed += 2;
            }
           
        }

        private void changeAIcars (PictureBox temCar)
        {
            carImage = carImgRand.Next(1, 4);
            switch (carImage)
            {
                case 1:
                    temCar.Image = Properties.Resources.car1;
                    break;
                case 2:
                    temCar.Image = Properties.Resources.car2;
                    break;
                case 3:
                    temCar.Image = Properties.Resources.car3;
                    break;
                case 4:
                    temCar.Image = Properties.Resources.car4;
                    break;
            }

            temCar.Top = carPosition.Next(100, 400) * -1;

            if ((string)temCar.Tag == "carLeft")
            {
                temCar.Left = carPosition.Next(34, 178);
            }
            if ((string)temCar.Tag == "carRight")
            {
                temCar.Left = carPosition.Next(233, 320);
            }
        }

        private void gameOver()
        {
            //playHitSound();
            gameTimer.Stop();
            explosion.Visible = true;
            player.Controls.Add(explosion);
            explosion.Location = new Point(-6, 10);
            explosion.BackColor = Color.Transparent;

            finalScore.Text = "GAME OVER\n" + "YOUR SCORE: " + (score_count - 1);
            finalScore.Visible = true;
            finalScore.BringToFront();

            btnStart.Enabled = true;
        }

        private void resetGame()
        {
            btnStart.Enabled = false;
            finalScore.Visible= false;
            explosion.Visible= false;
            goleft = false;
            goright= false;

            score_count = 0;
            roadSpeed = 10;
            trafficSpeed = 12;
            AIcar1.Top = carPosition.Next(200, 500) * -1;
            AIcar1.Left = carPosition.Next(34, 178);

            AIcar2.Top = carPosition.Next(200, 500) * -1;
            AIcar2.Left = carPosition.Next(233, 320);

            gameTimer.Start();

        }

        private void restartGame(object sender, EventArgs e)
        {
            resetGame();
        }

        private void playHitSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.hit);
            simpleSound.Play();
        }

    }
}
