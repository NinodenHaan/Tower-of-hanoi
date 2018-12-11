using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toren_van_Hanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int schijven = int.Parse(aantalSchijvenTextBox.Text);
            if (schijven <= 64 && schijven >= 1)
            {
                for (int answer = 1; answer <= schijven; answer++)
                {
                    UInt64 finalanswer = (UInt64)(Math.Pow(2, answer) - 1);
                    MessageBox.Show(finalanswer.ToString());

                }
            }
            else
            {
                MessageBox.Show("getal moet tussen de 1 en 64 liggen!");
            }
        }
    }
}
