using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InventarioApp
{
    public partial class FormPrincipal : Form
    {
        LoadJson jsonData = JsonConvert.DeserializeObject<LoadJson>(File.ReadAllText(@"C:\Users\Usuario\source\repos\InventarioApp\config.json"));

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnConsultar(object sender, EventArgs e)
        {
            string codigo = textBox1.Text;
            string query = "select producto, valor,descripcion from productos where codigo="+ codigo;
             // SqlConnection conexion = new SqlConnection("server=DESKTOP-1Q7HUQC; database=base1; integrated security = true");
             SqlConnection conexion = new SqlConnection(String.Format("server={0}; database={1}; integrated security = true",
                          jsonData.server, jsonData.db));
            conexion.Open();
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataReader registros = comando.ExecuteReader();

            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            if (registros.Read())
            {
                textBox2.Text= registros["producto"].ToString();
                textBox3.Text= registros["valor"].ToString();
                textBox4.Text= registros["descripcion"].ToString();
            }
            else
            {
                MessageBox.Show("No existe un producto con código: " + codigo);
            }
            conexion.Close();
        }

        private void BtnAgregar(object sender, EventArgs e)
        {
            int codigo = int.Parse(textBox1.Text);
            string producto = textBox2.Text;
            float valor = float.Parse(textBox3.Text);
            string descripcion = textBox4.Text;
            string query = "insert into productos(codigo, producto, valor, descripcion) values(" + codigo + ",'" + producto + "', " + valor + ", '" + descripcion + "')";
            SqlConnection conexion = new SqlConnection("server=DESKTOP-1Q7HUQC; database=base1; integrated security = true");
            SqlCommand comando = new SqlCommand(query, conexion);
            conexion.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            conexion.Close();
        }

        public void Limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void BtnLimpiar(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnEliminar(object sender, EventArgs e)
        {
            string codigo = textBox1.Text;
            string query = "delete from productos where codigo=" + codigo;
            SqlConnection conexion = new SqlConnection("server=DESKTOP-1Q7HUQC; database=base1; integrated security = true");
            SqlCommand comando = new SqlCommand(query, conexion);
            conexion.Open();            
            int cant = comando.ExecuteNonQuery();
            conexion.Close();
            if (cant==1)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                MessageBox.Show("El producto con código: " + codigo + " ha sido eliminado");
            }
            else
            {
                MessageBox.Show("No existe un producto con código: " + codigo);
            }
        }
    }
}
