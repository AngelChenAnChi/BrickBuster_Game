using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
namespace Brick_Buster_Game
{
    public partial class Form1 : Form
    {
        int brickRow = 3;
        int brickCol = 7;
        PictureBox[,] bricks;
        int xSpeed = 30;
        int ySpeed = 30;
        int life = 3;
        int level = 1;
        int score = 0;
        int getPoint = 5;
        int loosePoint = -10;
        bool allGone = false;
        int count = 3;
        bool tcd = false;
        bool t1 = false;
 
        //bricks on winform
        void StartGame()
        {
            LifeLevel();
            // set the number of bricks in different level
            if (level == 1)
            {
                brickRow = 3;
                brickCol = 7;
            }
            else if (level == 2)
            {
                brickRow = 5;
                brickCol = 9;
                xSpeed = xSpeed + 5;
                ySpeed = xSpeed + 5;
            }
            else if (level == 3)
            {
                brickRow = 7;
                brickCol = 11;
                xSpeed = xSpeed + 10;
                ySpeed = ySpeed + 10;
            }

            //design bricks on the form
            bricks = new PictureBox[brickRow, brickCol];
            int w, h = 40;
            w = ClientRectangle.Width / brickCol;

            for (int r = 0; r < brickRow; r++)
            {
                for (int c = 0; c < brickCol; c++)
                {
                    bricks[r, c] = new PictureBox();
                    bricks[r, c].Width = w;
                    bricks[r, c].Height = h;
                    bricks[r, c].Top = 60 + r * h;
                    bricks[r, c].Left = w * c;
                    bricks[r, c].SizeMode = PictureBoxSizeMode.StretchImage;
                    bricks[r, c].Image = pictureBox_brick.Image;
                    Controls.Add(bricks[r, c]);
                }
            }

        }
        void LifeLevel()
        {
            label_level.Text = $"Level : {level}";
            if (life == 3)
            {
                pictureBox_life.Visible = true;
            }
            else if (life == 2)
            {
                pictureBox_life.Visible = false;
            }
            else if (life == 1)
            {
                pictureBox_life2.Visible = false;
            }
            else if (life == 0)
            {
                pictureBox_life3.Visible = false;
            }
        }
        public string showScore()
        {
            return label_score.Text = $"SCORE: {score}";
        }
        void positionSet()
        {
            // postion of the start button
            button_start.Left = ClientRectangle.Width / 2 - button_start.Width / 2;
            button_start.Top = ClientRectangle.Height / 2 - button_start.Height;
            // position of the exit button
            button_exit.Left = ClientRectangle.Width / 2 - button_exit.Width / 2;
            button_exit.Top = ClientRectangle.Height / 2 - button_exit.Height;
            //postiion of the instruction
            label_instruction.Left = ClientRectangle.Width / 2 - label_instruction.Width / 2;
            label_instruction.Top = ClientRectangle.Height / 2 + label_instruction.Height / 2;
            //postion of the over
            label_over.Left = ClientRectangle.Width / 2 - label_over.Width / 2;
            label_over.Top = ClientRectangle.Height / 2 + label_over.Height;

        }
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            positionSet();
            StartGame();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            //movement of the ball
            pictureBox_ball.Left = pictureBox_ball.Left + xSpeed;
            pictureBox_ball.Top = pictureBox_ball.Top + ySpeed;

            //rebound (left and right)
            if (pictureBox_ball.Bounds.Right >= ClientRectangle.Width || pictureBox_ball.Bounds.Left <= 0)
            {
                //soundCollision.Play();
                xSpeed = -xSpeed;
            }
            //rebound (top and buttom)
            if (pictureBox_ball.Bounds.Top <= 50 || (pictureBox_ball.Bottom < pictureBox_bar.Bottom && pictureBox_ball.Bounds.IntersectsWith(pictureBox_bar.Bounds)))
            {
                //soundCollision.Play();
                ySpeed = -ySpeed;
            }

            allGone = true;
            // collision (ball and bricks)
            foreach (PictureBox b in bricks)
            {
                if (b.Visible)
                {
                    if (pictureBox_ball.Bounds.IntersectsWith(b.Bounds))
                    {
                        b.Visible = false;
                        score = score + getPoint;                    
                    }
                }
                if (b.Visible) allGone = false;
            }


            // all bricks are disappeared
            if (allGone)
            {           
                timer1.Enabled = false;
                //up level
                level = level + 1;
                //next level, button show up
                if (level <= 3)
                {
                    button_start.Visible = true;
                    pictureBox_ball.Left = ClientRectangle.Width / 2 - pictureBox_ball.Width / 2;
                    pictureBox_ball.Top = ClientRectangle.Height / 2 + pictureBox_ball.Height * 4;
                    pictureBox_bar.Left = ClientRectangle.Width / 2 - pictureBox_bar.Width / 2;
                    pictureBox_bar.Top = ClientRectangle.Height - pictureBox_bar.Height;
                }
                else
                {
                    button_exit.Visible = true;
                    label_over.Visible = true;
                    pictureBox_ball.Visible = false;
                    pictureBox_bar.Visible = false;
                }

            }

            // the ball miss the bar
            if (pictureBox_ball.Top > ClientRectangle.Height)
            {
                score = score + loosePoint;
                timer1.Enabled = false;
                life = life - 1;
                if (life > 0)
                {
                    LifeLevel();
                    button_start.Visible = true;
                    pictureBox_ball.Left = ClientRectangle.Width / 2 - pictureBox_ball.Width / 2;
                    pictureBox_ball.Top = ClientRectangle.Height / 2 + pictureBox_ball.Height * 4;
                    pictureBox_bar.Left = ClientRectangle.Width / 2 - pictureBox_bar.Width / 2;
                    pictureBox_bar.Top = ClientRectangle.Height - pictureBox_bar.Height;
                }
                else
                {
                    LifeLevel();
                    button_exit.Visible = true;
                    label_over.Visible = true;
                    pictureBox_ball.Visible = false;
                    pictureBox_bar.Visible = false;
                }
            }
            showScore();
        }

        private void timer_countDown_Tick(object sender, EventArgs e)
        {
            timer_countDown.Interval = 1000;
            // show the ball and the bar
            pictureBox_ball.Left = ClientRectangle.Width / 2 - pictureBox_ball.Width / 2;
            pictureBox_ball.Top = ClientRectangle.Height / 2 + pictureBox_ball.Height * 4;
            pictureBox_bar.Left = ClientRectangle.Width / 2 - pictureBox_bar.Width / 2;
            pictureBox_bar.Top = ClientRectangle.Height - pictureBox_bar.Height;
            pictureBox_ball.Visible = true;
            pictureBox_bar.Visible = true;
            //3,2,1
            label_count.Left = ClientRectangle.Width / 2 - label_count.Width / 2;
            label_count.Top = ClientRectangle.Height / 2;
            if (count > 0)
            {
                label_count.Visible = true;
                label_count.Text = count--.ToString();
            }
            else
            {
                label_count.Visible = false;
                // the ball start to move
                timer_countDown.Stop();
                timer1.Enabled = true;
                count = 3;
            }
        }

        // button
        // start
        private void button_start_Click(object sender, EventArgs e)
        {
            timer_countDown.Enabled = true;
            button_start.Visible = false;
            label_instruction.Visible = false;
            if (allGone)
            {
                StartGame();
                allGone = false;
            }
        }
        //exit
        private void button_exit_Click(object sender, EventArgs e)
        {
            if (label_over.Visible)
            {
                this.Close();
            }
        }

        // keyboard function
        // left,right,enter,space,esc
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            int x = pictureBox_bar.Location.X;
            int y = pictureBox_bar.Location.Y;

            //capture left arrow key
            if (keyData == Keys.Left)
            {
                if (pictureBox_bar.Bounds.Left >= 0) x -= 110;
                Point position = new Point(x, y);
                pictureBox_bar.Location = position;
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                if (pictureBox_bar.Bounds.Right <= ClientRectangle.Width) x += 110;
                Point position = new Point(x, y);
                pictureBox_bar.Location = position;
                return true;
            }
            //capture enter key
            if (keyData == Keys.Enter)
            {
                this.button_start.PerformClick();
                return true;
            }
            //capture space key
            if (keyData == Keys.Space)
            {
                if (timer_countDown.Enabled && !timer1.Enabled)
                {
                    timer_countDown.Enabled = !timer_countDown.Enabled;
                    tcd = true;
                }
                else if (!timer_countDown.Enabled && timer1.Enabled)
                {
                    timer1.Enabled = !timer1.Enabled;
                    t1 = true;
                }
                else
                {
                    if (tcd)
                    {
                        timer_countDown.Enabled = !timer_countDown.Enabled;
                        tcd = !tcd;
                    }
                    if (t1)
                    {
                        timer1.Enabled = !timer1.Enabled;
                        t1 = !t1;
                    }
                }
                return true;
            }
            //capture esc key
            if (keyData == Keys.Escape)
            {
                this.button_exit.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
