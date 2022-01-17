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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Negocios;

namespace Ventas1._0._0
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        capaNegocios conect = new capaNegocios();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (conect.conexxion(txtusuario.Text, txtcontraseña.Text) == 1)
            {
                //MessageBox.Show("El usuario ha sido encontrado");
                this.Hide();
                ventanaUsuarios v1 = new ventanaUsuarios();
                v1.Show();

            }
            else
            {
                MessageBox.Show("El usuario o contraseña no es correcta");
            }
        }
    }
}
