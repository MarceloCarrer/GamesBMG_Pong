using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form2 : Form
    {
        private bool checkUp;
        private bool checkDown;
        private int speed;
        private int posX;
        private int posY;
        private int playerScore;
        private int CPUScore;
        private string winner;
        private bool endGame;

        private DialogResult result;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(int speed, int size, int posX, int posY)
        {
            InitializeComponent();

            this.speed = speed;
            this.posX = posX;
            this.posY = posY;
            playerScore = 0;
            CPUScore = 0;
            CPU_pbx.Height = size;
        }

        private void PressKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                checkUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                checkDown = true;
            }
        }

        private void PressKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                checkUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                checkDown = false;
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            ScorePlayer_lbl.Text = "" + playerScore;
            ScoreCPU_lbl.Text = "" + CPUScore;

            Arrow_pbx.Top += posY;
            Arrow_pbx.Left += posX;

            CPU_pbx.Top += speed;

            CPULimits();
            CheckWinner();
            ArrowMoviment();
            PlayerMoviment();
        }

        //Movimento do Player
        public void PlayerMoviment()
        {
            if (checkUp && Player_pbx.Top > 0)
            {
                Player_pbx.Top -= 8;
            }

            if (checkDown && Player_pbx.Top < 455)
            {
                Player_pbx.Top += 8;
            }
        }

        //Valida o limite para o CPU não sair da tela
        public void CPULimits()
        {
            if (CPU_pbx.Bounds.IntersectsWith(BorderUp_pbx.Bounds) || CPU_pbx.Bounds.IntersectsWith(BorderDown_pbx.Bounds))
            {
                speed = -speed;
            }
        }

        //Verifica o ganhador
        public void CheckWinner()
        {
            if (playerScore == 5)
            {
                winner = "PLAYER";
                endGame = true;
            }
            else if (CPUScore == 5)
            {
                winner = "CPU";
                endGame = true;
            }

            if (endGame)
            {
                this.Close();
                timer1.Stop();
                result = MessageBox.Show(winner + " WIN!!", "END GAME", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        //Verifica a movimentação da flecha
        public void ArrowMoviment()
        {
            //Valida se a flecha chegou no limite do Player
            if (Arrow_pbx.Left < 0)
            {
                Arrow_pbx.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                Arrow_pbx.Left = 434;
                posX = -posX;
                posX -= 2;
                CPUScore++;
            }

            //Valida se a flecha chegou no limite do CPU
            if (Arrow_pbx.Left + Arrow_pbx.Width > ClientSize.Width)
            {
                Arrow_pbx.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
                Arrow_pbx.Left = 434;
                posX = -posX;
                posX -= 2;
                playerScore++;
            }

            //Faz a Flecha recochetear na borda superior e inferior
            if (Arrow_pbx.Top < 0 || Arrow_pbx.Top + Arrow_pbx.Height > ClientSize.Height)
            {
                posY = -posY;
            }

            //Verifica colisão da Flecha com o Player e CPU
            if (Arrow_pbx.Bounds.IntersectsWith(Player_pbx.Bounds) || Arrow_pbx.Bounds.IntersectsWith(CPU_pbx.Bounds))
            {
                posX = -posX;
                Arrow_pbx.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipY);
            }
        }
    }
}
