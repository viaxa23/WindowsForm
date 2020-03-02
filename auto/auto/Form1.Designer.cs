namespace auto
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
            this.rendszam = new System.Windows.Forms.Label();
            this.marka = new System.Windows.Forms.Label();
            this.tipus = new System.Windows.Forms.Label();
            this.evjarat = new System.Windows.Forms.Label();
            this.uzemanyag = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.felvesz = new System.Windows.Forms.Button();
            this.listaz = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.markaCB = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // rendszam
            // 
            this.rendszam.AutoSize = true;
            this.rendszam.Location = new System.Drawing.Point(37, 27);
            this.rendszam.Name = "rendszam";
            this.rendszam.Size = new System.Drawing.Size(57, 13);
            this.rendszam.TabIndex = 0;
            this.rendszam.Text = "Rendszám";
            // 
            // marka
            // 
            this.marka.AutoSize = true;
            this.marka.Location = new System.Drawing.Point(37, 56);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(37, 13);
            this.marka.TabIndex = 1;
            this.marka.Text = "Márka";
            // 
            // tipus
            // 
            this.tipus.AutoSize = true;
            this.tipus.Location = new System.Drawing.Point(37, 86);
            this.tipus.Name = "tipus";
            this.tipus.Size = new System.Drawing.Size(35, 13);
            this.tipus.TabIndex = 2;
            this.tipus.Text = "Típus";
            // 
            // evjarat
            // 
            this.evjarat.AutoSize = true;
            this.evjarat.Location = new System.Drawing.Point(37, 115);
            this.evjarat.Name = "evjarat";
            this.evjarat.Size = new System.Drawing.Size(40, 13);
            this.evjarat.TabIndex = 3;
            this.evjarat.Text = "Évjárat";
            // 
            // uzemanyag
            // 
            this.uzemanyag.AutoSize = true;
            this.uzemanyag.Location = new System.Drawing.Point(37, 146);
            this.uzemanyag.Name = "uzemanyag";
            this.uzemanyag.Size = new System.Drawing.Size(63, 13);
            this.uzemanyag.TabIndex = 4;
            this.uzemanyag.Text = "Üzemanyag";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(119, 20);
            this.textBox3.TabIndex = 7;
            // 
            // felvesz
            // 
            this.felvesz.Location = new System.Drawing.Point(290, 16);
            this.felvesz.Name = "felvesz";
            this.felvesz.Size = new System.Drawing.Size(75, 23);
            this.felvesz.TabIndex = 10;
            this.felvesz.Text = "Felvesz";
            this.felvesz.UseVisualStyleBackColor = true;
            this.felvesz.Click += new System.EventHandler(this.felvesz_Click);
            // 
            // listaz
            // 
            this.listaz.Location = new System.Drawing.Point(290, 56);
            this.listaz.Name = "listaz";
            this.listaz.Size = new System.Drawing.Size(75, 23);
            this.listaz.TabIndex = 11;
            this.listaz.Text = "Listáz";
            this.listaz.UseVisualStyleBackColor = true;
            this.listaz.Click += new System.EventHandler(this.listaz_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(410, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 264);
            this.listBox1.TabIndex = 12;
            // 
            // markaCB
            // 
            this.markaCB.FormattingEnabled = true;
            this.markaCB.Items.AddRange(new object[] {
            "Ford",
            "Volkswagen",
            "Opel",
            "Renault",
            "Toyota",
            "Suzuki",
            "BMW",
            "Mercedes"});
            this.markaCB.Location = new System.Drawing.Point(129, 56);
            this.markaCB.Name = "markaCB";
            this.markaCB.Size = new System.Drawing.Size(119, 21);
            this.markaCB.TabIndex = 13;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Benzin",
            "Gázolaj"});
            this.comboBox2.Location = new System.Drawing.Point(129, 146);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 21);
            this.comboBox2.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(129, 115);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(119, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            2010,
            0,
            0,
            0});
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(129, 27);
            this.maskedTextBox1.Mask = "AAA-000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(119, 20);
            this.maskedTextBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 474);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.markaCB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listaz);
            this.Controls.Add(this.felvesz);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.uzemanyag);
            this.Controls.Add(this.evjarat);
            this.Controls.Add(this.tipus);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.rendszam);
            this.Name = "Form1";
            this.Text = "Autó";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rendszam;
        private System.Windows.Forms.Label marka;
        private System.Windows.Forms.Label tipus;
        private System.Windows.Forms.Label evjarat;
        private System.Windows.Forms.Label uzemanyag;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button felvesz;
        private System.Windows.Forms.Button listaz;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox markaCB;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

