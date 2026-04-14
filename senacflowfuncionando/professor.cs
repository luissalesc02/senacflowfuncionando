using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senacflowfuncionando
{
    public class Professors
    {
        private ConexaoBD conexao = new ConexaoBD();

        // Inserir professor
        public void Inserir(Professor p)
        {
            var conn = conexao.AbrirConexao();
            string query = "INSERT INTO Professor (nome_completo, id_disciplina) VALUES (@nome, @disc)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome", p.NomeCompleto);
            cmd.Parameters.AddWithValue("@disc", p.IdDisciplina);
            cmd.ExecuteNonQuery();
            conexao.FecharConexao(conn);
        }

        // Excluir professor
        public void Excluir(int id)
        {
            var conn = conexao.AbrirConexao();
            string query = "DELETE FROM Professor WHERE id_professor=@id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conexao.FecharConexao(conn);
        }

        // Listar professores
        public DataTable Listar()
        {
            var conn = conexao.AbrirConexao();
            string query = @"SELECT p.id_professor, p.nome_completo, d.nome_disciplina 
                         FROM Professor p
                         JOIN Disciplina d ON p.id_disciplina = d.id_disciplina";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexao.FecharConexao(conn);
            return dt;
        }
    }
}
