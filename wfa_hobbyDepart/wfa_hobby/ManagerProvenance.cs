using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class ManagerProvenance : Manager //hérite de Manager pour avoir le droit d'utilisatio getConnection
    {
        public List<Provenance> ListerProvenance()


        {
            List<Provenance> maList = new List<Provenance>();
            try
            {



                using (var maConexion = GetConnection())
                {
                    using (var maCommande = new SqlCommand("ListerProvenance", maConexion))
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
                                provenance.ProvenanceDescription = monDataReader["Provenance"].ToString();
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

