namespace szamolasi_alapok
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
            this.Aoldal = new System.Windows.Forms.TextBox();
            this.Boldal = new System.Windows.Forms.TextBox();
            this.Eredmenyek = new System.Windows.Forms.TextBox();
            this.Szamolas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Aoldal
            // 
            this.Aoldal.Location = new System.Drawing.Point(100, 27);
            this.Aoldal.Name = "Aoldal";
            this.Aoldal.Size = new System.Drawing.Size(100, 20);
            this.Aoldal.TabIndex = 0;
            // 
            // Boldal
            // 
            this.Boldal.Location = new System.Drawing.Point(100, 65);
            this.Boldal.Name = "Boldal";
            this.Boldal.Size = new System.Drawing.Size(100, 20);
            this.Boldal.TabIndex = 1;
            // 
            // Eredmenyek
            // 
            this.Eredmenyek.Location = new System.Drawing.Point(100, 111);
            this.Eredmenyek.Multiline = true;
            this.Eredmenyek.Name = "Eredmenyek";
            this.Eredmenyek.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Eredmenyek.Size = new System.Drawing.Size(175, 27);
            this.Eredmenyek.TabIndex = 2;
            // 
            // Szamolas
            // 
            this.Szamolas.BackColor = System.Drawing.Color.Black;
            this.Szamolas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Szamolas.ForeColor = System.Drawing.Color.Red;
            this.Szamolas.Location = new System.Drawing.Point(251, 44);
            this.Szamolas.Name = "Szamolas";
            this.Szamolas.Size = new System.Drawing.Size(75, 23);
            this.Szamolas.TabIndex = 3;
            this.Szamolas.Text = "Számolás";
            this.Szamolas.UseVisualStyleBackColor = false;
            this.Szamolas.Click += new System.EventHandler(this.Szamolas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "A oldal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "B oldal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Eredmények";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(377, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Szamolas);
            this.Controls.Add(this.Eredmenyek);
            this.Controls.Add(this.Boldal);
            this.Controls.Add(this.Aoldal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Aoldal;
        private System.Windows.Forms.TextBox Boldal;
        private System.Windows.Forms.TextBox Eredmenyek;
        private System.Windows.Forms.Button Szamolas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

