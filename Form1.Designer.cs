namespace PINGPONG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Player1 = new System.Windows.Forms.GroupBox();
            this.Player2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Ball = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.movementTimer = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer2Score = new System.Windows.Forms.Label();
            this.lblPlayer1Score = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Player1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Player1.Location = new System.Drawing.Point(767, 116);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(21, 94);
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            this.Player1.Text = "groupBox1";
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Player2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Player2.Location = new System.Drawing.Point(12, 116);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(21, 94);
            this.Player2.TabIndex = 1;
            this.Player2.TabStop = false;
            this.Player2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(399, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(2, 378);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ball.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Ball.Location = new System.Drawing.Point(391, 157);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 20);
            this.Ball.TabIndex = 4;
            // 
            // lblPlayer2Score
            // 
            this.lblPlayer2Score.AutoSize = true;
            this.lblPlayer2Score.Font = new System.Drawing.Font("Proxy 6", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer2Score.Location = new System.Drawing.Point(300, 276);
            this.lblPlayer2Score.Name = "lblPlayer2Score";
            this.lblPlayer2Score.Size = new System.Drawing.Size(72, 78);
            this.lblPlayer2Score.TabIndex = 5;
            this.lblPlayer2Score.Text = "0";
            // 
            // lblPlayer1Score
            // 
            this.lblPlayer1Score.AutoSize = true;
            this.lblPlayer1Score.Font = new System.Drawing.Font("Proxy 5", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1Score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer1Score.Location = new System.Drawing.Point(429, 276);
            this.lblPlayer1Score.Name = "lblPlayer1Score";
            this.lblPlayer1Score.Size = new System.Drawing.Size(72, 78);
            this.lblPlayer1Score.TabIndex = 6;
            this.lblPlayer1Score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 365);
            this.Controls.Add(this.lblPlayer1Score);
            this.Controls.Add(this.lblPlayer2Score);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Player1;
        private System.Windows.Forms.GroupBox Player2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel Ball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer movementTimer;
        private System.Windows.Forms.Label lblPlayer2Score;
        private System.Windows.Forms.Label lblPlayer1Score;
    }
}

