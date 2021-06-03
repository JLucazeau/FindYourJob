
namespace FindYourJob
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fillByProcStockToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelRechercher = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxRechercher = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonPostuler = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPartager = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBlacklister = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButtonFiltre = new System.Windows.Forms.ToolStripDropDownButton();
            this.defautToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blacklistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewOffres = new System.Windows.Forms.DataGridView();
            this.offreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.find_your_jobDataSet = new FindYourJob.find_your_jobDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.offreTableAdapter = new FindYourJob.find_your_jobDataSetTableAdapters.offreTableAdapter();
            this.blacklistTableAdapter = new FindYourJob.find_your_jobDataSetTableAdapters.blacklistTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPosterTitre = new System.Windows.Forms.Label();
            this.labelPosterCategorie = new System.Windows.Forms.Label();
            this.labelPosterEntreprise = new System.Windows.Forms.Label();
            this.labelPosterVille = new System.Windows.Forms.Label();
            this.labelPosterCodeP = new System.Windows.Forms.Label();
            this.labelPosterContrat = new System.Windows.Forms.Label();
            this.labelPosterContact = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPosterTitre = new System.Windows.Forms.TextBox();
            this.textBoxPosterCategorie = new System.Windows.Forms.TextBox();
            this.textBoxPosterEntreprise = new System.Windows.Forms.TextBox();
            this.textBoxPosterVille = new System.Windows.Forms.TextBox();
            this.textBoxPosterCodeP = new System.Windows.Forms.TextBox();
            this.textBoxPosterContact = new System.Windows.Forms.TextBox();
            this.comboBoxContrat = new System.Windows.Forms.ComboBox();
            this.richTextBoxPosterMessage = new System.Windows.Forms.RichTextBox();
            this.buttonPosterPoster = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.fillByProcStockToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.find_your_jobDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1099, 455);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.fillByProcStockToolStrip);
            this.tabPage1.Controls.Add(this.dataGridViewOffres);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1091, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rechercher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fillByProcStockToolStrip
            // 
            this.fillByProcStockToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelRechercher,
            this.toolStripTextBoxRechercher,
            this.toolStripButtonPostuler,
            this.toolStripButtonPartager,
            this.toolStripButtonBlacklister,
            this.toolStripDropDownButtonFiltre});
            this.fillByProcStockToolStrip.Location = new System.Drawing.Point(3, 3);
            this.fillByProcStockToolStrip.Name = "fillByProcStockToolStrip";
            this.fillByProcStockToolStrip.Size = new System.Drawing.Size(1085, 25);
            this.fillByProcStockToolStrip.TabIndex = 1;
            this.fillByProcStockToolStrip.Text = "fillByProcStockToolStrip";
            // 
            // toolStripLabelRechercher
            // 
            this.toolStripLabelRechercher.Name = "toolStripLabelRechercher";
            this.toolStripLabelRechercher.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabelRechercher.Text = "Rechercher";
            // 
            // toolStripTextBoxRechercher
            // 
            this.toolStripTextBoxRechercher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBoxRechercher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxRechercher.Name = "toolStripTextBoxRechercher";
            this.toolStripTextBoxRechercher.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBoxRechercher.TextChanged += new System.EventHandler(this.toolStripTextBoxRechercher_TextChanged);
            // 
            // toolStripButtonPostuler
            // 
            this.toolStripButtonPostuler.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPostuler.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPostuler.Image")));
            this.toolStripButtonPostuler.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripButtonPostuler.Name = "toolStripButtonPostuler";
            this.toolStripButtonPostuler.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonPostuler.Text = "Postuler";
            this.toolStripButtonPostuler.Click += new System.EventHandler(this.toolStripButtonPostuler_Click_1);
            // 
            // toolStripButtonPartager
            // 
            this.toolStripButtonPartager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonPartager.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPartager.Image")));
            this.toolStripButtonPartager.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripButtonPartager.Name = "toolStripButtonPartager";
            this.toolStripButtonPartager.Size = new System.Drawing.Size(55, 22);
            this.toolStripButtonPartager.Text = "Partager";
            this.toolStripButtonPartager.Click += new System.EventHandler(this.toolStripButtonPartager_Click);
            // 
            // toolStripButtonBlacklister
            // 
            this.toolStripButtonBlacklister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonBlacklister.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripButtonBlacklister.Name = "toolStripButtonBlacklister";
            this.toolStripButtonBlacklister.Size = new System.Drawing.Size(64, 22);
            this.toolStripButtonBlacklister.Text = "Blacklister";
            this.toolStripButtonBlacklister.Click += new System.EventHandler(this.toolStripButtonBlacklister_Click_1);
            // 
            // toolStripDropDownButtonFiltre
            // 
            this.toolStripDropDownButtonFiltre.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButtonFiltre.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFiltre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defautToolStripMenuItem,
            this.blacklistToolStripMenuItem});
            this.toolStripDropDownButtonFiltre.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.toolStripDropDownButtonFiltre.Name = "toolStripDropDownButtonFiltre";
            this.toolStripDropDownButtonFiltre.Size = new System.Drawing.Size(50, 22);
            this.toolStripDropDownButtonFiltre.Text = "Filtrer";
            // 
            // defautToolStripMenuItem
            // 
            this.defautToolStripMenuItem.Name = "defautToolStripMenuItem";
            this.defautToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.defautToolStripMenuItem.Text = "Defaut";
            this.defautToolStripMenuItem.Click += new System.EventHandler(this.defautToolStripMenuItem_Click);
            // 
            // blacklistToolStripMenuItem
            // 
            this.blacklistToolStripMenuItem.Name = "blacklistToolStripMenuItem";
            this.blacklistToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.blacklistToolStripMenuItem.Text = "Blacklist";
            this.blacklistToolStripMenuItem.Click += new System.EventHandler(this.blacklistToolStripMenuItem_Click);
            // 
            // dataGridViewOffres
            // 
            this.dataGridViewOffres.AllowUserToAddRows = false;
            this.dataGridViewOffres.AllowUserToDeleteRows = false;
            this.dataGridViewOffres.AllowUserToResizeColumns = false;
            this.dataGridViewOffres.AllowUserToResizeRows = false;
            this.dataGridViewOffres.AutoGenerateColumns = false;
            this.dataGridViewOffres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOffres.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewOffres.ColumnHeadersHeight = 30;
            this.dataGridViewOffres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOffres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
            this.dataGridViewOffres.DataSource = this.offreBindingSource;
            this.dataGridViewOffres.Location = new System.Drawing.Point(3, 31);
            this.dataGridViewOffres.MultiSelect = false;
            this.dataGridViewOffres.Name = "dataGridViewOffres";
            this.dataGridViewOffres.ReadOnly = true;
            this.dataGridViewOffres.RowHeadersVisible = false;
            this.dataGridViewOffres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOffres.Size = new System.Drawing.Size(1085, 350);
            this.dataGridViewOffres.TabIndex = 1;
            // 
            // offreBindingSource
            // 
            this.offreBindingSource.DataMember = "offre";
            this.offreBindingSource.DataSource = this.find_your_jobDataSet;
            // 
            // find_your_jobDataSet
            // 
            this.find_your_jobDataSet.DataSetName = "find_your_jobDataSet";
            this.find_your_jobDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1091, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Poster";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // offreTableAdapter
            // 
            this.offreTableAdapter.ClearBeforeFill = true;
            // 
            // blacklistTableAdapter
            // 
            this.blacklistTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.91589F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.08411F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxPosterContact, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxContrat, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPosterCodeP, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPosterVille, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPosterEntreprise, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPosterCategorie, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPosterTitre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPosterCategorie, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPosterEntreprise, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPosterVille, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelPosterCodeP, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPosterContrat, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelPosterContact, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPosterTitre, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 411);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelPosterTitre
            // 
            this.labelPosterTitre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPosterTitre.AutoSize = true;
            this.labelPosterTitre.Location = new System.Drawing.Point(3, 8);
            this.labelPosterTitre.Name = "labelPosterTitre";
            this.labelPosterTitre.Size = new System.Drawing.Size(34, 13);
            this.labelPosterTitre.TabIndex = 0;
            this.labelPosterTitre.Text = "Titre :";
            // 
            // labelPosterCategorie
            // 
            this.labelPosterCategorie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPosterCategorie.AutoSize = true;
            this.labelPosterCategorie.Location = new System.Drawing.Point(3, 38);
            this.labelPosterCategorie.Name = "labelPosterCategorie";
            this.labelPosterCategorie.Size = new System.Drawing.Size(58, 13);
            this.labelPosterCategorie.TabIndex = 0;
            this.labelPosterCategorie.Text = "Categorie :";
            // 
            // labelPosterEntreprise
            // 
            this.labelPosterEntreprise.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPosterEntreprise.AutoSize = true;
            this.labelPosterEntreprise.Location = new System.Drawing.Point(3, 68);
            this.labelPosterEntreprise.Name = "labelPosterEntreprise";
            this.labelPosterEntreprise.Size = new System.Drawing.Size(60, 13);
            this.labelPosterEntreprise.TabIndex = 0;
            this.labelPosterEntreprise.Text = "Entreprise :";
            // 
            // labelPosterVille
            // 
            this.labelPosterVille.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPosterVille.AutoSize = true;
            this.labelPosterVille.Location = new System.Drawing.Point(3, 98);
            this.labelPosterVille.Name = "labelPosterVille";
            this.labelPosterVille.Size = new System.Drawing.Size(32, 13);
            this.labelPosterVille.TabIndex = 0;
            this.labelPosterVille.Text = "Ville :";
            // 
            // labelPosterCodeP
            // 
            this.labelPosterCodeP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPosterCodeP.AutoSize = true;
            this.labelPosterCodeP.Location = new System.Drawing.Point(3, 128);
            this.labelPosterCodeP.Name = "labelPosterCodeP";
            this.labelPosterCodeP.Size = new System.Drawing.Size(70, 13);
            this.labelPosterCodeP.TabIndex = 0;
            this.labelPosterCodeP.Text = "Code Postal :";
            // 
            // labelPosterContrat
            // 
            this.labelPosterContrat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPosterContrat.AutoSize = true;
            this.labelPosterContrat.Location = new System.Drawing.Point(3, 158);
            this.labelPosterContrat.Name = "labelPosterContrat";
            this.labelPosterContrat.Size = new System.Drawing.Size(47, 13);
            this.labelPosterContrat.TabIndex = 0;
            this.labelPosterContrat.Text = "Contrat :";
            // 
            // labelPosterContact
            // 
            this.labelPosterContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPosterContact.AutoSize = true;
            this.labelPosterContact.Location = new System.Drawing.Point(3, 188);
            this.labelPosterContact.Name = "labelPosterContact";
            this.labelPosterContact.Size = new System.Drawing.Size(50, 13);
            this.labelPosterContact.TabIndex = 0;
            this.labelPosterContact.Text = "Contact :";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1082, 417);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.richTextBoxPosterMessage, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonPosterPoster, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(544, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(535, 411);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Message :";
            // 
            // textBoxPosterTitre
            // 
            this.textBoxPosterTitre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPosterTitre.Location = new System.Drawing.Point(146, 5);
            this.textBoxPosterTitre.Name = "textBoxPosterTitre";
            this.textBoxPosterTitre.Size = new System.Drawing.Size(186, 20);
            this.textBoxPosterTitre.TabIndex = 1;
            // 
            // textBoxPosterCategorie
            // 
            this.textBoxPosterCategorie.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPosterCategorie.Location = new System.Drawing.Point(146, 35);
            this.textBoxPosterCategorie.Name = "textBoxPosterCategorie";
            this.textBoxPosterCategorie.Size = new System.Drawing.Size(186, 20);
            this.textBoxPosterCategorie.TabIndex = 2;
            // 
            // textBoxPosterEntreprise
            // 
            this.textBoxPosterEntreprise.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPosterEntreprise.Location = new System.Drawing.Point(146, 65);
            this.textBoxPosterEntreprise.Name = "textBoxPosterEntreprise";
            this.textBoxPosterEntreprise.Size = new System.Drawing.Size(186, 20);
            this.textBoxPosterEntreprise.TabIndex = 3;
            // 
            // textBoxPosterVille
            // 
            this.textBoxPosterVille.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPosterVille.Location = new System.Drawing.Point(146, 95);
            this.textBoxPosterVille.Name = "textBoxPosterVille";
            this.textBoxPosterVille.Size = new System.Drawing.Size(186, 20);
            this.textBoxPosterVille.TabIndex = 4;
            // 
            // textBoxPosterCodeP
            // 
            this.textBoxPosterCodeP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPosterCodeP.Location = new System.Drawing.Point(146, 125);
            this.textBoxPosterCodeP.Name = "textBoxPosterCodeP";
            this.textBoxPosterCodeP.Size = new System.Drawing.Size(186, 20);
            this.textBoxPosterCodeP.TabIndex = 5;
            // 
            // textBoxPosterContact
            // 
            this.textBoxPosterContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPosterContact.Enabled = false;
            this.textBoxPosterContact.Location = new System.Drawing.Point(146, 185);
            this.textBoxPosterContact.Name = "textBoxPosterContact";
            this.textBoxPosterContact.Size = new System.Drawing.Size(186, 20);
            this.textBoxPosterContact.TabIndex = 7;
            // 
            // comboBoxContrat
            // 
            this.comboBoxContrat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxContrat.FormattingEnabled = true;
            this.comboBoxContrat.Items.AddRange(new object[] {
            "CDI",
            "CDD",
            "Stage",
            "Alternance"});
            this.comboBoxContrat.Location = new System.Drawing.Point(146, 154);
            this.comboBoxContrat.Name = "comboBoxContrat";
            this.comboBoxContrat.Size = new System.Drawing.Size(186, 21);
            this.comboBoxContrat.TabIndex = 2;
            this.comboBoxContrat.Text = "CDI";
            // 
            // richTextBoxPosterMessage
            // 
            this.richTextBoxPosterMessage.Location = new System.Drawing.Point(3, 33);
            this.richTextBoxPosterMessage.Name = "richTextBoxPosterMessage";
            this.richTextBoxPosterMessage.Size = new System.Drawing.Size(529, 345);
            this.richTextBoxPosterMessage.TabIndex = 2;
            this.richTextBoxPosterMessage.Text = "";
            // 
            // buttonPosterPoster
            // 
            this.buttonPosterPoster.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPosterPoster.Location = new System.Drawing.Point(411, 384);
            this.buttonPosterPoster.Name = "buttonPosterPoster";
            this.buttonPosterPoster.Size = new System.Drawing.Size(121, 23);
            this.buttonPosterPoster.TabIndex = 3;
            this.buttonPosterPoster.Text = "Poster";
            this.buttonPosterPoster.UseVisualStyleBackColor = true;
            this.buttonPosterPoster.Click += new System.EventHandler(this.buttonPosterPoster_Click);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "offre_id";
            this.dataGridViewTextBoxColumn11.HeaderText = "ID";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "offre_titre";
            this.dataGridViewTextBoxColumn12.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "offre_categorie";
            this.dataGridViewTextBoxColumn13.HeaderText = "Catégorie";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "offre_entreprise";
            this.dataGridViewTextBoxColumn14.HeaderText = "Entreprise";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "offre_ville";
            this.dataGridViewTextBoxColumn15.HeaderText = "Ville";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "offre_cp";
            this.dataGridViewTextBoxColumn16.HeaderText = "Code Postal";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "offre_description";
            this.dataGridViewTextBoxColumn17.HeaderText = "Description";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "offre_contrat";
            this.dataGridViewTextBoxColumn18.HeaderText = "Contrat";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "offre_date";
            this.dataGridViewTextBoxColumn19.HeaderText = "Date";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "offre_contact";
            this.dataGridViewTextBoxColumn20.HeaderText = "Contact";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 479);
            this.Controls.Add(this.tabControlMain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "FindYourJob";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.fillByProcStockToolStrip.ResumeLayout(false);
            this.fillByProcStockToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOffres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.find_your_jobDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewOffres;
        private System.Windows.Forms.DataGridViewTextBoxColumn offreidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offretitreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrecategorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offreentrepriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrevilleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrecpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offredescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrecontratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offredateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn offrecontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private find_your_jobDataSetTableAdapters.offreTableAdapter offreTableAdapter;
        private find_your_jobDataSetTableAdapters.blacklistTableAdapter blacklistTableAdapter;
        private find_your_jobDataSet find_your_jobDataSet;
        private System.Windows.Forms.BindingSource offreBindingSource;
        private System.Windows.Forms.ToolStrip fillByProcStockToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonPostuler;
        private System.Windows.Forms.ToolStripButton toolStripButtonPartager;
        private System.Windows.Forms.ToolStripLabel toolStripLabelRechercher;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxRechercher;
        private System.Windows.Forms.ToolStripButton toolStripButtonBlacklister;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFiltre;
        private System.Windows.Forms.ToolStripMenuItem defautToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blacklistToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPosterContact;
        private System.Windows.Forms.ComboBox comboBoxContrat;
        private System.Windows.Forms.TextBox textBoxPosterCodeP;
        private System.Windows.Forms.TextBox textBoxPosterVille;
        private System.Windows.Forms.TextBox textBoxPosterEntreprise;
        private System.Windows.Forms.TextBox textBoxPosterCategorie;
        private System.Windows.Forms.Label labelPosterTitre;
        private System.Windows.Forms.Label labelPosterCategorie;
        private System.Windows.Forms.Label labelPosterEntreprise;
        private System.Windows.Forms.Label labelPosterVille;
        private System.Windows.Forms.Label labelPosterCodeP;
        private System.Windows.Forms.Label labelPosterContrat;
        private System.Windows.Forms.Label labelPosterContact;
        private System.Windows.Forms.TextBox textBoxPosterTitre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxPosterMessage;
        private System.Windows.Forms.Button buttonPosterPoster;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
    }
}