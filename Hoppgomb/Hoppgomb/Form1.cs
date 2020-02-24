using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoppgomb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ugras_Click(object sender, EventArgs e)
        {
            int elsoKoor = Int32.Parse(textBox1.Text);
            int masodikKoor = Int32.Parse(textBox2.Text);

            if (elsoKoor >= 0 && elsoKoor < this.Size.Width - Ugras.Width -10)
               (masodikKoor >= 0 && masodikKoor < this.Size.Height - Ugras.Width - 10)
            {
                label3.Visible = false;
                Ugras.Location = new Point(elsoKoor, masodikKoor);
            }
            else
	        {
                label3.Visible = true;
            }
        }
    }
}
