using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_08_RandomNumber
{
    public partial class Form1 : Form
    {
        private int numberToGuess;
        private int numberEntered;
        
        private void Setup()
        {
            panelSetup.Visible = true;
            panelGuess.Visible = false;
        }

        private void Guess()
        {
            panelSetup.Visible = false;
            panelGuess.Visible = true;
        }

        private void Check()
        {
            if (numberEntered == numberToGuess)
            {
                MessageBox.Show("Bingo!");
            }
            else
            {
                MessageBox.Show(numberEntered > numberToGuess ? "Too high!" : "Too low!");
            }
        }
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void buttonSubmitGuess_Click(object sender, EventArgs e)
        {
            numberEntered = int.Parse(textBoxGuess.Text);
            Check();
        }

        private void buttonSetupDone_Click(object sender, EventArgs e)
        {
            numberToGuess = int.Parse(textBoxNumberToGuess.Text);
            Guess();
        }
    }
}