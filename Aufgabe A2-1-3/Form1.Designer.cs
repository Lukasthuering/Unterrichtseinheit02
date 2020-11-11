namespace Aufgabe_A2_1_3
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNumberone = new System.Windows.Forms.Label();
            this.LblNumbertwo = new System.Windows.Forms.Label();
            this.TxtNumberone = new System.Windows.Forms.TextBox();
            this.TxtNumbertwo = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNumberone
            // 
            this.LblNumberone.AutoSize = true;
            this.LblNumberone.Location = new System.Drawing.Point(12, 41);
            this.LblNumberone.Name = "LblNumberone";
            this.LblNumberone.Size = new System.Drawing.Size(40, 13);
            this.LblNumberone.TabIndex = 0;
            this.LblNumberone.Text = "Zahl 1:";
            // 
            // LblNumbertwo
            // 
            this.LblNumbertwo.AutoSize = true;
            this.LblNumbertwo.Location = new System.Drawing.Point(15, 80);
            this.LblNumbertwo.Name = "LblNumbertwo";
            this.LblNumbertwo.Size = new System.Drawing.Size(40, 13);
            this.LblNumbertwo.TabIndex = 1;
            this.LblNumbertwo.Text = "Zahl 2:";
            // 
            // TxtNumberone
            // 
            this.TxtNumberone.Location = new System.Drawing.Point(58, 38);
            this.TxtNumberone.Name = "TxtNumberone";
            this.TxtNumberone.Size = new System.Drawing.Size(181, 20);
            this.TxtNumberone.TabIndex = 2;
            // 
            // TxtNumbertwo
            // 
            this.TxtNumbertwo.Location = new System.Drawing.Point(58, 73);
            this.TxtNumbertwo.Name = "TxtNumbertwo";
            this.TxtNumbertwo.Size = new System.Drawing.Size(181, 20);
            this.TxtNumbertwo.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(13, 157);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(52, 47);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(71, 157);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(52, 47);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.Location = new System.Drawing.Point(129, 157);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(52, 47);
            this.btnmultiply.TabIndex = 6;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = true;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(187, 157);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(52, 47);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(18, 118);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(49, 13);
            this.lblResultat.TabIndex = 8;
            this.lblResultat.Text = "Resultat:";
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(74, 118);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(165, 20);
            this.txtResultat.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.TxtNumbertwo);
            this.Controls.Add(this.TxtNumberone);
            this.Controls.Add(this.LblNumbertwo);
            this.Controls.Add(this.LblNumberone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNumberone;
        private System.Windows.Forms.Label LblNumbertwo;
        private System.Windows.Forms.TextBox TxtNumberone;
        private System.Windows.Forms.TextBox TxtNumbertwo;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnmultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.TextBox txtResultat;
    }
}

