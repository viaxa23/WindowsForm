using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void modositogomb_MouseEnter(object sender, EventArgs e)
        {
            this.Text = "Belépett"; 
        }

        private void modositogomb_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "tajas form";
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Modosito_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BezarGomb_MouseEnter(object sender, EventArgs e)
        {
            int szelesseg = this.Size.Width - BezarGomb.Width - 10;
            int magassag = this.Size.Height - BezarGomb.Height - 10;

            Random rnd = new Random();

            int x = rnd.Next(szelesseg);
            int y = rnd.Next(magassag);
            BezarGomb.Location = new Point(x, y);

        }
    }
}
