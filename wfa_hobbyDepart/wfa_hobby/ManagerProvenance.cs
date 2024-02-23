using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerProvenance
    {
        public List<Provenance> ListerProvenance()


        {
            List<Provenance> maList = new List<Provenance>();
            try
            {



                using (var maConexion = new SqlConnection(Properties.Settings.Default.maConectionString))
                {
                    using (var maCommande = new SqlCommand(" ListerProvenance ", maConexion))
                    {
                        //definir commandetype
                        maCommande.CommandType = System.Data.CommandType.StoredProcedure;
                        //definir paramètre
                        //ouvrir la conexion
                        maCommande.Connection.Open();
                        //executer la sp
                        using (var monDataReader = maCommande.ExecuteReader())
                        {
                            while (monDataReader.Read())
                            {
                                Provenance provenance = new Provenance();
                                provenance.No_provenance = (int)monDataReader["no_provenance"];
                                provenance.ProvenanceDescription = monDataReader["Description"].ToString();
                                maList.Add(provenance);
                            }
                        }

                        //lire les resultas
                    }
                    return maList;
                }  
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

