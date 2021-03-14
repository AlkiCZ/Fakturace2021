namespace Fakturace
{
    partial class zboziForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pridatTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.upravitTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.smazatTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nazev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Skladem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hledat = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Nazev,
            this.Cena,
            this.Skladem});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 426);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pridatTSM,
            this.upravitTSM,
            this.smazatTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";

            this.hledat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.hledat.Name = "hledat";
            this.hledat.Size = new System.Drawing.Size(100, 23);
            // 
            // pridatTSM
            // 
            this.pridatTSM.BackColor = System.Drawing.Color.Lime;
            this.pridatTSM.Name = "pridatTSM";
            this.pridatTSM.Size = new System.Drawing.Size(50, 20);
            this.pridatTSM.Text = "Přidat";
            // 
            // upravitTSM
            // 
            this.upravitTSM.BackColor = System.Drawing.Color.Blue;
            this.upravitTSM.Name = "upravitTSM";
            this.upravitTSM.Size = new System.Drawing.Size(57, 20);
            this.upravitTSM.Text = "Upravit";
            // 
            // smazatTSM
            // 
            this.smazatTSM.BackColor = System.Drawing.Color.Purple;
            this.smazatTSM.Name = "smazatTSM";
            this.smazatTSM.Size = new System.Drawing.Size(57, 20);
            this.smazatTSM.Text = "Smazat";
            // 
            // Id
            // 
            this.Id.Text = "Id";
            // 
            // Nazev
            // 
            this.Nazev.Text = "Nazev";
            // 
            // Cena
            // 
            this.Cena.Text = "Cena";
            // 
            // Skladem
            // 
            this.Skladem.Text = "Skladem";
            // 
            // zboziForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "zboziForm";
            this.Text = "Zbozi form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pridatTSM;
        private System.Windows.Forms.ToolStripMenuItem upravitTSM;
        private System.Windows.Forms.ToolStripMenuItem smazatTSM;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Nazev;
        private System.Windows.Forms.ColumnHeader Cena;
    private System.Windows.Forms.ColumnHeader Skladem;
    private System.Windows.Forms.ToolStripTextBox hledat;
}
}