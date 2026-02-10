namespace OMG_AlMesri
{
    partial class View
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
            this.buttonGGTBerechnen = new System.Windows.Forms.Button();
            this.labelZahl1 = new System.Windows.Forms.Label();
            this.labelZahl2 = new System.Windows.Forms.Label();
            this.labelGGT = new System.Windows.Forms.Label();
            this.textBoxZahl1 = new System.Windows.Forms.TextBox();
            this.textBoxZahl2 = new System.Windows.Forms.TextBox();
            this.textBoxGGT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGGTBerechnen
            // 
            this.buttonGGTBerechnen.Location = new System.Drawing.Point(64, 90);
            this.buttonGGTBerechnen.Name = "buttonGGTBerechnen";
            this.buttonGGTBerechnen.Size = new System.Drawing.Size(206, 21);
            this.buttonGGTBerechnen.TabIndex = 1;
            this.buttonGGTBerechnen.Text = "GGTBerechnen";
            this.buttonGGTBerechnen.UseVisualStyleBackColor = true;
            this.buttonGGTBerechnen.Click += new System.EventHandler(this.buttonGGTBerechnen_Click);
            // 
            // labelZahl1
            // 
            this.labelZahl1.AutoSize = true;
            this.labelZahl1.Location = new System.Drawing.Point(12, 15);
            this.labelZahl1.Name = "labelZahl1";
            this.labelZahl1.Size = new System.Drawing.Size(37, 13);
            this.labelZahl1.TabIndex = 2;
            this.labelZahl1.Text = "Zahl 1";
            // 
            // labelZahl2
            // 
            this.labelZahl2.AutoSize = true;
            this.labelZahl2.Location = new System.Drawing.Point(12, 41);
            this.labelZahl2.Name = "labelZahl2";
            this.labelZahl2.Size = new System.Drawing.Size(37, 13);
            this.labelZahl2.TabIndex = 3;
            this.labelZahl2.Text = "Zahl 2";
            // 
            // labelGGT
            // 
            this.labelGGT.AutoSize = true;
            this.labelGGT.Location = new System.Drawing.Point(12, 67);
            this.labelGGT.Name = "labelGGT";
            this.labelGGT.Size = new System.Drawing.Size(30, 13);
            this.labelGGT.TabIndex = 4;
            this.labelGGT.Text = "GGT";
            // 
            // textBoxZahl1
            // 
            this.textBoxZahl1.Location = new System.Drawing.Point(64, 12);
            this.textBoxZahl1.Name = "textBoxZahl1";
            this.textBoxZahl1.Size = new System.Drawing.Size(206, 20);
            this.textBoxZahl1.TabIndex = 5;
            // 
            // textBoxZahl2
            // 
            this.textBoxZahl2.Location = new System.Drawing.Point(64, 38);
            this.textBoxZahl2.Name = "textBoxZahl2";
            this.textBoxZahl2.Size = new System.Drawing.Size(206, 20);
            this.textBoxZahl2.TabIndex = 6;
            // 
            // textBoxGGT
            // 
            this.textBoxGGT.Location = new System.Drawing.Point(64, 64);
            this.textBoxGGT.Name = "textBoxGGT";
            this.textBoxGGT.Size = new System.Drawing.Size(206, 20);
            this.textBoxGGT.TabIndex = 7;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 137);
            this.Controls.Add(this.textBoxGGT);
            this.Controls.Add(this.textBoxZahl2);
            this.Controls.Add(this.textBoxZahl1);
            this.Controls.Add(this.labelGGT);
            this.Controls.Add(this.labelZahl2);
            this.Controls.Add(this.labelZahl1);
            this.Controls.Add(this.buttonGGTBerechnen);
            this.Name = "View";
            this.Text = "OMG_Giamen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGGTBerechnen;
        private System.Windows.Forms.Label labelZahl1;
        private System.Windows.Forms.Label labelZahl2;
        private System.Windows.Forms.Label labelGGT;
        private System.Windows.Forms.TextBox textBoxZahl1;
        private System.Windows.Forms.TextBox textBoxZahl2;
        private System.Windows.Forms.TextBox textBoxGGT;
    }
}

