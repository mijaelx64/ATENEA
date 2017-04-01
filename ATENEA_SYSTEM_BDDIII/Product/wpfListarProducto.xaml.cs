using System;
using System.Collections.Generic;
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

namespace ATENEA_SYSTEM_BDDIII.Product
{
    /// <summary>
    /// Lógica de interacción para wpfProducto.xaml
    /// </summary>
    public partial class wpfProducto : Window
    {
        public wpfProducto()
        {
            InitializeComponent();
        }

        private void btnCategoria(object sender, RoutedEventArgs e)
        {
            Categoria.wpfCategoria frm = new Categoria.wpfCategoria();
            frm.Show();
        }

        private void btnMarca(object sender, RoutedEventArgs e)
        {
            Marcas.wpfMarca frm = new Marcas.wpfMarca();
            frm.Show();
        }

        private void btnColor(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
