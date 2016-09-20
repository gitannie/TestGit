namespace TestGit
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
            this.bt_1 = new System.Windows.Forms.Button();
            this.BT_MAJ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_1
            // 
            this.bt_1.Location = new System.Drawing.Point(50, 38);
            this.bt_1.Name = "bt_1";
            this.bt_1.Size = new System.Drawing.Size(119, 53);
            this.bt_1.TabIndex = 0;
            this.bt_1.Text = "1er bouton";
            this.bt_1.UseVisualStyleBackColor = true;
            this.bt_1.Click += new System.EventHandler(this.bt_1_Click);
            // 
            // BT_MAJ
            // 
            this.BT_MAJ.Location = new System.Drawing.Point(64, 140);
            this.BT_MAJ.Name = "BT_MAJ";
            this.BT_MAJ.Size = new System.Drawing.Size(104, 56);
            this.BT_MAJ.TabIndex = 1;
            this.BT_MAJ.Text = "Maj Annie 1";
            this.BT_MAJ.UseVisualStyleBackColor = true;
            this.BT_MAJ.Click += new System.EventHandler(this.BT_MAJ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 262);
            this.Controls.Add(this.BT_MAJ);
            this.Controls.Add(this.bt_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_1;
        private System.Windows.Forms.Button BT_MAJ;
    }
}

