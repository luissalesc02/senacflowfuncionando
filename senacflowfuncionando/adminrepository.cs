using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace senacflowfuncionando
{
    public class adminrepository
    {
        public void inserir(admin admin)
        {
            ConexaoBD conexao = new ConexaoBD();
            using (var conn = conexao.AbrirConexao())
            {
                string sql = "INSERT INTO admin(loginadmin, senhaadmin) VALUES(@loginadmin, @senhaadmin)";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@loginadmin", admin.loginadmin);
                    cmd.Parameters.AddWithValue("@senhaadmin", hashhelper.gerarhash(admin.senhaadmin));

                    cmd.ExecuteNonQuery();
                }
                conexao.FecharConexao(conn);
            }
        }

        public admin obterporloginesenha(string loginadmin, string senhaadmin)
        {
            ConexaoBD conexao = new ConexaoBD();
            using (var conn = conexao.AbrirConexao())
            {
                string sql = @"SELECT id_admin, loginadmin 
                               FROM admin
                               WHERE loginadmin = @loginadmin AND senhaadmin = @senhaadmin";
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@loginadmin", loginadmin);
                    cmd.Parameters.AddWithValue("@senhaadmin", hashhelper.gerarhash(senhaadmin));

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new admin
                            {
                                id = reader.GetInt32("id_admin"),
                                loginadmin = reader.GetString("loginadmin")
                            };
                        }
                    }
                }
                conexao.FecharConexao(conn);
            }
            return null;
        }
    }
}
