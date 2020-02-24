namespace Hoppgomb
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
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Ugras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(3, 15);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(14, 13);
            this.x.TabIndex = 0;
            this.x.Text = "X";
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(3, 52);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(14, 13);
            this.y.TabIndex = 1;
            this.y.Text = "Y";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amegadottkoordinátáranemtudokelugrani";
            // 
            // Ugras
            // 
            this.Ugras.Location = new System.Drawing.Point(44, 93);
            this.Ugras.Name = "Ugras";
            this.Ugras.Size = new System.Drawing.Size(75, 23);
            this.Ugras.TabIndex = 5;
            this.Ugras.Text = "Ugrás";
            this.Ugras.UseVisualStyleBackColor = true;
            this.Ugras.Click += new System.EventHandler(this.Ugras_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 265);
            this.Controls.Add(this.Ugras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.y);
            this.Controls.Add(this.x);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Ugras;
    }
}

