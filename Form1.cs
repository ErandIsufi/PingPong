using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PINGPONG
{
    public partial class Form1 : Form
    {
        private int ballSpeedX = 7; // Sa shpejt esht topi nalt kur shkon
        private int ballSpeedY = 7; // Topi Sa shpejt esht posht kur shkon
        private Timer Pimer;
        private bool isMovingUp = false;
        private bool isMovingDown = false;
        private Timer movementTimerr;

        private Timer aiMovementTimer;
        private int aiSpeed = 6;


        private int player1Score = 0;
        private int player2Score = 0;
        public Form1()
        {
            InitializeComponent();
            MakePanelCircular();
            InitializeTimer();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;


            movementTimer = new Timer();
            movementTimer.Interval = 10; 
            movementTimer.Tick += MovementTimer_Tick;
            movementTimer.Start();

            //Kjo esht per kompjuterin
            aiMovementTimer = new Timer();
            aiMovementTimer.Interval = 10; 
            aiMovementTimer.Tick += AIMovementTimer_Tick;
            aiMovementTimer.Start();

            lblPlayer1Score.Text = "0";
            lblPlayer2Score.Text = "0";

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                isMovingUp = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                isMovingDown = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                isMovingUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                isMovingDown = false;
            }
        }
        private void MovementTimer_Tick(object sender, EventArgs e)
        {
            int step = 5; 

            if (isMovingUp && Player1.Top > 0)
            {
                Player1.Top -= step;
            }

            if (isMovingDown && Player1.Bottom < this.ClientSize.Height)
            {
                Player1.Top += step;
            }
        }

        private void AIMovementTimer_Tick(object sender, EventArgs e)
        {
            // Qe me livrit kompjuteri veq kur esht topi ngat komputerit
            if (Player2.Top < Ball.Top - 50 || Player2.Bottom > Ball.Bottom + 50)
            {
                if (Ball.Top + Ball.Height / 2 < Player2.Top + Player2.Height / 2)
                {
                    // Me livrit nalt nese o ti shku topi nalt
                    if (Player2.Top > 0)
                    {
                        Player2.Top -= aiSpeed;
                    }
                }
                else if (Ball.Top + Ball.Height / 2 > Player2.Top + Player2.Height / 2)
                {
                    // me livrit posht nese o ti shku topi posht
                    if (Player2.Bottom < this.ClientSize.Height)
                    {
                        Player2.Top += aiSpeed;
                    }
                }
            }
        }

        private void MakePanelCircular()
        {
            
            if (Ball.Width == Ball.Height)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, Ball.Width, Ball.Height);
                Ball.Region = new Region(path);
            }
            else
            {
                MessageBox.Show("Make sure the Ball panel's width and height are equal!");
            }
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 10; // 10 milliseconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            //Topi me livirt
            Ball.Left += ballSpeedX;
            Ball.Top += ballSpeedY;

            // Kur ti rrok muret
            if (Ball.Top <= 0 || Ball.Bottom >= this.ClientSize.Height)
            {
                ballSpeedY = -ballSpeedY; 
            }

            // Kur te kalon topi murin e majt ose te djath per me i shtu pikt edhe me resetu lojen
            if (Ball.Left <= 0)
            {
                player2Score++; // Kur te jep aj muti
                UpdateScoreDisplay();
                ResetBall();
            }
            else if (Ball.Right >= this.ClientSize.Width)
            {
                player1Score++; // Kur te jepsh ti goll
                UpdateScoreDisplay();
                ResetBall();
            }

            // Kodi per me dedektu kur rroket topi me lojtar
            if (Ball.Bounds.IntersectsWith(Player1.Bounds) || Ball.Bounds.IntersectsWith(Player2.Bounds))
            {
                ballSpeedX = -ballSpeedX; // qe  me ja ndrru drejtimin topti
            }
        }

        private void UpdateScoreDisplay()
        {
            lblPlayer2Score.Text =  player1Score.ToString();
            lblPlayer1Score.Text =  player2Score.ToString();
        }
        private void ResetBall()
        {
            // qe me qit topin ne qender apet
            Ball.Left = this.ClientSize.Width / 2 - Ball.Width / 2;
            Ball.Top = this.ClientSize.Height / 2 - Ball.Height / 2;

            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
