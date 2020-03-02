using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace marc3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void felvesz_Click(object sender, EventArgs e)
        {
            if (szovegTxt.Text != "" && evText.Text != "")
            {
                string bevitel = $"{szovegTxt.Text} ({evText.Text})";
                topmoziLB.Items.Add(bevitel);
                elemszamNUD.Maximum = topmoziLB.Items.Count;
            }
            else if(szovegTxt.Text == "" && evText.Text == "")
            {
                MessageBox.Show("Valamelyik beviteli mező üres!", "Beviteli mező üres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (szovegTxt.Text == "" && evText.Text != "")
            {
                MessageBox.Show("Szövegbeviteli mező üres!", "Beviteli mező üres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (szovegTxt.Text != "" && evText.Text == "")
            {
                MessageBox.Show("Év beviteli mező üres!", "Beviteli mező üres!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void beszur_Click(object sender, EventArgs e)
        {
            if (szovegTxt.Text != "" && evText.Text != "")
            {
                string bevitel = $"{szovegTxt.Text} ({evText.Text})";
                topmoziLB.Items.Insert((int)elemszamNUD.Value - 1, bevitel);
                elemszamNUD.Maximum = topmoziLB.Items.Count;
                szovegTxt.Text = "";
                evText.Text = "";
            }
        }

        private void torol_Click(object sender, EventArgs e)
        {
            if (topmoziLB.SelectedIndex != -1)
            {
                topmoziLB.Items.RemoveAt(topmoziLB.SelectedIndex);
                elemszamNUD.Maximum = topmoziLB.Items.Count; 
            }
            else
            {
                MessageBox.Show("NINCS kijelölt elem!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Atmasol_Click(object sender, EventArgs e)
        {
            if (topmoziLB.SelectedIndex != -1)
            {
                if (moziLatottLB.Items.Contains(topmoziLB.SelectedItem))
                {
                    MessageBox.Show("NINCS kijelölt elem!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                moziLatottLB.Items.Add(topmoziLB.SelectedItem);
            }
            else
            {
                MessageBox.Show("NINCS kijelölt elem!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Atmozgat_Click(object sender, EventArgs e)
        {
            if (topmoziLB.SelectedIndex != -1)
            {
                moziLatottLB.Items.Add(topmoziLB.SelectedItem);
                topmoziLB.Items.RemoveAt(topmoziLB.SelectedIndex);
                elemszamNUD.Maximum = topmoziLB.Items.Count;
            }
            else
            {
                MessageBox.Show("NINCS kijelölt elem!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void keress_Click(object sender, EventArgs e)
        {
            if (szovegTxt.Text != "")
            {
                int index = topmoziLB.FindString(szovegTxt.Text);
                if (index != -1)
                {
                    topmoziLB.SetSelected(index, true);
                }
            }
        }
    }
}
