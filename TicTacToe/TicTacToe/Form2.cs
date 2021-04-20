using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form2 : Form
    {
        public string winner;
        private Form1 board;
        public Form2(Form1 b)
        {
            InitializeComponent();
            board = b;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void showWinner(object sender, EventArgs e)
        {
            if (sender is Form1)
                board = (Form1)sender;
            label2.Text = "Kokosy zbija:" + winner;
         }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            board.clearBoard();
            this.Close();
        }
    }
}
