using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamolasi_alapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Szamolas_Click(object sender, EventArgs e)
        {
            double AoldalHossz = Double.Parse(Aoldal.Text);
            double BoldalHossz = Double.Parse(Boldal.Text);

            double c = Math.Sqrt(Math.Pow(AoldalHossz, 2) + Math.Pow(BoldalHossz, 2));

            double kerulet = AoldalHossz + BoldalHossz + c;
            double terulet = AoldalHossz * BoldalHossz / 2;

            string kiiras = $"C-oldal {c: F2}\nKerület: {kerulet: F2}\nTerület: {terulet: F2}";
            Eredmenyek.Text = kiiras;
        }
    }
}
