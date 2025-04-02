using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Prova_Prática___Windows_Forms
{
    public static class Database
    {
        private static readonly string stringDeConexao = "Server=localhost;Port=3306;User Id=root" +
                "; database=ti_113_windowsforms;";

        public static bool SalvarUsuario(Usuario user)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                if (VerificarUsuarioExistente(user.Telefone))
                {
                    return false; 
                }

                string query = "INSERT INTO usuarios (Nome, Telefone) VALUES (@nome, @telefone)";
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", user.Nome);
                    cmd.Parameters.AddWithValue("@telefone", user.Telefone);

                    int quantidade = cmd.ExecuteNonQuery();
                    return quantidade > 0;
                }
            }
        }

        public static bool VerificarUsuarioExistente(string telefone)
        {
            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string query = "SELECT COUNT(*) FROM usuarios WHERE Telefone = @telefone";
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
              
                    cmd.Parameters.AddWithValue("@telefone", telefone);

                    int existe = Convert.ToInt32(cmd.ExecuteScalar());
                    return existe > 0;
                }
            }
        }

        public static List<Usuario> GetUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (MySqlConnection conexao = new MySqlConnection(stringDeConexao))
            {
                conexao.Open();

                string query = "SELECT * FROM usuarios";
                using (MySqlCommand cmd = new MySqlCommand(query, conexao))
                {
                    using (MySqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            usuarios.Add(new Usuario
                            {
                                Nome = sqlDataReader.GetString("Nome"),
                                Telefone = sqlDataReader.GetString("Telefone"),
                            });
                        }
                    }
                }
            }

            return usuarios;
        }
    }
}