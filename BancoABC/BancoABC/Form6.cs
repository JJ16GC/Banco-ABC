using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoABC
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            textNombre.Text = Session.ncuenta;
            List<string> lista = new List<string>();

            List<string> lista1 = Form4.listahistorial;
            foreach (var item in lista1)
            {
                lista.Add(item);
            }

            List<string> lista2 = Form3.listahistorial2;
            foreach (var item in lista2)
            {
                lista.Add(item);
            }
            List<string> lista3 = Form5.listahistorial3;
            foreach (var item in lista3)
            {
                lista.Add(item);
            }
            listamonto.DataSource = null;
            listamonto.DataSource = lista;
        }

        private void listamonto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public List<string> guardar(String monto)
        {
            List<string> listahistorial = new List<string>();

            listahistorial.Add(monto);
            listamonto.DataSource = null;
            listamonto.DataSource = listahistorial;


            return listahistorial;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Visible = true;
        }
    }
}
