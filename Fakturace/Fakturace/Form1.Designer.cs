namespace Fakturace
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
            this.btnZakaznici = new System.Windows.Forms.Button();
            this.btnZbozi = new System.Windows.Forms.Button();
            this.btnFaktura = new System.Windows.Forms.Button();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZakaznici
            // 
            this.btnZakaznici.Location = new System.Drawing.Point(12, 38);
            this.btnZakaznici.Name = "btnZakaznici";
            this.btnZakaznici.Size = new System.Drawing.Size(215, 122);
            this.btnZakaznici.TabIndex = 0;
            this.btnZakaznici.Text = "Zákazníci";
            this.btnZakaznici.UseVisualStyleBackColor = true;
            this.btnZakaznici.Click += new System.EventHandler(this.btnZakaznici_Click);
            // 
            // btnZbozi
            // 
            this.btnZbozi.Location = new System.Drawing.Point(233, 38);
            this.btnZbozi.Name = "btnZbozi";
            this.btnZbozi.Size = new System.Drawing.Size(215, 122);
            this.btnZbozi.TabIndex = 1;
            this.btnZbozi.Text = "Zboží";
            this.btnZbozi.UseVisualStyleBackColor = true;
            this.btnZbozi.Click += new System.EventHandler(this.btnZbozi_Click);
            // 
            // btnFaktura
            // 
            this.btnFaktura.Location = new System.Drawing.Point(454, 38);
            this.btnFaktura.Name = "btnFaktura";
            this.btnFaktura.Size = new System.Drawing.Size(215, 122);
            this.btnFaktura.TabIndex = 2;
            this.btnFaktura.Text = "Fakturace";
            this.btnFaktura.UseVisualStyleBackColor = true;
            this.btnFaktura.Click += new System.EventHandler(this.btnFaktura_Click);
            // 
            // btnStatistika
            // 
            this.btnStatistika.Location = new System.Drawing.Point(675, 38);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(215, 122);
            this.btnStatistika.TabIndex = 3;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = true;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 185);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.btnFaktura);
            this.Controls.Add(this.btnZbozi);
            this.Controls.Add(this.btnZakaznici);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZakaznici;
        private System.Windows.Forms.Button btnZbozi;
        private System.Windows.Forms.Button btnFaktura;
        private System.Windows.Forms.Button btnStatistika;
    }
}

