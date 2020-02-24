﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace febr18dolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MuveletGomb_Click(object sender, EventArgs e)
        {
            int eleje = Int32.Parse(textBox2.Text);
            int vege = Int32.Parse(textBox3.Text);
            string bemeno = textBox1.Text;

            if (eleje < 0 || eleje > bemeno.Length)
            {
                textBox4.Text = "Nincs ilyen karakterhely";
            }
            else
            {
                char[] tomb = bemeno.ToCharArray();
                tomb[eleje - 1] = (char)((int)tomb[eleje - 1] - 32);
                string kimeno = new string(tomb);
                textBox4.Text = kimeno;
            }
            bool kizar = (eleje < 0 || vege < 0) || 
                (eleje > bemeno.Length || vege > bemeno.Length) ||
                (vege < eleje);

            if (kizar)
            {
                textBox5.Text = "Ezekkel az értékekkel nem tudok dolgozni!";
            }
            else
            {
                /*char[] tomb = bemeno.ToCharArray();
                for (int i = eleje - 1; i < vege; i++)
                {
                    tomb[i] = (char)((int)tomb[i] - 32);
                }
                string kimeno = new string(tomb);
                textBox5.Text = "";*/

                string kimeno = bemeno.Substring(0, eleje - 1) +
                    bemeno.Substring(eleje - 1, vege - eleje + 1).ToUpper() + bemeno.Substring(vege);
                textBox5.Text = kimeno;
            }


        }
    }
}
