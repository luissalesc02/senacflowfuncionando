using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senacflowfuncionando
{
    public class Disciplinas
    {
        private ConexaoBD conexao = new ConexaoBD();

        // Inserir disciplina
        public void Inserir(Disciplina d)
        {
            var conn = conexao.AbrirConexao();
            string query = "INSERT INTO Disciplina (nome_disciplina) VALUES (@nome)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome", d.NomeDisciplina);
            cmd.ExecuteNonQuery();
            conexao.FecharConexao(conn);
        }

        
        public void Excluir(int id)
        {
            var conn = conexao.AbrirConexao();
            string query = "DELETE FROM Disciplina WHERE id_disciplina=@id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conexao.FecharConexao(conn);
        }

       
        public DataTable Listar()
        {
            var conn = conexao.AbrirConexao();
            string query = "SELECT id_disciplina, nome_disciplina FROM Disciplina";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexao.FecharConexao(conn);
            return dt;
        }

        
        public int ObterUltimoId()
        {
            var conn = conexao.AbrirConexao();
            string query = "SELECT LAST_INSERT_ID()";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.FecharConexao(conn);
            return id;
        }
    }
}
