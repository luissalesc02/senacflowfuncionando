using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senacflowfuncionando
{
    public class HorarioDAO
    {
        private ConexaoBD conexao = new ConexaoBD();

        public void Inserir(Horario h)
        {
            var conn = conexao.AbrirConexao();
            string query = @"INSERT INTO Horario 
                         (id_professor, id_sala, data_atual, hora_inicio, hora_termino) 
                         VALUES (@prof, @sala, @data, @inicio, @termino)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@prof", h.IdProfessor);
            cmd.Parameters.AddWithValue("@sala", h.IdSala);
            cmd.Parameters.AddWithValue("@data", h.DataAtual);
            cmd.Parameters.AddWithValue("@inicio", h.HoraInicio);
            cmd.Parameters.AddWithValue("@termino", h.HoraTermino);
            cmd.ExecuteNonQuery();
            conexao.FecharConexao(conn);
        }

        public void Editar(Horario h)
        {
            var conn = conexao.AbrirConexao();
            string query = @"UPDATE Horario 
                         SET id_professor=@prof, id_sala=@sala, data_atual=@data, 
                             hora_inicio=@inicio, hora_termino=@termino 
                         WHERE id_horario=@id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@prof", h.IdProfessor);
            cmd.Parameters.AddWithValue("@sala", h.IdSala);
            cmd.Parameters.AddWithValue("@data", h.DataAtual);
            cmd.Parameters.AddWithValue("@inicio", h.HoraInicio);
            cmd.Parameters.AddWithValue("@termino", h.HoraTermino);
            cmd.Parameters.AddWithValue("@id", h.IdHorario);
            cmd.ExecuteNonQuery();
            conexao.FecharConexao(conn);
        }

        public void Excluir(int id)
        {
            var conn = conexao.AbrirConexao();
            string query = "DELETE FROM Horario WHERE id_horario=@id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            conexao.FecharConexao(conn);
        }

        public DataTable Listar()
        {
            var conn = conexao.AbrirConexao();
            string query = @"SELECT h.id_horario, 
                                p.nome_completo AS Professor, 
                                d.nome_disciplina AS Disciplina,
                                s.nome_codigo AS Sala, 
                                s.id_andar AS Andar,
                                h.data_atual, 
                                h.hora_inicio, 
                                h.hora_termino
                         FROM Horario h
                         JOIN Professor p ON h.id_professor = p.id_professor
                         JOIN Disciplina d ON p.id_disciplina = d.id_disciplina
                         JOIN Sala s ON h.id_sala = s.id_sala";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexao.FecharConexao(conn);
            return dt;
        }
        
    }
}
