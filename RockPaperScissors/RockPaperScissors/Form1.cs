using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        int wins = 0;
        int losses = 0;
        int ties = 0;
        int randomRPS;
        public Form1()
        {
            InitializeComponent();
        }

        public void passtheRPS()
        {
            Random rnd = new Random();
            randomRPS = rnd.Next(1, 4);
            txtWins.Text = "Wins: " + wins;
            txtTies.Text = "Ties: " + ties;
            txtLosses.Text = "Losses: " + losses;
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            passtheRPS();
            if (randomRPS == 1)
            {
                txtDecision.Text = "It was a tie! Maybe a rematch is in order...";
                ties++;
            }
            else if (randomRPS == 2)
            {
                txtDecision.Text = "You lose! Maybe you will be victorious next time...";
                losses++;
            }
            else if(randomRPS == 3) 
            {
                txtDecision.Text = "You win! I want that salty playback.";
                wins++;
            }
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            passtheRPS();
            if (randomRPS == 1)
            {
                txtDecision.Text = "You win! I want that salty playback.";
                wins++;
            }
            else if (randomRPS == 2)
            {
                txtDecision.Text = "It was a tie! Maybe a rematch is in order...";
                ties++;
            }
            else if (randomRPS == 3)
            {
                txtDecision.Text = "You lose! Maybe you will be victorious next time...";
                losses++;
            }
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            passtheRPS();
            if (randomRPS == 1)
            {
                txtDecision.Text = "You lose! Maybe you will be victorious next time...";
                losses++;
            }
            else if (randomRPS == 2)
            {
                txtDecision.Text = "You win! I want that salty playback.";
                wins++;
            }
            else if (randomRPS == 3)
            {
                txtDecision.Text = "It was a tie! Maybe a rematch is in order...";
                ties++;
            }
        }
    }
}
