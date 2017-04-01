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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Behaviours;

namespace ATENEA_SYSTEM_BDDIII
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : MetroWindow
    {
        public Menu()
        {
            InitializeComponent();
            lblfecha.Content = DateTime.Now.ToString();
        }

        private void Tile_Click_1(object sender, RoutedEventArgs e)
        {
            Personas.frmPesonal frm = new Personas.frmPesonal();
            frm.Show();
        }

        private void Tile_Click_2(object sender, RoutedEventArgs e)
        {
          
        }

        private void Tile_Click_3(object sender, RoutedEventArgs e)
        {
        }

        private void Tile_Click(object sender, RoutedEventArgs e)
        {
            Product.wpfProducto frm = new Product.wpfProducto();
            frm.Show();
        }
    }
}
