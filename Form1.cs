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
        public int speed_left = 4;
        public int speed_top = 4;
        public int point = 0;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;  // full screen

            racket.Top = playground.Bottom - (playground.Bottom / 10);

            label2.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);

            ball.Left += speed_left;
            ball.Top += speed_top;

            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                point += 1;
                label1.Text = "Score:" + point.ToString();

                Random rand = new Random();
                playground.BackColor = Color.FromArgb(rand.Next(150, 255), rand.Next(150, 255), rand.Next(150, 255));

            }
            if(ball.Left <= playground.Left)
            {
                speed_left = -speed_left;
            }
            if(ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }
            if(ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if(ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                label2.Visible = true;
                label1.Visible = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Q)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.F)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                point = 0;
                timer1.Enabled = true;
                label2.Visible = false;
                label1.Visible = true;
            }
            if(e.KeyCode == Keys.S)
            {
                MessageBox.Show("Your score:" + point.ToString());
            }
        }
    }
}
