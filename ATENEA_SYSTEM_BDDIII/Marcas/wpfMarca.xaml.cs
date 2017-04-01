using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BRL;
using Common;

namespace ATENEA_SYSTEM_BDDIII.Marcas
{
    /// <summary>
    /// Lógica de interacción para wpfMarca.xaml
    /// </summary>
    public partial class wpfMarca :Window
    {
        int opcion;
        Marca marca;
        public wpfMarca()
        {
            InitializeComponent();
        }
        //cargar marca en datagrid
        public void cargarMarca()
        {
           
        }
        private void btnNuevo(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnGuardar(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
