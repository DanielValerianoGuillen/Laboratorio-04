using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Persona : Form
    {
        SqlConnection conn;

        public Persona(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }
        private void Persona_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    String sql = "SELECT * FROM Person";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvListado.DataSource = dt;
                    dgvListado.Refresh();
                }
                else
                {
                    MessageBox.Show("La conexion esta cerrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor: \n" +
                    ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    String FirstName = txtNombre.Text;

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "BuscarPersonaNombre";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;

                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@FirstName";
                    param.SqlDbType= SqlDbType.NVarChar;
                    param.Value = FirstName;

                    cmd.Parameters.Add(param);

                    SqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvListado.DataSource= dt;
                    dgvListado.Refresh();
                }
                else
                {
                    MessageBox.Show("La conexion esta cerrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del servidor: \n" +
                    ex.ToString());
            }
        }
    }
}
