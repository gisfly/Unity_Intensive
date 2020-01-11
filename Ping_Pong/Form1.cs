using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ping_Pong
{
    public partial class Form1 : Form
    {
        private int speedX = 4;
        private int speedY = 4;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            bat.Top = canvas.Bottom - (canvas.Bottom / 10);
            info.Text = "Клавиши управления: Esc - выход из игры, R - сброс, P - пауза/возобновление игры. ";
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            bat.Left = Cursor.Position.X - (bat.Width / 2);
            ball.Top += speedY;
            ball.Left += speedX;
            if (ball.Bottom >= bat.Top && ball.Bottom <= bat.Bottom && ball.Left >= bat.Left && ball.Right <= bat.Right)
            {
                speedX += 2;
                speedY += 2;
                speedY *= -1;
                gameScore.Text = $"Счёт: {Convert.ToString(++score)}";
                Random rand = new Random();
                canvas.BackColor = Color.FromArgb(rand.Next(150, 256), rand.Next(150, 256), rand.Next(150, 256));
            }
            if (ball.Left <= canvas.Left) speedX *= -1;
            if (ball.Top <= canvas.Top) speedY *= -1;
            if (ball.Right >= canvas.Right) speedX *= -1;
            if (ball.Bottom >= canvas.Bottom)
            {
                timer.Enabled = false;
                GameInfo("Игра окончена");
                gameScore.Visible = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode == Keys.R) Restart();
            if (e.KeyCode == Keys.P)
            {
                timer.Enabled = !timer.Enabled;
                if (!timer.Enabled)
                {
                    GameInfo("Пауза");
                }
                else gameInfo.Visible = false;
            }
        }

        private void Restart()
        {
            Random rand = new Random();
            ball.Left = rand.Next(10, canvas.Width);
            ball.Top = 5;
            gameInfo.Visible = false;
            gameScore.Text = "Счёт: 0";
            gameScore.Visible = true;
            timer.Enabled = true;
            speedX = 4;
            speedY = 4;
            score = 0;
        }
        private void GameInfo(string str)
        {
            gameInfo.Left = (canvas.Width / 2) - (gameInfo.Left / 2);
            gameInfo.Top = (canvas.Height / 2) - (gameInfo.Top / 2);
            gameInfo.Text = $"{str}!\nВаш счет {Convert.ToString(score)}";
            gameInfo.Visible = true;
        }
    }
}
