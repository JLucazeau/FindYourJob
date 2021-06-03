
namespace FindYourJob
{
    partial class FormConnexion
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
            this.textBoxConnexionIdentifiant = new System.Windows.Forms.TextBox();
            this.textBoxConnexionMotdepasse = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConnexionValider = new System.Windows.Forms.Button();
            this.buttonConnexionAnnuler = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelConnexionIdentifiant = new System.Windows.Forms.Label();
            this.labelConnexionMotdePasse = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxConnexionIdentifiant
            // 
            this.textBoxConnexionIdentifiant.Location = new System.Drawing.Point(3, 61);
            this.textBoxConnexionIdentifiant.Name = "textBoxConnexionIdentifiant";
            this.textBoxConnexionIdentifiant.Size = new System.Drawing.Size(246, 20);
            this.textBoxConnexionIdentifiant.TabIndex = 0;
            // 
            // textBoxConnexionMotdepasse
            // 
            this.textBoxConnexionMotdepasse.Location = new System.Drawing.Point(3, 119);
            this.textBoxConnexionMotdepasse.Name = "textBoxConnexionMotdepasse";
            this.textBoxConnexionMotdepasse.Size = new System.Drawing.Size(246, 20);
            this.textBoxConnexionMotdepasse.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 138);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 300);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonConnexionValider
            // 
            this.buttonConnexionValider.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonConnexionValider.Location = new System.Drawing.Point(3, 3);
            this.buttonConnexionValider.Name = "buttonConnexionValider";
            this.buttonConnexionValider.Size = new System.Drawing.Size(246, 22);
            this.buttonConnexionValider.TabIndex = 2;
            this.buttonConnexionValider.Text = "Connexion";
            this.buttonConnexionValider.UseVisualStyleBackColor = true;
            this.buttonConnexionValider.Click += new System.EventHandler(this.buttonConnexionValider_Click);
            // 
            // buttonConnexionAnnuler
            // 
            this.buttonConnexionAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonConnexionAnnuler.Location = new System.Drawing.Point(3, 31);
            this.buttonConnexionAnnuler.Name = "buttonConnexionAnnuler";
            this.buttonConnexionAnnuler.Size = new System.Drawing.Size(246, 23);
            this.buttonConnexionAnnuler.TabIndex = 3;
            this.buttonConnexionAnnuler.Text = "Annuler";
            this.buttonConnexionAnnuler.UseVisualStyleBackColor = true;
            this.buttonConnexionAnnuler.Click += new System.EventHandler(this.buttonConnexionAnnuler_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonConnexionAnnuler, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonConnexionValider, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(261, 158);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(252, 57);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxConnexionMotdepasse, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.textBoxConnexionIdentifiant, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelConnexionIdentifiant, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelConnexionMotdePasse, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(261, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(252, 149);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // labelConnexionIdentifiant
            // 
            this.labelConnexionIdentifiant.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelConnexionIdentifiant.AutoSize = true;
            this.labelConnexionIdentifiant.Location = new System.Drawing.Point(3, 37);
            this.labelConnexionIdentifiant.Name = "labelConnexionIdentifiant";
            this.labelConnexionIdentifiant.Size = new System.Drawing.Size(59, 13);
            this.labelConnexionIdentifiant.TabIndex = 2;
            this.labelConnexionIdentifiant.Text = "Identifiant :";
            // 
            // labelConnexionMotdePasse
            // 
            this.labelConnexionMotdePasse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelConnexionMotdePasse.AutoSize = true;
            this.labelConnexionMotdePasse.Location = new System.Drawing.Point(3, 95);
            this.labelConnexionMotdePasse.Name = "labelConnexionMotdePasse";
            this.labelConnexionMotdePasse.Size = new System.Drawing.Size(77, 13);
            this.labelConnexionMotdePasse.TabIndex = 2;
            this.labelConnexionMotdePasse.Text = "Mot de passe :";
            // 
            // FormConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConnexion";
            this.ShowIcon = false;
            this.Text = "FYJ - Connexion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxConnexionIdentifiant;
        private System.Windows.Forms.TextBox textBoxConnexionMotdepasse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelConnexionIdentifiant;
        private System.Windows.Forms.Label labelConnexionMotdePasse;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonConnexionAnnuler;
        private System.Windows.Forms.Button buttonConnexionValider;
    }
}