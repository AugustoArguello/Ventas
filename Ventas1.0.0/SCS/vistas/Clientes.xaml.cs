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
    /// Lógica de interacción para Clientes.xaml
    /// </summary>
    public partial class Clientes : UserControl
    {
        capaNegocios clien = new capaNegocios();
        public Clientes()
        {
            InitializeComponent();
           
            DataTable latabla = new DataTable();
            InitializeComponent();
            latabla = clien.Clientetab();
            tbproveedores.DisplayMemberPath = "info";
            tbproveedores.SelectedValuePath = "Codcliente";
            tbproveedores.ItemsSource = latabla.DefaultView;

        }

        private void btnmod_Click(object sender, RoutedEventArgs e)
        {
            clien.modcli(txtnomb.Text, txtapellido.Text, txttelefono.Text, txtcodigopost.Text, txtbuscar.Text);

            DataTable latabla = new DataTable();
            latabla = clien.Clientetab();
            tbproveedores.ItemsSource = latabla.DefaultView;

            txtnomb.Text = "";
            txtapellido.Text = "";
            txttelefono.Text = "";
            txtcodigopost.Text = "";
            txtbuscar.Text = "";
        }

        private void btninssertar_Click(object sender, RoutedEventArgs e)
        {
            clien.insertcli(txtnomb.Text, txtapellido.Text, txttelefono.Text, txtcodigopost.Text);
            DataTable latabla = new DataTable();
            latabla = clien.Clientetab();
            tbproveedores.ItemsSource = latabla.DefaultView;

            txtnomb.Text = "";
            txtapellido.Text = "";
            txttelefono.Text = "";
            txtcodigopost.Text = "";
           
        }

        private void btnborrar_Click(object sender, RoutedEventArgs e)
        {
            clien.deletedcli(txtbuscar.Text);

            DataTable latabla = new DataTable();
            latabla = clien.Clientetab();
            tbproveedores.ItemsSource = latabla.DefaultView;

        }
    }
}
