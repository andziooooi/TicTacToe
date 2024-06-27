using System.Drawing.Drawing2D;

namespace tictactoe
{
    public partial class Form2 : Form
    {
        bool winner;
        private string username;
        public bool NewGame;
        public bool lobby;
        private bool playerwin;

        public Form2(bool winner, string username,bool playerwin)
        {
            lobby = false;
            NewGame = false;
            this.winner = winner;
            this.username = username;
            this.playerwin = playerwin;
            InitializeComponent();
            this.Paint += new PaintEventHandler(BackgroundGradient);
            labelwinner_change();
        }

        private void btnnewgame_Click(object sender, EventArgs e)
        {
            NewGame = true;
            Close();
        }

        private void btnlobby(object sender, EventArgs e)
        {
            lobby = true;
            Close();
        }
        private void labelwinner_change()
        {
            if (winner)
            {
                if (playerwin)
                {
                    labelwinner.Text = "Winner:\n" + username;
                }
                else
                {
                    labelwinner.Text = "Winner:\n Guest!";
                }
                
            }
            else
            {
                labelwinner.Text = "We got a tie!";
            }       
        }
        private void BackgroundGradient(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(rectangle, Color.FromArgb(150, 190, 220), Color.FromArgb(100, 170, 210), 65f);
            graphics.FillRectangle(b, rectangle);
        }
        public void labelwinner_Paint(object sender, PaintEventArgs e)
        {
            // Rysowanie obramowania
            ControlPaint.DrawBorder(e.Graphics, labelwinner.ClientRectangle, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid, Color.FromArgb(186, 85, 211), 2, ButtonBorderStyle.Solid);
        }

    }
}
