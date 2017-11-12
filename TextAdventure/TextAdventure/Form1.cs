using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAdventure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoice1_Click(object sender, EventArgs e)
        {
            Navigation.navigate(lblDisplay, 1);
        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {
            Navigation.navigate(lblDisplay, 2);
        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            Navigation.navigate(lblDisplay, 3);
        }

        private void btnChoice4_Click(object sender, EventArgs e)
        {
            Navigation.navigate(lblDisplay, 4);
        }
    }
}
