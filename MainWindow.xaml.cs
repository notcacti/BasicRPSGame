using System;
using System.Windows;

namespace wpf_rps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string btnCheck = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rbtn_Click(object sender, EventArgs e)
        {
            btnCheck = "r";
            Intelligence();
        }

        private void pbtn_Click(object sender, EventArgs e)
        {
            btnCheck = "p";
            Intelligence();
        }

        private void scbtn_Click(object sender, EventArgs e)
        {
            btnCheck = "s";
            Intelligence();
        }

        private string Intelligence()
        {
            // Define array
            string[] rps = { "Rock", "Paper", "Scissors", "easter egg?!" };

            //Chooses Option
            Random aiSys = new Random();
            int n = aiSys.Next(0, 3);
            string optai = rps[n];
            string aiOpt = "";

            switch (optai)
            {
                case "Rock":
                    aiOpt = "r";
                    break;
                case "Paper":
                    aiOpt = "p";
                    break;
                case "Scissors":
                    aiOpt = "s";
                    break;
            }

            WinCheck(optai, aiOpt, btnCheck);
            return aiOpt;
            return optai;
        }

        private void WinCheck(string optai, string aiOpt, string btnCheck)
        {
            //variables
            bool tie = true;
            bool urvs = false;
            bool usvp = false;
            bool upvr = false;
            bool arvs = false;
            bool asvp = false;
            bool apvr = false;

            switch (btnCheck)
            {
                case "r" when aiOpt == "s":
                    urvs = true;
                    tie = false;
                    break;
                case "s" when aiOpt == "p":
                    usvp = true;
                    tie = false;
                    break;
                case "p" when aiOpt == "r":
                    upvr = true;
                    tie = false;
                    break;
            }

            switch (aiOpt)
            {
                case "r" when btnCheck == "s":
                    arvs = true;
                    tie = false;
                    break;
                case "s" when btnCheck == "p":
                    asvp = true;
                    tie = false;
                    break;
                case "p" when btnCheck == "r":
                    apvr = true;
                    tie = false;
                    break;
            }    

            //win logic
            if (urvs || usvp || upvr) //human wins
            {
                MessageBox.Show("The AI chose " + optai + "... You Win! AI Loses!", "The Winner is..", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (arvs || asvp || apvr) //ai wins
            {
                MessageBox.Show("The AI chose " + optai + "... The AI Wins! You Lose!", "The Winner is..", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (tie)
            {
                MessageBox.Show("The AI chose " + optai + "... It's a tie!", "The Winner is..", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("what did you do bro", "error");
            }
        }
    }
}
