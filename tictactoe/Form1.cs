namespace tictactoe
{
    public partial class Form1 : Form
    {
        private bool guest;
        private int rounds;
        private bool picked = false;
        bool playerturn = true;
        public Form1()
        {
            StartPage startPage = new StartPage();
            startPage.ShowDialog();
            InitializeComponent();
            guest = startPage.guest;
        }
       

        private void btngame_Click(object sender, EventArgs e)
        {
            MyButton btn = (MyButton)sender;
            if (playerturn)
            {
                if(btn.chosen == false)
                {
                    btn.Text = "O";
                    btn.chosen = true;
                    picked =true;
                }
                
            }
            else
            {
                if (btn.chosen == false)
                {
                    btn.Text = "X";
                    btn.chosen = true;
                    picked =true;
                }
                
            }
            if (picked)
            {
                playerturn = !playerturn;
                rounds++;
                check();
                picked = false;
            }
            
        }
        private void check()
        {
            bool End = false;
            if (rounds ==9)
            {
                End = true;
            }
            else
            {
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
            }//if check end
            if (End)
            {
                if(rounds ==9)
                {
                    

                }
                else
                {

                }
            }
           
        }
    }
}
