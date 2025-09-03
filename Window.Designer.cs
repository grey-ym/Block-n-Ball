
namespace Block_n_Ball
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.backgound = new System.Windows.Forms.Panel();
            this.backgroundGameOver = new System.Windows.Forms.PictureBox();
            this.textGameOver = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.PictureBox();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.timerGameOver = new System.Windows.Forms.Timer(this.components);
            this.backgound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // backgound
            // 
            this.backgound.Controls.Add(this.backgroundGameOver);
            this.backgound.Controls.Add(this.textGameOver);
            this.backgound.Controls.Add(this.textScore);
            this.backgound.Controls.Add(this.ball);
            this.backgound.Controls.Add(this.mainPanel);
            this.backgound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgound.Location = new System.Drawing.Point(0, 0);
            this.backgound.Name = "backgound";
            this.backgound.Size = new System.Drawing.Size(1008, 729);
            this.backgound.TabIndex = 0;
            // 
            // backgroundGameOver
            // 
            this.backgroundGameOver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backgroundGameOver.Location = new System.Drawing.Point(52, 226);
            this.backgroundGameOver.Name = "backgroundGameOver";
            this.backgroundGameOver.Size = new System.Drawing.Size(25, 21);
            this.backgroundGameOver.TabIndex = 5;
            this.backgroundGameOver.TabStop = false;
            this.backgroundGameOver.Visible = false;
            // 
            // textGameOver
            // 
            this.textGameOver.AutoSize = true;
            this.textGameOver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.textGameOver.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textGameOver.Location = new System.Drawing.Point(746, 702);
            this.textGameOver.Name = "textGameOver";
            this.textGameOver.Size = new System.Drawing.Size(323, 55);
            this.textGameOver.TabIndex = 4;
            this.textGameOver.Text = "GAME OVER";
            this.textGameOver.Visible = false;
            this.textGameOver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textGameOver_MouseDown);
            // 
            // textScore
            // 
            this.textScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textScore.AutoSize = true;
            this.textScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textScore.Location = new System.Drawing.Point(903, 9);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(93, 26);
            this.textScore.TabIndex = 3;
            this.textScore.Text = "Score: 1";
            // 
            // ball
            // 
            this.ball.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ball.BackColor = System.Drawing.Color.SlateGray;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ball.Location = new System.Drawing.Point(468, 114);
            this.ball.MaximumSize = new System.Drawing.Size(60, 60);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(60, 60);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.MaximumSize = new System.Drawing.Size(180, 30);
            this.mainPanel.MinimumSize = new System.Drawing.Size(180, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(180, 30);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.TabStop = false;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // timerGameOver
            // 
            this.timerGameOver.Interval = 1;
            this.timerGameOver.Tick += new System.EventHandler(this.timerGameOver_Tick);
            // 
            // FormWindow
            // 
            this.AllowDrop = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.backgound);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Ping Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormWindow_KeyDown);
            this.backgound.ResumeLayout(false);
            this.backgound.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundGameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel backgound;
        private System.Windows.Forms.PictureBox mainPanel;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.Label textScore;
        private System.Windows.Forms.Label textGameOver;
        private System.Windows.Forms.PictureBox backgroundGameOver;
        private System.Windows.Forms.Timer timerGameOver;
    }
}

