namespace marc3
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
            this.szovegTxt = new System.Windows.Forms.TextBox();
            this.felvesz = new System.Windows.Forms.Button();
            this.beszur = new System.Windows.Forms.Button();
            this.torol = new System.Windows.Forms.Button();
            this.torolMind = new System.Windows.Forms.Button();
            this.Atmasol = new System.Windows.Forms.Button();
            this.Atmozgat = new System.Windows.Forms.Button();
            this.keress = new System.Windows.Forms.Button();
            this.topmoziLB = new System.Windows.Forms.ListBox();
            this.moziLatottLB = new System.Windows.Forms.ListBox();
            this.elemszamNUD = new System.Windows.Forms.NumericUpDown();
            this.evText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.elemszamNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // szovegTxt
            // 
            this.szovegTxt.Location = new System.Drawing.Point(48, 33);
            this.szovegTxt.Name = "szovegTxt";
            this.szovegTxt.Size = new System.Drawing.Size(100, 20);
            this.szovegTxt.TabIndex = 0;
            // 
            // felvesz
            // 
            this.felvesz.Location = new System.Drawing.Point(328, 99);
            this.felvesz.Name = "felvesz";
            this.felvesz.Size = new System.Drawing.Size(75, 23);
            this.felvesz.TabIndex = 2;
            this.felvesz.Text = "Felvesz";
            this.felvesz.UseVisualStyleBackColor = true;
            this.felvesz.Click += new System.EventHandler(this.felvesz_Click);
            // 
            // beszur
            // 
            this.beszur.Location = new System.Drawing.Point(328, 139);
            this.beszur.Name = "beszur";
            this.beszur.Size = new System.Drawing.Size(75, 23);
            this.beszur.TabIndex = 3;
            this.beszur.Text = "Beszúr";
            this.beszur.UseVisualStyleBackColor = true;
            this.beszur.Click += new System.EventHandler(this.beszur_Click);
            // 
            // torol
            // 
            this.torol.Location = new System.Drawing.Point(328, 183);
            this.torol.Name = "torol";
            this.torol.Size = new System.Drawing.Size(75, 23);
            this.torol.TabIndex = 4;
            this.torol.Text = "Töröl";
            this.torol.UseVisualStyleBackColor = true;
            this.torol.Click += new System.EventHandler(this.torol_Click);
            // 
            // torolMind
            // 
            this.torolMind.Location = new System.Drawing.Point(328, 229);
            this.torolMind.Name = "torolMind";
            this.torolMind.Size = new System.Drawing.Size(75, 23);
            this.torolMind.TabIndex = 5;
            this.torolMind.Text = "Töröl Mind";
            this.torolMind.UseVisualStyleBackColor = true;
            // 
            // Atmasol
            // 
            this.Atmasol.Location = new System.Drawing.Point(328, 276);
            this.Atmasol.Name = "Atmasol";
            this.Atmasol.Size = new System.Drawing.Size(75, 23);
            this.Atmasol.TabIndex = 6;
            this.Atmasol.Text = "Átmásol";
            this.Atmasol.UseVisualStyleBackColor = true;
            this.Atmasol.Click += new System.EventHandler(this.Atmasol_Click);
            // 
            // Atmozgat
            // 
            this.Atmozgat.Location = new System.Drawing.Point(328, 318);
            this.Atmozgat.Name = "Atmozgat";
            this.Atmozgat.Size = new System.Drawing.Size(75, 23);
            this.Atmozgat.TabIndex = 7;
            this.Atmozgat.Text = "Átmozgat";
            this.Atmozgat.UseVisualStyleBackColor = true;
            this.Atmozgat.Click += new System.EventHandler(this.Atmozgat_Click);
            // 
            // keress
            // 
            this.keress.Location = new System.Drawing.Point(328, 366);
            this.keress.Name = "keress";
            this.keress.Size = new System.Drawing.Size(75, 23);
            this.keress.TabIndex = 8;
            this.keress.Text = "Keress";
            this.keress.UseVisualStyleBackColor = true;
            this.keress.Click += new System.EventHandler(this.keress_Click);
            // 
            // topmoziLB
            // 
            this.topmoziLB.FormattingEnabled = true;
            this.topmoziLB.Location = new System.Drawing.Point(48, 99);
            this.topmoziLB.Name = "topmoziLB";
            this.topmoziLB.Size = new System.Drawing.Size(234, 290);
            this.topmoziLB.TabIndex = 9;
            // 
            // moziLatottLB
            // 
            this.moziLatottLB.FormattingEnabled = true;
            this.moziLatottLB.Location = new System.Drawing.Point(446, 99);
            this.moziLatottLB.Name = "moziLatottLB";
            this.moziLatottLB.Size = new System.Drawing.Size(230, 290);
            this.moziLatottLB.TabIndex = 10;
            // 
            // elemszamNUD
            // 
            this.elemszamNUD.Location = new System.Drawing.Point(422, 33);
            this.elemszamNUD.Name = "elemszamNUD";
            this.elemszamNUD.Size = new System.Drawing.Size(120, 20);
            this.elemszamNUD.TabIndex = 11;
            // 
            // evText
            // 
            this.evText.Location = new System.Drawing.Point(246, 33);
            this.evText.Name = "evText";
            this.evText.Size = new System.Drawing.Size(100, 20);
            this.evText.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 452);
            this.Controls.Add(this.evText);
            this.Controls.Add(this.elemszamNUD);
            this.Controls.Add(this.moziLatottLB);
            this.Controls.Add(this.topmoziLB);
            this.Controls.Add(this.keress);
            this.Controls.Add(this.Atmozgat);
            this.Controls.Add(this.Atmasol);
            this.Controls.Add(this.torolMind);
            this.Controls.Add(this.torol);
            this.Controls.Add(this.beszur);
            this.Controls.Add(this.felvesz);
            this.Controls.Add(this.szovegTxt);
            this.Name = "Form1";
            this.Text = "Film Lista";
            ((System.ComponentModel.ISupportInitialize)(this.elemszamNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox szovegTxt;
        private System.Windows.Forms.Button felvesz;
        private System.Windows.Forms.Button beszur;
        private System.Windows.Forms.Button torol;
        private System.Windows.Forms.Button torolMind;
        private System.Windows.Forms.Button Atmasol;
        private System.Windows.Forms.Button Atmozgat;
        private System.Windows.Forms.Button keress;
        private System.Windows.Forms.ListBox topmoziLB;
        private System.Windows.Forms.ListBox moziLatottLB;
        private System.Windows.Forms.NumericUpDown elemszamNUD;
        private System.Windows.Forms.TextBox evText;
    }
}

