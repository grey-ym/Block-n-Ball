using System;
using System.Windows.Forms;

namespace Block_n_Ball
{
    public partial class Window : Form
    {
        int speed_horizontal = 4;
        int speed_vertical = 4;
        int score = 0;

        public Window()
        {
            InitializeComponent();
            Cursor.Hide();
            timerGame.Enabled = true;
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            Bounds = Screen.PrimaryScreen.Bounds;
            ball.Top = backgound.Top + backgound.Top + backgound.Bottom / 15;

            textScore.Text = "Score: 0";
            textScore.Left = backgound.Right - textScore.Width - (backgound.Right / 25);
            textScore.Top = backgound.Top + textScore.Height + (textScore.Height / 2);

            mainPanel.Top = backgound.Bottom - (backgound.Bottom / 10);
            backgroundGameOver.Dock = DockStyle.Fill;
        }

        private void FormWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            ball.Top += speed_vertical;
            ball.Left += speed_horizontal;

            mainPanel.Left = Cursor.Position.X - (mainPanel.Width / 2);

            if (ball.Left <= backgound.Left)
                speed_horizontal *= -1;

            if (ball.Right >= backgound.Right)
                speed_horizontal *= -1;

            if (ball.Top <= backgound.Top)
                speed_vertical *= -1;

            if (ball.Bottom >= backgound.Bottom)
            {
                timerGame.Enabled = false;
                textGameOver.Visible = true;
                backgroundGameOver.Visible = true;
                timerGameOver.Enabled = true;
            }

            if (ball.Bottom >= mainPanel.Top && ball.Bottom <= mainPanel.Bottom && ball.Left >= mainPanel.Left && ball.Right <= mainPanel.Right)
            {
                speed_horizontal += 1;
                speed_vertical += 1;
                speed_vertical *= -1;
                score += 1;
                textScore.Text = $"Score: {score}";
            }
        }

        private void timerGameOver_Tick(object sender, EventArgs e)
        {
            textGameOver.Left = Cursor.Position.X - (textGameOver.Width / 2);
            textGameOver.Top = Cursor.Position.Y - (textGameOver.Height / 2);
        }

        private void textGameOver_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ball.Top = 50;
                backgroundGameOver.Visible = false;
                textGameOver.Visible = false;
                textScore.Text = "Score: 0";
                score = 0;
                timerGame.Enabled = true;
                speed_horizontal = 4;
                speed_vertical = 4;
                timerGameOver.Enabled = false;
            }
        }

    }
}
