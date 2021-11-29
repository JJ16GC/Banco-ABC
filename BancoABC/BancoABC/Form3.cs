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
    public partial class Form3 : Form
    {

        public static List<string> listahistorial2 = new List<string>();
        public Form3()
        {
            InitializeComponent();
            textUser.Text = Session.ncuenta;
    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textval_retirar.Text))
            {
                MessageBox.Show("Debe llenar los datos");
            }
            else
            {
                int valor = Convert.ToInt32(textval_retirar.Text);

                int valor2 = Convert.ToInt32(Session.saldo);
                int r = valor2 - valor;
                string g = "Se han retirado = " + valor + "$ " + "Su nuevo saldo es: " + (valor2 - valor);
                listahistorial2.Add(g);
                if (r < 0)
                {
                    MessageBox.Show("Saldo insuficiente");
                }
                else
                {
                    Convert.ToString(r);
                    MySqlConnection conexion = ConexionSQL.Conectar();
                    conexion.Open();
                    string sql = "UPDATE usuarios SET saldo = @saldo WHERE ncuenta = @ncuenta";
                    MySqlCommand command = new MySqlCommand(sql, conexion);
                    command.Parameters.AddWithValue("@saldo", r);
                    command.Parameters.AddWithValue("@ncuenta", textUser.Text);
                    command.ExecuteNonQuery();
                    conexion.Close();
                    Session.saldo = Convert.ToString(r);
                    Form2 f2 = new Form2();
                    f2.Visible = true;
                    this.Visible = false;
                }
            }
        
    }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
