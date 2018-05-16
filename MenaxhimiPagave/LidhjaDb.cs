using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace KNKProjekti
{
    public class LidhjaDb
    {
        public string mesazhi = "";
        public DataSet Lexo(string query)
        {
            SqlConnection objKonektimi = new SqlConnection(parametrat._Konektimi);
            SqlDataAdapter objAdapter = new SqlDataAdapter(query, objKonektimi);
            SqlCommand objKomanda = new SqlCommand(query);
            DataSet _shenime = new DataSet();
            try
            {
                objKonektimi.Open();
                objAdapter.Fill(_shenime);
                mesazhi = "";

            }
            catch (Exception ex)
            {
                mesazhi = ex.Message;
            }
            finally
            {
                objKonektimi.Close();
            }
            return _shenime;
        }
        public string InsUpdDel(string Query)
        {
            SqlConnection objKonektimi = new SqlConnection(parametrat._Konektimi);
            SqlCommand objKomanda = new SqlCommand(Query,objKonektimi);
            try
            {
                objKonektimi.Open();
                objKomanda.ExecuteNonQuery();
                mesazhi = "";
            }
            catch (Exception ex)
            {
                mesazhi = ex.Message;
            }
            finally
            {
                objKonektimi.Close();
            }
            return mesazhi;
        }
    }
}
