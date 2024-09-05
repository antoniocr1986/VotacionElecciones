using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VotoElectronico
{
    public class Conexion
    {
        SqlConnection cconex = new SqlConnection();

        static string servidor = "localhost";
        static string bd = "VotacionElecciones";
        static string usuario = "sa";
        static string password = "12345678";
        static string puerto = "1433";

        private string connectionString = "Data Source=" + servidor + "," + puerto + ";" + "User ID=" + usuario + ";" + "Password=" + password + ";" + "Initial Catalog=" + bd + ";" + "Persist Security Info=true";

        public SqlConnection getConexion()
        {
            try
            {
                cconex.ConnectionString = connectionString;
                cconex.Open();
                MessageBox.Show("Se conecto correctamente a la Base de Datos");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se pudo realizar la conexion a la Base de Datos" + e.ToString());
            }
            return cconex;
        }

    }
}
