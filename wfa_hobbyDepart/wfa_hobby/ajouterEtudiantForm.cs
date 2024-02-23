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
            ManagerProvenance managerProvenance = new ManagerProvenance();
            try
            {
                provenanceComboBox.DataSource = managerProvenance.ListerProvenance();
                provenanceComboBox.DisplayMember = "Name";//nom dans la classe
                provenanceComboBox.ValueMember = "no_provenance";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            etudiant.No_provenance = (int)provenanceComboBox.SelectedValue;
            return etudiant;
        }
        
        
        private void ajouterButton_Click(object sender, EventArgs e)
        {   Etudiant etudiant = new Etudiant();
            ManagerEtudiant managerEtudiant = new ManagerEtudiant();
            int nombreDeLigneAffectees = 0;
            try 
            {
                if (textBoxSontRemplis())
                {
                    //prendre les valeur
                    etudiant = PrendreLesValeursDesTextBox();
                    //appeler fonction ajout
                    nombreDeLigneAffectees = managerEtudiant.AjouterEtudiant(etudiant);
                    if (nombreDeLigneAffectees >0)
                    {
                        MessageBox.Show(" ajout avec succès ");
                    }
                }
                else
                {
                MessageBox.Show(" Entrez toutes le données ");
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}
