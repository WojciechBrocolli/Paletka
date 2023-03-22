using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paletka
{
    public partial class FormArkanoid : Form
    {
        Graphics g;
        Rectangle Player;
        Rectangle Ball;
        bool keyLeft;
        bool keyRight;
        Point ballDirection = new Point(50,-50);

        public FormArkanoid()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ustawiam pelen ekran i kasuje 
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pictureBoxBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            pictureBoxBoard.Image = new Bitmap(pictureBoxBoard.Width, pictureBoxBoard.Height);
            g = Graphics.FromImage(pictureBoxBoard.Image);
            prepareNewGame();



        }
        private void prepareNewGame()
        {
            Player = new Rectangle(pictureBoxBoard.Width / 2 - Convert.ToInt32(pictureBoxBoard.Width * 0.15) / 2,
                Convert.ToInt32(pictureBoxBoard.Height * 0.9), Convert.ToInt32(pictureBoxBoard.Width * 0.15),
                Convert.ToInt32(pictureBoxBoard.Height * 0.05));
            Ball = new Rectangle(pictureBoxBoard.Width / 2 - Convert.ToInt32(pictureBoxBoard.Width * 0.02) / 2,
                Convert.ToInt32(pictureBoxBoard.Height * 0.8), Convert.ToInt32(pictureBoxBoard.Width * 0.02),
                Convert.ToInt32(pictureBoxBoard.Width * 0.02));
            ballDirection = new Point(50, -50);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            g.Clear(Color.Black);
            g.FillRectangle(new SolidBrush(Color.White), Player);
            g.FillEllipse(new SolidBrush(Color.White), Ball);
            PlayMovement();
            BallMovement();


            pictureBoxBoard.Refresh();
        }

        private void FormArkanoid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                keyLeft = true;
                keyRight = false;
            }

            else if (e.KeyCode == Keys.Right)
            {
                keyRight = true;
                keyLeft = false;
            }

        }


        private void PlayMovement()
        {
            if (keyLeft) Player.X -= 50;
            if (keyRight) Player.X += 50;

        }

        private void FormArkanoid_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                keyLeft = false;
                
            }

            else if (e.KeyCode == Keys.Right)
            {
                keyRight = false;
            }
        }
        
        private void BallMovement()
        {
            Ball.X += ballDirection.X;
            Ball.Y += ballDirection.Y;

            if (Ball.X+Ball.Width >= pictureBoxBoard.Width || Ball.X <= 0)
                ballDirection.X = -ballDirection.X;

            if(Ball.Y<0)
                ballDirection.Y = -ballDirection.Y;

            if (Ball.Y >= Player.Y + Player.Height + 50)
            { prepareNewGame(); }


            if(Player.X<=Ball.X  
                && Player.X+Player.Width    >=  Ball.X 
                && Player.Y   <=  Ball.Y+Ball.Height
                && Player.Y+Player.Height  >= Ball.Y + Ball.Height
                )
            {
                ballDirection.Y = -ballDirection.Y;
            }

        }



    }


}