using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Marca
    {
        private int idMarca;
        private string nombreMarca;
        private byte estado;
        private DateTime fechaRegistro;
        public Marca(int idMarca, string nombreMarca, byte estado, DateTime fechaRegistro)
        {
            this.idMarca = idMarca;
            this.nombreMarca = nombreMarca;
            this.estado = estado;
            this.fechaRegistro = fechaRegistro;
        }
        public Marca(string nombreMarca)
        {
            this.nombreMarca = nombreMarca;
        }
        public DateTime FechaRegistro
        {
            get { return fechaRegistro; }
            set { fechaRegistro = value; }
        }

        public byte Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string NombreMarca
        {
            get { return nombreMarca; }
            set { nombreMarca = value; }
        }
        public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }
    }
}
