namespace Fakturace
{
    partial class zakaznikForm
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
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Jmeno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ICO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.pridatTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hledat = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Jmeno
            // 
            this.Jmeno.Text = "Jméno";
            // 
            // ICO
            // 
            this.ICO.Text = "IČO";
            // 
            // Email
            // 
            this.Email.Text = "Email";
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Jmeno,
            this.ICO,
            this.Email,
            this.Telefon});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 423);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // pridatTSM
            // 
            this.pridatTSM.BackColor = System.Drawing.Color.Lime;
            this.pridatTSM.Name = "pridatTSM";
            this.pridatTSM.Size = new System.Drawing.Size(50, 23);
            this.pridatTSM.Text = "Přidat";
            // 
            // upravitTSM
            // 
            this.upravitTSM.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.upravitTSM.Name = "upravitTSM";
            this.upravitTSM.Size = new System.Drawing.Size(57, 23);
            this.upravitTSM.Text = "Upravit";
            // 
            // smazatTSM
            // 
            this.smazatTSM.BackColor = System.Drawing.Color.Purple;
            this.smazatTSM.Name = "smazatTSM";
            this.smazatTSM.Size = new System.Drawing.Size(57, 23);
            this.smazatTSM.Text = "Smazat";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pridatTSM,
            this.upravitTSM,
            this.smazatTSM,
            this.hledat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 27);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hledat
            // 
            this.hledat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hledat.Name = "hledat";
            this.hledat.Size = new System.Drawing.Size(100, 23);
            // 
            // zakaznikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listView1);
            this.Name = "zakaznikForm";
            this.Text = "Zákazníci form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Jmeno;
        private System.Windows.Forms.ColumnHeader ICO;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem pridatTSM;
        private System.Windows.Forms.ToolStripMenuItem upravitTSM;
        private System.Windows.Forms.ToolStripMenuItem smazatTSM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripTextBox hledat;
    }
}