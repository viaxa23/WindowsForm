using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harmadikwinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValasztoGomb_Click(object sender, EventArgs e)
        {
            string kimeno = "";
            foreach (var item in listBox1.SelectedItems)
            {
                // kimeno += item.ToString() + "\r\n";
                //listBox2.Items.Add(item);
                comboBox1.Items.Add(item);
            }
            textBox1.Text = kimeno;
            int szam = Int32.Parse(textBox2.Text);
            for (int i = szam; i < 0; i--)
            {
                if (szam % i == 0 )
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void HozzaAdGomb_Click(object sender, EventArgs e)
        {
            string hozzaad = textBox2.Text;
            listBox1.Items.Add(hozzaad);
        }
    }
}
