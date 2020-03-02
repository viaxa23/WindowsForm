using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<auto> lista = new List<auto>(); 

        private void felvesz_Click(object sender, EventArgs e)
        {
            string rendszam = maskedTextBox1.Text;
            maskedTextBox1.Clear();
            string marka = markaCB.SelectedItem.ToString();
            string tipus = textBox3.Text;
            textBox3.Text = "";
            int evjarat = (int)numericUpDown1.Value;
            string uzemanyag = comboBox2.SelectedItem.ToString();

            auto Auto = new auto(rendszam, marka, tipus, evjarat, uzemanyag);
            lista.Add(Auto);
        }

        private void listaz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in lista)
            {
                listBox1.Items.Add(item.Kiir());
            }
        }
    }
}
