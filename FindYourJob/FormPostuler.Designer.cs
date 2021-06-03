
namespace FindYourJob
{
    partial class FormPostuler
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
            this.buttonPostulerEnvoyer = new System.Windows.Forms.Button();
            this.buttonPostulerAnnuler = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxPostulerNom = new System.Windows.Forms.TextBox();
            this.labelParcourir = new System.Windows.Forms.Label();
            this.textBoxPostulerPrenom = new System.Windows.Forms.TextBox();
            this.textBoxPostulerContact = new System.Windows.Forms.TextBox();
            this.labelPostulerNom = new System.Windows.Forms.Label();
            this.labelPsotulerPrenom = new System.Windows.Forms.Label();
            this.labelPostulerContact = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelPostulerMessage = new System.Windows.Forms.Label();
            this.buttonPostulerParcourir = new System.Windows.Forms.Button();
            this.openFileDialogParcourir = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxPostulerMessage = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPostulerEnvoyer
            // 
            this.buttonPostulerEnvoyer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonPostulerEnvoyer.Location = new System.Drawing.Point(190, 415);
            this.buttonPostulerEnvoyer.Name = "buttonPostulerEnvoyer";
            this.buttonPostulerEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.buttonPostulerEnvoyer.TabIndex = 0;
            this.buttonPostulerEnvoyer.Text = "Envoyer";
            this.buttonPostulerEnvoyer.UseVisualStyleBackColor = true;
            // 
            // buttonPostulerAnnuler
            // 
            this.buttonPostulerAnnuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonPostulerAnnuler.Location = new System.Drawing.Point(271, 415);
            this.buttonPostulerAnnuler.Name = "buttonPostulerAnnuler";
            this.buttonPostulerAnnuler.Size = new System.Drawing.Size(75, 23);
            this.buttonPostulerAnnuler.TabIndex = 1;
            this.buttonPostulerAnnuler.Text = "Annuler";
            this.buttonPostulerAnnuler.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.34132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.65868F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxPostulerNom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelParcourir, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPostulerPrenom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPostulerContact, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPostulerNom, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPsotulerPrenom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPostulerContact, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPostulerMessage, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonPostulerParcourir, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 155);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // textBoxPostulerNom
            // 
            this.textBoxPostulerNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPostulerNom.Location = new System.Drawing.Point(101, 5);
            this.textBoxPostulerNom.Name = "textBoxPostulerNom";
            this.textBoxPostulerNom.Size = new System.Drawing.Size(230, 20);
            this.textBoxPostulerNom.TabIndex = 0;
            // 
            // labelParcourir
            // 
            this.labelParcourir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelParcourir.AutoSize = true;
            this.labelParcourir.Location = new System.Drawing.Point(331, 133);
            this.labelParcourir.Name = "labelParcourir";
            this.labelParcourir.Size = new System.Drawing.Size(0, 13);
            this.labelParcourir.TabIndex = 3;
            // 
            // textBoxPostulerPrenom
            // 
            this.textBoxPostulerPrenom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPostulerPrenom.Location = new System.Drawing.Point(101, 36);
            this.textBoxPostulerPrenom.Name = "textBoxPostulerPrenom";
            this.textBoxPostulerPrenom.Size = new System.Drawing.Size(230, 20);
            this.textBoxPostulerPrenom.TabIndex = 1;
            // 
            // textBoxPostulerContact
            // 
            this.textBoxPostulerContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPostulerContact.Enabled = false;
            this.textBoxPostulerContact.Location = new System.Drawing.Point(101, 67);
            this.textBoxPostulerContact.Name = "textBoxPostulerContact";
            this.textBoxPostulerContact.Size = new System.Drawing.Size(230, 20);
            this.textBoxPostulerContact.TabIndex = 2;
            // 
            // labelPostulerNom
            // 
            this.labelPostulerNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPostulerNom.AutoSize = true;
            this.labelPostulerNom.Location = new System.Drawing.Point(3, 9);
            this.labelPostulerNom.Name = "labelPostulerNom";
            this.labelPostulerNom.Size = new System.Drawing.Size(35, 13);
            this.labelPostulerNom.TabIndex = 5;
            this.labelPostulerNom.Text = "Nom :";
            // 
            // labelPsotulerPrenom
            // 
            this.labelPsotulerPrenom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPsotulerPrenom.AutoSize = true;
            this.labelPsotulerPrenom.Location = new System.Drawing.Point(3, 40);
            this.labelPsotulerPrenom.Name = "labelPsotulerPrenom";
            this.labelPsotulerPrenom.Size = new System.Drawing.Size(49, 13);
            this.labelPsotulerPrenom.TabIndex = 5;
            this.labelPsotulerPrenom.Text = "Prénom :";
            // 
            // labelPostulerContact
            // 
            this.labelPostulerContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPostulerContact.AutoSize = true;
            this.labelPostulerContact.Location = new System.Drawing.Point(3, 71);
            this.labelPostulerContact.Name = "labelPostulerContact";
            this.labelPostulerContact.Size = new System.Drawing.Size(50, 13);
            this.labelPostulerContact.TabIndex = 5;
            this.labelPostulerContact.Text = "Contact :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pièce jointe :";
            // 
            // labelPostulerMessage
            // 
            this.labelPostulerMessage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPostulerMessage.AutoSize = true;
            this.labelPostulerMessage.Location = new System.Drawing.Point(3, 133);
            this.labelPostulerMessage.Name = "labelPostulerMessage";
            this.labelPostulerMessage.Size = new System.Drawing.Size(56, 13);
            this.labelPostulerMessage.TabIndex = 5;
            this.labelPostulerMessage.Text = "Message :";
            // 
            // buttonPostulerParcourir
            // 
            this.buttonPostulerParcourir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonPostulerParcourir.Location = new System.Drawing.Point(101, 97);
            this.buttonPostulerParcourir.Name = "buttonPostulerParcourir";
            this.buttonPostulerParcourir.Size = new System.Drawing.Size(230, 23);
            this.buttonPostulerParcourir.TabIndex = 4;
            this.buttonPostulerParcourir.Text = "Parcourir...";
            this.buttonPostulerParcourir.UseVisualStyleBackColor = true;
            this.buttonPostulerParcourir.Click += new System.EventHandler(this.buttonParcourir_Click);
            // 
            // openFileDialogParcourir
            // 
            this.openFileDialogParcourir.FileName = "openFileDialog1";
            // 
            // richTextBoxPostulerMessage
            // 
            this.richTextBoxPostulerMessage.Location = new System.Drawing.Point(12, 173);
            this.richTextBoxPostulerMessage.Name = "richTextBoxPostulerMessage";
            this.richTextBoxPostulerMessage.Size = new System.Drawing.Size(334, 206);
            this.richTextBoxPostulerMessage.TabIndex = 4;
            this.richTextBoxPostulerMessage.Text = "";
            // 
            // FormPostuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.richTextBoxPostulerMessage);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.buttonPostulerAnnuler);
            this.Controls.Add(this.buttonPostulerEnvoyer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPostuler";
            this.ShowIcon = false;
            this.Text = "Postuler";
            this.Load += new System.EventHandler(this.FormPostuler_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPostulerEnvoyer;
        private System.Windows.Forms.Button buttonPostulerAnnuler;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPostulerNom;
        private System.Windows.Forms.TextBox textBoxPostulerPrenom;
        private System.Windows.Forms.TextBox textBoxPostulerContact;
        private System.Windows.Forms.Button buttonPostulerParcourir;
        private System.Windows.Forms.OpenFileDialog openFileDialogParcourir;
        private System.Windows.Forms.Label labelParcourir;
        private System.Windows.Forms.Label labelPostulerNom;
        private System.Windows.Forms.Label labelPsotulerPrenom;
        private System.Windows.Forms.Label labelPostulerContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelPostulerMessage;
        private System.Windows.Forms.RichTextBox richTextBoxPostulerMessage;
    }
}