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
    public partial class FormConnexion : Form
    {
        public string identifiant, motdepasse;

        private void buttonConnexionValider_Click(object sender, EventArgs e)
        {
            this.identifiant = textBoxConnexionIdentifiant.Text;
            this.motdepasse = textBoxConnexionMotdepasse.Text;
            Close();
        }

        private void buttonConnexionAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        public FormConnexion()
        {
            InitializeComponent();
        }

    }
}
