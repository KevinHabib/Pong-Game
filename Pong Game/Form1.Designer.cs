namespace Pong_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Player = new PictureBox();
            Computer = new PictureBox();
            Ball = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.Image = Properties.Resources.player;
            Player.Location = new Point(12, 141);
            Player.Name = "Player";
            Player.Size = new Size(30, 120);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // Computer
            // 
            Computer.Image = Properties.Resources.computer;
            Computer.Location = new Point(758, 141);
            Computer.Name = "Computer";
            Computer.Size = new Size(30, 120);
            Computer.SizeMode = PictureBoxSizeMode.StretchImage;
            Computer.TabIndex = 2;
            Computer.TabStop = false;
            // 
            // Ball
            // 
            Ball.Image = Properties.Resources.ball;
            Ball.Location = new Point(385, 165);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.SizeMode = PictureBoxSizeMode.StretchImage;
            Ball.TabIndex = 3;
            Ball.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(Ball);
            Controls.Add(Computer);
            Controls.Add(Player);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Player: 0 -- Computer: 0";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Player;
        private PictureBox Computer;
        private PictureBox Ball;
        private System.Windows.Forms.Timer GameTimer;
    }
}
