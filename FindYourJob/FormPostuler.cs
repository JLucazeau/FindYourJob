using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindYourJob
{
    public partial class FormPostuler : Form
    {
        public string user_id;
        public string offre_id;
        public string offre_contact;
        public FormPostuler()
        {
            InitializeComponent();
        }

        private void buttonParcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogParcourir = new OpenFileDialog();
            openFileDialogParcourir.ShowDialog();
            openFileDialogParcourir.InitialDirectory = @"/temp/";
            openFileDialogParcourir.DefaultExt = "txt";
            openFileDialogParcourir.CheckFileExists = true;
            openFileDialogParcourir.CheckPathExists = true;
            labelParcourir.Text = openFileDialogParcourir.FileName;
        }

        private void FormPostuler_Load(object sender, EventArgs e)
        {
            textBoxPostulerContact.Text = offre_contact;
        }
    }
}
