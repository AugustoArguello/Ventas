using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace Negocios
{
    public class capaNegocios
    {
        capaDatos con = new capaDatos();

        public int conexxion(string usu, string contra)
        {
            return con.consultalogin(usu, contra);
        }

        public DataTable grilla()
        {
            return con.tablagrid();
        }

        public void insert(string nom, string tel, string ubi, string mail, string prod, string cod)
        {
            con.insertar(nom, tel, ubi, mail, prod, cod);
        }

        public void mod(string nom, string tel, string ubi, string mail, string prod, string cod, string mod)
        {
            con.modificar(nom, tel, ubi, mail, prod, cod, mod);
        }

        public void deleted(string nom)
        {
            con.Borrar(nom);
        }
        //comandos para venatna Clientes//

        public DataTable Clientetab()
        {
            return con.tablaCliente();
        }

        public void insertcli(string nom, string apell, string tel, string cod)
        {
            con.insertarcliente(nom,apell, tel, cod);
        }

        public void modcli(string nom, string apell, string tel, string cod, string mod)
        {
            con.modificarcliente(nom, apell, tel, cod, mod);
        }

        public void deletedcli(string nom)
        {
            con.borrarcliente(nom);

        }

    }
}
