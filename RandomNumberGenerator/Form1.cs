using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int GenerateRandomDigits()
        {
            Random random = new Random();
            int random_digits = random.Next(1000, 10000);
            return random_digits;
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            int result = GenerateRandomDigits();
            RandomTxtBox.Text = result.ToString();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RandomTxtBox.Text = "";
        }
    }
}
