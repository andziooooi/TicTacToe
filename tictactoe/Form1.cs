using System.Drawing.Drawing2D;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private bool guest;
        private int rounds;
        private bool picked = false;
        bool playerturn = true;
        private string username;
        private bool play;
        private bool End = false;
        private bool tie = false;
        public Form1()
        {
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            InitializeComponent();
            guest = startPage.guest;
            username = startPage.username;
            play = startPage.play;
            Paint += new PaintEventHandler(BackgroundGradient);
            panelformposition();
            labelturnchange();
            Load += Form1Load;
            Resize += new EventHandler(Form1_resize);
        }

        private void Form1Load(object sender, EventArgs e)
        {
            if (!play)
            {
                Close();
            }
        }
        private void btngame_Click(object sender, EventArgs e)
        {
            MyButton btn = (MyButton)sender;
            if (btn.chosen == false)
            {
                if (playerturn)
                {
                    btn.Text = "O";
                    btn.chosen = true;
                    picked =true;
                }
                else
                {
                    btn.Text = "X";
                    btn.chosen = true;
                    picked =true;
                }
                if (picked)
                {
                    playerturn = !playerturn;
                    rounds++;
                    check();
                    labelturnchange();
                    picked = false;
                }
                if (!guest && !(End || tie) )
                {
                    labelturnchange();
                    ComputerTurn();
                    check();
                    labelturnchange();
                    picked = false;
                }
            }
        }
        private void check()
        {
            End = false;
            tie = false;
            bool playerwin = false;
            if (rounds == 9)
            {
                tie = true;
            }
            //row
            if ((btngame1.Text == btngame2.Text) && (btngame2.Text == btngame3.Text) && btngame2.chosen)
            {
                End = true;
            }
            else if ((btngame4.Text == btngame5.Text) && (btngame5.Text == btngame6.Text) && btngame5.chosen)
            {
                End = true;
            }
            else if ((btngame7.Text == btngame8.Text) && (btngame8.Text == btngame9.Text) && btngame8.chosen)
            {
                End = true;
            }

            // column
            else if ((btngame1.Text == btngame4.Text) && (btngame4.Text == btngame7.Text) && btngame4.chosen)
            {
                End = true;
            }
            else if ((btngame2.Text == btngame5.Text) && (btngame5.Text == btngame8.Text) && btngame5.chosen)
            {
                End = true;
            }
            else if ((btngame3.Text == btngame6.Text) && (btngame6.Text == btngame9.Text) && btngame6.chosen)
            {
                End = true;
            }

            //cross
            else if ((btngame1.Text == btngame5.Text) && (btngame5.Text == btngame9.Text) && btngame5.chosen)
            {
                End = true;
            }
            else if ((btngame3.Text == btngame5.Text) && (btngame5.Text == btngame7.Text) && btngame5.chosen)
            {
                End = true;
            }

            if (End || tie)
            {
                if (!playerturn)
                {
                    playerwin = true;
                }
                Form2 EndGamePage = new Form2(End, username, playerwin, guest);
                EndGamePage.ShowDialog();
                if (EndGamePage.NewGame)
                {
                    NewGame();
                }
                else if (EndGamePage.lobby)
                {
                    lobby();
                }
                else
                {
                    NewGame();
                }
            }
        }
        public void ComputerTurn()
        {
            if (rounds < 9)
            {
                int rnd = Random();
                MyButton[] tab = { btngame1, btngame2, btngame3, btngame4, btngame5, btngame6, btngame7, btngame8, btngame9 };
                while (tab[rnd].chosen)
                {
                    rnd = Random();
                }
                playerturn = !playerturn;
                tab[rnd].Text = "X";
                tab[rnd].chosen = true;
                rounds++;
                picked = true;
            }
        }
        public int Random()
        {
            Random Rnd = new Random();
            int result  = Rnd.Next(9);
            return result;
        }
        public void NewGame()
        {
            foreach (Control b in panelform.Controls)
            {
                if (b is MyButton)
                {
                    (b as MyButton).chosen = false;
                    (b as MyButton).Text = "";
                }
            }
            rounds = 0;
            picked = false;
            playerturn = true;
        }
        public void lobby()
        {
            foreach (Control b in panelform.Controls)
            {
                if (b is MyButton)
                {
                    (b as MyButton).chosen = false;
                    (b as MyButton).Text = "";
                }
            }
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            guest = startPage.guest;
            username = startPage.username;
            rounds = 0;
            picked = false;
            playerturn = true;
        }
        public void labelturnchange()
        {
            switch (playerturn)
            {
                case true:
                    labelturn.Text = username + " Turn";
                    break;
                case false:
                    if (guest)
                    {
                        labelturn.Text = "Guest Turn";
                    }
                    else
                    {
                        labelturn.Text = "Computer Turn";
                    }
                    break;
            }
        }
        private void Form1_resize(object sender, EventArgs e)
        {
            panelformposition();
        }
        public void panelformposition()
        {
            int centerX = ClientSize.Width / 2;
            int centerY = ClientSize.Height / 2;
            panelform.Left = centerX - panelform.Width / 2;
            panelform.Top = centerY - panelform.Width/2;
        }
        private void BackgroundGradient(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle rectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(rectangle, Color.FromArgb(173, 216, 230), Color.FromArgb(135, 206, 250), 65f);
            graphics.FillRectangle(b, rectangle);
        }
    }
}
