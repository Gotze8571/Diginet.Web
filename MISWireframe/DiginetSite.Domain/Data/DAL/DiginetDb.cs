using DiginetSite.Domain.Data.BusinessObjet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiginetSite.Domain.Data.DAL
{
    public class DiginetDb
    {
        public GoldLedgerList GetGoldLedger()
        {
            GoldLedgerList list = new GoldLedgerList();

            string com = ConfigurationManager.ConnectionStrings["DiginetDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(com))
            {
                
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Retrieve_Record_Proc", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Name", "HardDisk"));

                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                    }
                    return null;

                }
                catch (Exception)
                {

                    throw;
                }
                
            }

                var query = $"Select ";
        }
    }
}
