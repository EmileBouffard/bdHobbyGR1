using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_hobby
{
    public partial class ajouterEtudiantForm : Form
    {
        public ajouterEtudiantForm()
        {
            InitializeComponent();
        }

        private void ajouterEtudiantForm_Load(object sender, EventArgs e)
        {

        }
        private Boolean textBoxSontRemplis()
        {
            return (prenomTextBox.Text != "" && nomTextBox.Text != "" && cellulaireTextBox.Text != "");
        }
        private Etudiant PrendreLesValeursDesTextBox()
        {
            Etudiant etudiant = new Etudiant();
            etudiant.Prenom = prenomTextBox.Text;
            etudiant.Nom = nomTextBox.Text;
            etudiant.Cellulaire = cellulaireTextBox.Text;
            etudiant.Humour = (int)humourNumericUpDown.Value;
            etudiant.No_provenance = 1; //remplacer plus tard
            return etudiant;
        }
        
        
        private void ajouterButton_Click(object sender, EventArgs e)
        {   Etudiant etudiant = new Etudiant();
            try 
            {
                if (textBoxSontRemplis())
                {
                    //prendre les valeur
                    etudiant = PrendreLesValeursDesTextBox();
                    //appeler fonction ajout
                }
                else
                {
                MessageBox.Show(" Entrez toutes le données ");
                }
            } 
            catch(Exception)
            {
                throw;
            } 
        }
    }
}
