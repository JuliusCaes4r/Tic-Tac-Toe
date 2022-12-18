using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {

        bool isWinner = false;
        bool turn = false;
        int turnCounter = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is made by K4Laa");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (turn)
                button.Text = "O";
            else
                button.Text = "X";

            turnCounter++;
            turn = !turn;

            button.Enabled = false;

            CheckWinner();
        }

        private void CheckWinner()
        {
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
                isWinner = true;
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
                isWinner = true;
            else if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
                isWinner = true;

            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
                isWinner = true;
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
                isWinner = true;
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
                isWinner = true;

            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
                isWinner = true;
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
                isWinner = true;

            if (isWinner)
            {
                string winner = "";

                if (turn)
                    winner = "X";
                else
                    winner = "O";

                MessageBox.Show($"Winner is {winner}");
                DisableButtons();
            }

            if(turnCounter == 9 && isWinner == false)
            {
                MessageBox.Show("Draw");
            }
            
        }

        private void DisableButtons()
        {
            foreach(Control control in Controls)
            {
                control.Enabled = false;
            }
        }

        
    }
}
