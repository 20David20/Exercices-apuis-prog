namespace Arche_de_Noé
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblATerre = new System.Windows.Forms.Label();
            this.ABord = new System.Windows.Forms.Label();
            this.listTerre = new System.Windows.Forms.ListBox();
            this.listBord = new System.Windows.Forms.ListBox();
            this.cmdTerreToBord = new System.Windows.Forms.Button();
            this.cmdBordToTerre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblATerre
            // 
            this.lblATerre.AutoSize = true;
            this.lblATerre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATerre.Location = new System.Drawing.Point(36, 62);
            this.lblATerre.Name = "lblATerre";
            this.lblATerre.Size = new System.Drawing.Size(169, 25);
            this.lblATerre.TabIndex = 0;
            this.lblATerre.Text = "Encore à Terre";
            // 
            // ABord
            // 
            this.ABord.AutoSize = true;
            this.ABord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABord.Location = new System.Drawing.Point(346, 62);
            this.ABord.Name = "ABord";
            this.ABord.Size = new System.Drawing.Size(81, 25);
            this.ABord.TabIndex = 1;
            this.ABord.Text = "À bord";
            // 
            // listTerre
            // 
            this.listTerre.FormattingEnabled = true;
            this.listTerre.Items.AddRange(new object[] {
            "Araignée",
            "Chat",
            "Cheval",
            "Chien",
            "Cobra",
            "Coccinelle",
            "Kangourou",
            "Perroquet",
            "Rat",
            "Ver de terre"});
            this.listTerre.Location = new System.Drawing.Point(41, 108);
            this.listTerre.Name = "listTerre";
            this.listTerre.Size = new System.Drawing.Size(220, 277);
            this.listTerre.TabIndex = 2;
            this.listTerre.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBord
            // 
            this.listBord.FormattingEnabled = true;
            this.listBord.Location = new System.Drawing.Point(351, 108);
            this.listBord.Name = "listBord";
            this.listBord.Size = new System.Drawing.Size(220, 277);
            this.listBord.TabIndex = 3;
            // 
            // cmdTerreToBord
            // 
            this.cmdTerreToBord.Location = new System.Drawing.Point(270, 169);
            this.cmdTerreToBord.Name = "cmdTerreToBord";
            this.cmdTerreToBord.Size = new System.Drawing.Size(75, 23);
            this.cmdTerreToBord.TabIndex = 4;
            this.cmdTerreToBord.Text = "===>";
            this.cmdTerreToBord.UseVisualStyleBackColor = true;
            this.cmdTerreToBord.Click += new System.EventHandler(this.cmdTerreToBord_Click);
            // 
            // cmdBordToTerre
            // 
            this.cmdBordToTerre.Location = new System.Drawing.Point(270, 240);
            this.cmdBordToTerre.Name = "cmdBordToTerre";
            this.cmdBordToTerre.Size = new System.Drawing.Size(75, 23);
            this.cmdBordToTerre.TabIndex = 5;
            this.cmdBordToTerre.Text = "<===";
            this.cmdBordToTerre.UseVisualStyleBackColor = true;
            this.cmdBordToTerre.Click += new System.EventHandler(this.cmdBordToTerre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.cmdBordToTerre);
            this.Controls.Add(this.cmdTerreToBord);
            this.Controls.Add(this.listBord);
            this.Controls.Add(this.listTerre);
            this.Controls.Add(this.ABord);
            this.Controls.Add(this.lblATerre);
            this.Name = "Form1";
            this.Text = "Arche de Noé";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblATerre;
        private System.Windows.Forms.Label ABord;
        private System.Windows.Forms.ListBox listTerre;
        private System.Windows.Forms.ListBox listBord;
        private System.Windows.Forms.Button cmdTerreToBord;
        private System.Windows.Forms.Button cmdBordToTerre;
    }
}

