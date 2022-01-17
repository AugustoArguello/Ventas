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
using System.Data;



namespace Ventas1._0._0.SCS.vistas
{
    /// <summary>
    /// Lógica de interacción para Proveedores.xaml
    /// </summary>
    public partial class Proveedores : UserControl
    {
        capaNegocios tab = new capaNegocios();
        public Proveedores()
        {
            DataTable latabla = new DataTable();
            InitializeComponent();
            latabla = tab.grilla();

            tbproveedores.ItemsSource = latabla.DefaultView;

        }

        private void btninssertar_Click(object sender, RoutedEventArgs e)
        {
            tab.insert(txtnomb.Text, txttel.Text, txtubi.Text, txtmail.Text, txtprod.Text, txtcod.Text);
            DataTable latabla = new DataTable();
            latabla = tab.grilla();
            tbproveedores.ItemsSource = latabla.DefaultView;

            txtnomb.Text = "";
            txttel.Text = "";
            txtubi.Text = "";
            txtmail.Text = "";
            txtprod.Text = "";
            txtcod.Text = "";
        }

        private void btnmod_Click(object sender, RoutedEventArgs e)
        {
            tab.mod(txtnomb.Text, txttel.Text, txtubi.Text, txtmail.Text, txtprod.Text, txtcod.Text, txtbuscar.Text);
            
            DataTable latabla = new DataTable();
            latabla = tab.grilla();
            tbproveedores.ItemsSource = latabla.DefaultView;

            txtnomb.Text = "";
            txttel.Text = "";
            txtubi.Text = "";
            txtmail.Text = "";
            txtprod.Text = "";
            txtcod.Text = "";
            txtbuscar.Text = "";
        }

        private void btnborrar_Click(object sender, RoutedEventArgs e)
        {
            tab.deleted(txtbuscar.Text);
            
            DataTable latabla = new DataTable();
            latabla = tab.grilla();
            tbproveedores.ItemsSource = latabla.DefaultView;

        }
    }
}
