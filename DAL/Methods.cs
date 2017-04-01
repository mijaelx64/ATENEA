using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class Methods
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["BDDBoutique"].ConnectionString;
        public static SqlCommand CreateBasicCommand()
        {
            //Creamos la conexion
            SqlConnection con = new SqlConnection(connectionString);
            //Creamod el Command
            SqlCommand cmd = new SqlCommand();
            cmd = con.CreateCommand();
            return cmd;
        }


        public static void ExecuteBasicCommand(SqlCommand cmd)
        {

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }


        }
        public static DataTable ExecuteDataTableCommand(SqlCommand cmd)
        {
            DataTable res = new DataTable();

            try
            {
                cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(res);

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }



            return res;

        }



        public static SqlDataReader ExecuteDataReaderCommand(SqlCommand cmd)
        {
            SqlDataReader res = null;
            try
            {
                cmd.Connection.Open();
                res = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }



            return res;
        }
    }
}
