using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiant
    {
        private List<SqlParameter> definirParametreAjout (Etudiant etudiant)
        {
            List<SqlParameter> mesParametres = new List<SqlParameter> ();
            mesParametres.Add(new SqlParameter("prenom", etudiant.Prenom == string.Empty ? DBNull.Value : etudiant.Prenom));
            mesParametres.Add(new SqlParameter("nom", etudiant.Nom == string.Empty ? DBNull.Value : etudiant.Nom));
            mesParametres.Add(new SqlParameter("cellulaire", etudiant.Cellulaire == string.Empty ? DBNull.Value : etudiant.Cellulaire));
            mesParametres.Add(new SqlParameter("humour", etudiant.Humour == 0 ? DBNull.Value : etudiant.Humour));
            mesParametres.Add(new SqlParameter("no_provenance", etudiant.No_provenance == 0 ? DBNull.Value : etudiant.No_provenance));
            return mesParametres;
        }
        public int AjouterEtudiant(Etudiant etudiant)
        {
            int nombreDeLigneAffecte = 0;
            try
            {
                using (var maConnection= new SqlConnection(Properties.Settings.Default.maConectionString))
                {
                    using (var maCommande = new SqlCommand("ajouterEtudiant",maConnection))
                    {
                        //commandType
                        maCommande.CommandType = System.Data.CommandType.StoredProcedure;
                        // Les parametre
                        List<SqlParameter> mesParametres;
                        mesParametres = definirParametreAjout(etudiant);
                        maCommande.Parameters.AddRange(mesParametres.ToArray());
                        //ouvrir la conection
                        maCommande.Connection.Open();
                        //exec la commande
                        nombreDeLigneAffecte = maCommande.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                throw;
               
            }
            return nombreDeLigneAffecte;
        }
    }
}
