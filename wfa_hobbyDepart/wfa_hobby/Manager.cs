using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_hobby
{
    internal class Manager
    {
        // protected signifie utilisable que par ses filles, sans new
        protected SqlCommand CreerCommand(string nomProcedureStockee, List<SqlParameter>mesParmètre)
        {
            var maCommand = new SqlCommand(nomProcedureStockee,GetConnection());
            //définir le CommandType
            maCommand.CommandType = CommandType.StoredProcedure;
            //ajouter les paramètres a la command
            if(mesParmètre != null )
            {
                maCommand.Parameters.AddRange(mesParmètre.ToArray());
            }   
            //ouvrir la connexion avec la commande
            maCommand.Connection.Open();
            return maCommand;
        }
        protected SqlConnection GetConnection()
        {
            var maConnexion = new SqlConnection(Properties.Settings.Default.maConectionString);
            return maConnexion;
        }
        
    }
}
