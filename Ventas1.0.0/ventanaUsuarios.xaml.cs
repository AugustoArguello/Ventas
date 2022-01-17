using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Ventas1._0._0.SCS.vistas;

namespace Ventas1._0._0
{
    /// <summary>
    /// Lógica de interacción para ventanaUsuarios.xaml
    /// </summary>
    public partial class ventanaUsuarios : Window
    {
        public ventanaUsuarios()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataContext = new Proveedores();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            DataContext = new Clientes();
        }
    }
}
