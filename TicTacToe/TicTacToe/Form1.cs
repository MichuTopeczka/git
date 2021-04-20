using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }
    public partial class Form1 : Form
    {
        CurrentPlayer currentPlayer;
        public Form1()
        {
            InitializeComponent();
            currentPlayer = CurrentPlayer.Cross;
            changeLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mark(object sender, EventArgs e)
        {
            Button SenderButton = (Button)sender;
            if (currentPlayer == CurrentPlayer.Cross)
            {
                SenderButton.Text = "X";
                currentPlayer = CurrentPlayer.Circle;

            }
            else
            {
                SenderButton.Text = "O";
                currentPlayer = CurrentPlayer.Cross;
            }
            checkWinner();
            changeLabel();

          
        }
        public void changeLabel()
        {
            if(currentPlayer == CurrentPlayer.Cross)
            {
                currentPlayerLabel.Text = "Krzyzyk";
            }
            else
            {
                currentPlayerLabel.Text = "Kolko";
            }
        }
        public void checkWinner()
        {
            if (String.Compare(tl.Text, cl.Text) == 0 && String.Compare(cl.Text, bl.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            if (String.Compare(cl.Text, cc.Text) == 0 && String.Compare(cc.Text, cr.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = cl.Text;
                victoryScreen.Show();
            }
            if (String.Compare(bl.Text, bc.Text) == 0 && String.Compare(bc.Text, br.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = bl.Text;
                victoryScreen.Show();
            }
            if (String.Compare(tl.Text, tc.Text) == 0 && String.Compare(tc.Text, tr.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            if (String.Compare(tc.Text, cc.Text) == 0 && String.Compare(cc.Text, bc.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tc.Text;
                victoryScreen.Show();
            }
            if (String.Compare(tr.Text, cr.Text) == 0 && String.Compare(cr.Text, br.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();
            }
            if (String.Compare(tl.Text, cc.Text) == 0 && String.Compare(cc.Text, br.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            if (String.Compare(tr.Text, cc.Text) == 0 && String.Compare(cc.Text, bl.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();
            }
        }

        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for (int i = 0; i < buttons.Count; i++) 
            {
                if (buttons[i] is Button)
                    buttons [i].Text = "";
            }

            currentPlayer = CurrentPlayer.Cross;
        }
    }
}
