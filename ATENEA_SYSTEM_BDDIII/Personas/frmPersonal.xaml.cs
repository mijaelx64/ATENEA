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

namespace ATENEA_SYSTEM_BDDIII.Personas
{
    /// <summary>
    /// Lógica de interacción para frmPesonal.xaml
    /// </summary>
    public partial class frmPesonal : Window
    {
        public frmPesonal()
        {
            InitializeComponent();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            imagenDelaVentana.Source = new BitmapImage(new Uri("/Imagenes/cliente.png", UriKind.Relative));
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {

            imagenDelaVentana.Source = new BitmapImage(new Uri("/Imagenes/personal.png", UriKind.Relative));
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
