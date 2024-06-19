using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
