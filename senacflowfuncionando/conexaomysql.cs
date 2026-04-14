using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace senacflowfuncionando
{
    public class ConexaoBD
    {
        private string connectionString = "server=localhost;database=senacflow;user=root;password=;";

        public MySqlConnection AbrirConexao()
        {
            var conn = new MySqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public void FecharConexao(MySqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
