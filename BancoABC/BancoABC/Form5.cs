using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BancoABC
{
    public partial class Form5 : Form
    {

        public static List<string> listahistorial3 = new List<string>();
        public Form5()
        {
            InitializeComponent();
            textActual.Text = Session.ncuenta;

            cmbcuenta.DataSource = null;
            string sql = "SELECT idusuarios,ncuenta FROM usuarios WHERE ncuenta != " + textActual.Text + " ORDER BY ncuenta ASC ";
            MySqlConnection conexion = ConexionSQL.Conectar();
            conexion.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conexion);
                MySqlDataAdapter data = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();
                data.Fill(dt);

                cmbcuenta.ValueMember = "idusuarios";
                cmbcuenta.DisplayMember = "ncuenta";
                cmbcuenta.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conexion.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RESTA TRANSFERENCIA

            
            int rvalor1 = Convert.ToInt32(txtcantidad.Text);
            int rvalor2 = Convert.ToInt32(Session.saldo);
            int r = rvalor2 - rvalor1;

            if (r < 0)
            {
                MessageBox.Show("SALDO INSUFICIENTE");
            }
            Convert.ToString(r);
            MySqlConnection conexion = ConexionSQL.Conectar();
            string sql = "UPDATE usuarios SET saldo = @saldo1 WHERE ncuenta = @ncuenta1";
            conexion.Open();
            MySqlCommand command = new MySqlCommand(sql, conexion);
            command.Parameters.AddWithValue("@saldo1", r);
            command.Parameters.AddWithValue("@ncuenta1", textActual.Text);
            command.ExecuteNonQuery();
            //SUMA TRANSFERENCIA

            string sql3 = "SELECT saldo FROM usuarios WHERE ncuenta =" + cmbcuenta.Text;
            MySqlCommand command3 = new MySqlCommand(sql3, conexion);
            int svalor2 = Convert.ToInt32(command3.ExecuteScalar());
            string sql2 = "UPDATE usuarios SET saldo = @saldo2 WHERE ncuenta = " + cmbcuenta.Text;
            MySqlCommand command2 = new MySqlCommand(sql2, conexion);
            int svalor1 = Convert.ToInt32(txtcantidad.Text);
            int r2 = svalor2 + svalor1;
            command2.Parameters.AddWithValue("@saldo2", r2);
            command2.ExecuteNonQuery();

            string g = "Se han transferido = " + rvalor1 + " $ a " + cmbcuenta.Text;
            listahistorial3.Add(g);

            Convert.ToString(r);
            conexion.Close();

            Session.saldo = Convert.ToString(r);
            this.Visible = false;
            Form2 f2 = new Form2();
            f2.Visible = true;
        }
    }
}
