using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerEtudiant
    {
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
                        maCommande.Parameters.Add(new SqlParameter("prenom", etudiant.Prenom == string.Empty ? DBNull.Value:  etudiant.Prenom));
                        maCommande.Parameters.Add(new SqlParameter("nom", etudiant.Nom == string.Empty ? DBNull.Value: etudiant.Nom));
                        maCommande.Parameters.Add(new SqlParameter("cellulaire", etudiant.Cellulaire == string.Empty ? DBNull.Value: etudiant.Cellulaire));
                        maCommande.Parameters.Add(new SqlParameter("humour", etudiant.Humour == 0 ? DBNull.Value: etudiant.Humour));
                        maCommande.Parameters.Add(new SqlParameter("no_provenance", etudiant.No_provenance == 0 ? DBNull.Value: etudiant.No_provenance));

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
