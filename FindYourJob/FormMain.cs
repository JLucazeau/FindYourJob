using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FindYourJob
{
    public partial class FormMain : Form
    {
        
        public string user_id, user_identifiant;
        public FormMain()
        {
            InitializeComponent();
        }

        
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'find_your_jobDataSet.offre'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.offreTableAdapter.Fill(this.find_your_jobDataSet.offre);
            
            string strcon = "datasource=localhost; username=root; password=; database=find_your_job";
            MySqlConnection cnSQL = null;
            MySqlCommand cmSQL = null;
            MySqlDataReader drSQL = null;
            cnSQL = new MySqlConnection(strcon);
            try
            {
                cnSQL.Open();
                bool connexion;
                do
                {
                    connexion = true;
                    FormConnexion dlg = new FormConnexion();
                    DialogResult res = dlg.ShowDialog();
                    if (res == DialogResult.OK)
                    {
                        string strSQL = "SELECT user_id,user_motdepasse FROM `user` WHERE user_identifiant = '" + dlg.identifiant + "';";
                        cmSQL = new MySqlCommand(strSQL, cnSQL);
                        drSQL = cmSQL.ExecuteReader();
                        if (drSQL.Read())
                        {
                            if (dlg.motdepasse == Convert.ToString(drSQL["user_motdepasse"]))
                            {
                                this.user_id = Convert.ToString(drSQL["user_id"]);
                                drSQL.Close();
                                drSQL = null;
                                textBoxPosterContact.Text = dlg.identifiant;
                                this.user_identifiant = dlg.identifiant;
                                this.offreTableAdapter.FillByProcStock(this.find_your_jobDataSet.offre, new System.Nullable<int>(((int)(System.Convert.ToInt32(user_id)))));
                            }
                            else
                            {
                                connexion = false;
                                drSQL.Close();
                                MessageBox.Show("user_password:unknown \n Mot de passe incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            connexion = false;
                            drSQL.Close();
                            MessageBox.Show("user_account:unknown \n Identifiant incorrect", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                while (connexion == false);
                cnSQL.Close();

            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Connection Error : Database", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void toolStripButtonBlacklister_Click_1(object sender, EventArgs e)
        {
            string strcon = "datasource=localhost; username=root; password=; database=find_your_job";
            MySqlConnection cnSQL = null;
            MySqlCommand cmSQL = null;
            cnSQL = new MySqlConnection(strcon);
            try
            {
                cnSQL.Open();
                string offre_id = dataGridViewOffres.CurrentRow.Cells[0].Value.ToString();
                string strSQL = "INSERT INTO `blacklist` VALUES (null," + user_id + "," + offre_id + ");";
                cmSQL = new MySqlCommand(strSQL, cnSQL);
                int count = cmSQL.ExecuteNonQuery();
                if (count != 0)
                {
                    MessageBox.Show("Offre ajoutée dans votre 'Blacklist'.", "Statut", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.offreTableAdapter.FillByProcStock(this.find_your_jobDataSet.offre, new System.Nullable<int>(((int)(System.Convert.ToInt32(user_id)))));
                }
                else
                {
                    MessageBox.Show("Offre non ajoutée dans votre 'Blacklist' .", "Statut", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cnSQL.Close();
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Connection Error : Database", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripButtonPartager_Click(object sender, EventArgs e)
        {
            string strcon = "datasource=localhost; username=root; password=; database=find_your_job";
            MySqlConnection cnSQL = null;
            MySqlCommand cmSQL = null;
            MySqlDataReader drSQL = null;
            cnSQL = new MySqlConnection(strcon);
            try
            {
                cnSQL.Open();
                FormEnvoyer FormEnvoyer = new FormEnvoyer();
                FormEnvoyer.user_id = user_id;
                FormEnvoyer.offre_id = dataGridViewOffres.CurrentRow.Cells[0].Value.ToString();
                DialogResult res = FormEnvoyer.ShowDialog();
                if (res == DialogResult.OK)
                {
                    //Process d'envoi du mail..
                    MessageBox.Show("Vous avez partager une offre. (Extension pour envoi de mail manquante..)", "Statut", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cnSQL.Close();
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Connection Error : Database", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripButtonPostuler_Click_1(object sender, EventArgs e)
        {
            string strcon = "datasource=localhost; username=root; password=; database=find_your_job";
            MySqlConnection cnSQL = null;
            MySqlCommand cmSQL = null;
            MySqlDataReader drSQL = null;
            cnSQL = new MySqlConnection(strcon);
            try
            {
                cnSQL.Open();
                FormPostuler FormPostuler = new FormPostuler();
                FormPostuler.user_id = user_id;
                FormPostuler.offre_id = dataGridViewOffres.CurrentRow.Cells[0].Value.ToString();
                FormPostuler.offre_contact = dataGridViewOffres.CurrentRow.Cells[9].Value.ToString();
                DialogResult res = FormPostuler.ShowDialog();
                if (res == DialogResult.OK)
                {
                    //Process d'envoi du mail..
                    MessageBox.Show("Vous avez postuler à une offre. (Extension pour envoi de mail manquante..)", "Statut", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cnSQL.Close();
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Connection Error : Database", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void defautToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.offreTableAdapter.Fill(this.find_your_jobDataSet.offre);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void blacklistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.offreTableAdapter.FillByProcStock(this.find_your_jobDataSet.offre, new System.Nullable<int>(((int)(System.Convert.ToInt32(user_id)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void toolStripTextBoxRechercher_TextChanged(object sender, EventArgs e)
        {
            string recherche = toolStripTextBoxRechercher.Text;
            offreBindingSource.Filter = "offre_titre like '%" + recherche + "%' or offre_categorie like '%" + recherche + "%' or offre_entreprise like '%" + recherche + "%' or offre_ville like '%" + recherche + "%' or offre_description like '%" + recherche + "%' or offre_contrat like '%" + recherche + "%' ";
        }

        private void buttonPosterPoster_Click(object sender, EventArgs e)
        {
            string titre, categorie, entreprise, ville, codePostal, contrat, contact, message;
            titre = textBoxPosterTitre.Text;
            categorie = textBoxPosterCategorie.Text;
            entreprise = textBoxPosterEntreprise.Text;
            ville = textBoxPosterVille.Text;
            codePostal = textBoxPosterCodeP.Text;
            message = richTextBoxPosterMessage.Text;
            contrat = comboBoxContrat.Text;
            contact = user_identifiant;
            string strcon = "datasource=localhost; username=root; password=; database=find_your_job";
            MySqlConnection cnSQL = null;
            MySqlCommand cmSQL = null;
            cnSQL = new MySqlConnection(strcon);
            try
            {
                cnSQL.Open();
                string strSQL = "INSERT INTO `offre` VALUES (null,'"+ titre + "','"+ categorie + "','"+ entreprise + "','"+ ville + "','"+ codePostal + "','"+ message + "','"+ contrat + "','"+ DateTime.Now.ToString("yyyy-MM-dd")+ "','"+ contact + "')";
                MessageBox.Show(""+ strSQL + "", "Statut", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmSQL = new MySqlCommand(strSQL, cnSQL);
                int count = cmSQL.ExecuteNonQuery();
                if (count != 0)
                {
                    MessageBox.Show("Offre ajoutée avec succès.", "Statut", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxPosterTitre.Text = "";
                    textBoxPosterCategorie.Text = "";
                    textBoxPosterEntreprise.Text = "";
                    textBoxPosterVille.Text = "";
                    textBoxPosterCodeP.Text = "";
                    richTextBoxPosterMessage.Text = "";
                    comboBoxContrat.Text = "CDI";
                }
                else
                {
                    MessageBox.Show("Offre non ajoutée..", "Statut", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cnSQL.Close();
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Connection Error : Database", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}