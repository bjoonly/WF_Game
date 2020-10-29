using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numLow = 1, numUp = 101, current = rand.Next(numLow, numUp);
            int count = 0;
            DialogResult choose = DialogResult.Yes;
            do
            {
                count++;
                var res = MessageBox.Show($"{+current}\nIs this your number?", "Game", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    var choose1 = MessageBox.Show("Is your number bigger?", "Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choose1 == DialogResult.Yes)
                    {
                        numLow = current + 1;
                    }
                    else
                    {
                        numUp = current;
                    }
                    current = rand.Next(numLow, numUp);

                }

                else if (res == DialogResult.Yes)
                {
                    choose = MessageBox.Show("Count: " + count + "\nPlay again?", "Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    count = 0;
                    if (choose == DialogResult.No)
                    {
                        MessageBox.Show("Bye", "Game", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    Close();
                }
            } while (choose != DialogResult.No);
        }
    }
}
