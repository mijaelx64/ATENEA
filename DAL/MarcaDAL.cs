using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;


namespace DAL
{
    public class MarcaDAL
    {
        public static DataTable seleccionarMarca()
        {
            DataTable res = new DataTable();
            string query = "SELECT * FROM marca  WHERE Estado=1";
            try
            {
                SqlCommand cmd = Methods.CreateBasicCommand();
                cmd.CommandText = query;
                res = Methods.ExecuteDataTableCommand(cmd);

            }
            catch (SqlException ex)
            {
                //Escribir el log

                //lanzando la excepcion
                throw ex;
            }
            catch (Exception ex)
            {
                //Escribir el log

                throw ex;
            }

            return res;
        }
        public static void InsertarMarca(Marca m)
        {
            string query = "INSERT INTO [dbo].[MARCA]([Nombre_Marca],Estado)VALUES(@nombreMarca,1)";
            try
            {
                SqlCommand cmd = Methods.CreateBasicCommand();
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@nombreMarca", m.NombreMarca);
                Methods.ExecuteBasicCommand(cmd);
            }
            catch (SqlException ex)
            {
                //Escribir el log
                //lanzando la excepcion
                throw ex;
            }
            catch (Exception ex)
            {
                //Escribir el log

                //lanzando la excepcion                
                throw ex;
            }
        }

    }
}
