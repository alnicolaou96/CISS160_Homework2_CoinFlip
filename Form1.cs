using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Alexandros Nicolaou
//09-13-20
//592067
//to make a random coinflip generator

namespace Homework2_Coinflip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Heads_Click(object sender, EventArgs e)
        {

        }

        private void Flip_Click(object sender, EventArgs e)
        {
            var random = new Random(); //new instance of random number assigned to a var
            if(random.Next(1, 3)==1)//taking the new instance and making it >=1 and >3
            {
                Heads.Visible = false;// change visibility for heads
                Tails.Visible = true;// change visibility of coin pic for tails
                Outcome.Text = "Tails!";//change text

            }
            else
            {
                Tails.Visible = false;
                Heads.Visible = true;
                Outcome.Text = "Heads!";
            }

        }

        private void Tails_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
