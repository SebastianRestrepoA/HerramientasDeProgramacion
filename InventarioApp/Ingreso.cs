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

namespace InventarioApp
{
    public partial class InventarioApp : Form
    {
        public InventarioApp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("server=DESKTOP-1Q7HUQC; database=base1; integrated security = true");
            FormPrincipal principal;
            try
            {
                string query = "Select * from usuarios where (usuario = '"+textBox1.Text+"'  and  password= '"+textBox2.Text +"' ) ";
                SqlCommand comando = new SqlCommand(query, conn);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                // adaptador.SelectCommand = comando;
                DataTable Dt = new DataTable();
                adaptador.Fill(Dt);
                
                conn.Open();
                int i = comando.ExecuteNonQuery();
                conn.Close();

                if (Dt.Rows.Count > 0)
                {
                    MessageBox.Show("Se ha loggeado correctamente");
                    //after successful it will redirect  to next page.  
                    principal = new FormPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto.");
                }
            }
            catch (Exception error)
            {

                MessageBox.Show($"{error} ERROR", "MENSAJE DE ERROR", MessageBoxButtons.OK);
                conn.Close();
            }

        }
    }
}
