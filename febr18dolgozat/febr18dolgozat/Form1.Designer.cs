namespace febr18dolgozat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BemenoSzo = new System.Windows.Forms.Label();
            this.Eleje = new System.Windows.Forms.Label();
            this.Vege = new System.Windows.Forms.Label();
            this.Betucsere = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ReszSztring = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.MuveletGomb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BemenoSzo
            // 
            this.BemenoSzo.AutoSize = true;
            this.BemenoSzo.Location = new System.Drawing.Point(42, 42);
            this.BemenoSzo.Name = "BemenoSzo";
            this.BemenoSzo.Size = new System.Drawing.Size(64, 13);
            this.BemenoSzo.TabIndex = 0;
            this.BemenoSzo.Text = "BemenőSzó";
            // 
            // Eleje
            // 
            this.Eleje.AutoSize = true;
            this.Eleje.Location = new System.Drawing.Point(45, 88);
            this.Eleje.Name = "Eleje";
            this.Eleje.Size = new System.Drawing.Size(30, 13);
            this.Eleje.TabIndex = 1;
            this.Eleje.Text = "Eleje";
            // 
            // Vege
            // 
            this.Vege.AutoSize = true;
            this.Vege.Location = new System.Drawing.Point(45, 136);
            this.Vege.Name = "Vege";
            this.Vege.Size = new System.Drawing.Size(32, 13);
            this.Vege.TabIndex = 2;
            this.Vege.Text = "Vége";
            // 
            // Betucsere
            // 
            this.Betucsere.AutoSize = true;
            this.Betucsere.Location = new System.Drawing.Point(45, 191);
            this.Betucsere.Name = "Betucsere";
            this.Betucsere.Size = new System.Drawing.Size(55, 13);
            this.Betucsere.TabIndex = 3;
            this.Betucsere.Text = "Betűcsere";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(127, 136);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // ReszSztring
            // 
            this.ReszSztring.AutoSize = true;
            this.ReszSztring.Location = new System.Drawing.Point(45, 235);
            this.ReszSztring.Name = "ReszSztring";
            this.ReszSztring.Size = new System.Drawing.Size(61, 13);
            this.ReszSztring.TabIndex = 7;
            this.ReszSztring.Text = "Részsztring";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(127, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(127, 235);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(161, 20);
            this.textBox5.TabIndex = 9;
            // 
            // MuveletGomb
            // 
            this.MuveletGomb.Location = new System.Drawing.Point(364, 42);
            this.MuveletGomb.Name = "MuveletGomb";
            this.MuveletGomb.Size = new System.Drawing.Size(75, 20);
            this.MuveletGomb.TabIndex = 10;
            this.MuveletGomb.Text = "Művelet";
            this.MuveletGomb.UseVisualStyleBackColor = true;
            this.MuveletGomb.Click += new System.EventHandler(this.MuveletGomb_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 397);
            this.Controls.Add(this.MuveletGomb);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ReszSztring);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Betucsere);
            this.Controls.Add(this.Vege);
            this.Controls.Add(this.Eleje);
            this.Controls.Add(this.BemenoSzo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BemenoSzo;
        private System.Windows.Forms.Label Eleje;
        private System.Windows.Forms.Label Vege;
        private System.Windows.Forms.Label Betucsere;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label ReszSztring;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button MuveletGomb;
    }
}

