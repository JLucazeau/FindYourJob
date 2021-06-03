
namespace FindYourJob
{
    partial class FormEnvoyer
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
            this.richTextBoxEnvoyerMessage = new System.Windows.Forms.RichTextBox();
            this.textBoxEnvoyerEmail = new System.Windows.Forms.TextBox();
            this.labelEnvoyerEmail = new System.Windows.Forms.Label();
            this.labelEnvoyerMessage = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonEnvoyerEnvoyer = new System.Windows.Forms.Button();
            this.buttonEnvoyerAnnuler = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxEnvoyerMessage
            // 
            this.richTextBoxEnvoyerMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxEnvoyerMessage.Location = new System.Drawing.Point(71, 75);
            this.richTextBoxEnvoyerMessage.Name = "richTextBoxEnvoyerMessage";
            this.richTextBoxEnvoyerMessage.Size = new System.Drawing.Size(313, 116);
            this.richTextBoxEnvoyerMessage.TabIndex = 0;
            this.richTextBoxEnvoyerMessage.Text = "";
            // 
            // textBoxEnvoyerEmail
            // 
            this.textBoxEnvoyerEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxEnvoyerEmail.Location = new System.Drawing.Point(71, 26);
            this.textBoxEnvoyerEmail.Name = "textBoxEnvoyerEmail";
            this.textBoxEnvoyerEmail.Size = new System.Drawing.Size(313, 20);
            this.textBoxEnvoyerEmail.TabIndex = 1;
            // 
            // labelEnvoyerEmail
            // 
            this.labelEnvoyerEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEnvoyerEmail.AutoSize = true;
            this.labelEnvoyerEmail.Location = new System.Drawing.Point(71, 59);
            this.labelEnvoyerEmail.Name = "labelEnvoyerEmail";
            this.labelEnvoyerEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEnvoyerEmail.TabIndex = 2;
            this.labelEnvoyerEmail.Text = "Email :";
            // 
            // labelEnvoyerMessage
            // 
            this.labelEnvoyerMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelEnvoyerMessage.AutoSize = true;
            this.labelEnvoyerMessage.Location = new System.Drawing.Point(71, 8);
            this.labelEnvoyerMessage.Name = "labelEnvoyerMessage";
            this.labelEnvoyerMessage.Size = new System.Drawing.Size(56, 13);
            this.labelEnvoyerMessage.TabIndex = 3;
            this.labelEnvoyerMessage.Text = "Message :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.labelEnvoyerMessage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxEnvoyerEmail, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.richTextBoxEnvoyerMessage, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelEnvoyerEmail, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(457, 194);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // buttonEnvoyerEnvoyer
            // 
            this.buttonEnvoyerEnvoyer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEnvoyerEnvoyer.Location = new System.Drawing.Point(313, 276);
            this.buttonEnvoyerEnvoyer.Name = "buttonEnvoyerEnvoyer";
            this.buttonEnvoyerEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.buttonEnvoyerEnvoyer.TabIndex = 5;
            this.buttonEnvoyerEnvoyer.Text = "Envoyer";
            this.buttonEnvoyerEnvoyer.UseVisualStyleBackColor = true;
            // 
            // buttonEnvoyerAnnuler
            // 
            this.buttonEnvoyerAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonEnvoyerAnnuler.Location = new System.Drawing.Point(394, 276);
            this.buttonEnvoyerAnnuler.Name = "buttonEnvoyerAnnuler";
            this.buttonEnvoyerAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonEnvoyerAnnuler.TabIndex = 6;
            this.buttonEnvoyerAnnuler.Text = "Annuler";
            this.buttonEnvoyerAnnuler.UseVisualStyleBackColor = true;
            // 
            // FormEnvoyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 311);
            this.Controls.Add(this.buttonEnvoyerAnnuler);
            this.Controls.Add(this.buttonEnvoyerEnvoyer);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEnvoyer";
            this.ShowIcon = false;
            this.Text = "Envoyer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxEnvoyerMessage;
        private System.Windows.Forms.TextBox textBoxEnvoyerEmail;
        private System.Windows.Forms.Label labelEnvoyerEmail;
        private System.Windows.Forms.Label labelEnvoyerMessage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonEnvoyerEnvoyer;
        private System.Windows.Forms.Button buttonEnvoyerAnnuler;
    }
}