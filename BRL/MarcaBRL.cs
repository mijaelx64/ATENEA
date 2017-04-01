using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Common;
using System.Data;
namespace BRL
{
    public class MarcaBRL
    {
        public static DataTable seleccionarMarcaBRL()
        {
            return MarcaDAL.seleccionarMarca();
        }
       public static void insertarMarcaBRL(Marca m)
        {
            MarcaDAL.InsertarMarca(m);
        }
    }
}
