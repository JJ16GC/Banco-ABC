using MySql.Data.MySqlClient;
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
    public partial class Form4 : Form
    {

        public static List<string> listahistorial = new List<string>();
        public Form4()
        {
            InitializeComponent();
            texUser.Text = Session.ncuenta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(textVal_Depositar.Text);
            int valor2 = Convert.ToInt32(Session.saldo);
            int r = valor2 + valor;
            string g = "Se han depositado = " + valor + "$ " + "Su nuevo saldo es: " + (valor2 + valor);
            listahistorial.Add(g);
            Convert.ToString(r);
            MySqlConnection conexion = ConexionSQL.Conectar();
            conexion.Open();
            string sql = "UPDATE usuarios SET saldo = @saldo WHERE ncuenta = @ncuenta";
            MySqlCommand command = new MySqlCommand(sql, conexion);
            command.Parameters.AddWithValue("@saldo", r);
            command.Parameters.AddWithValue("@ncuenta", texUser.Text);
            command.ExecuteNonQuery();
            conexion.Close();

            Session.saldo = Convert.ToString(r);
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Visible = true;
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textval_retirar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
