using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            string stringDeConexao = "Server=localhost;Port=3306;User Id=root" +
                "; database=ti_113_windowsforms;";
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();
            string query = "insert into usuarios (Nome, Telefone) values (@nome, @telefone)";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@nome", user.Nome);
            cmd.Parameters.AddWithValue("@telefone", user.Telefone);
            int quantidade = cmd.ExecuteNonQuery();
            conexao.Close();
            if (quantidade == 0)
                return false;
            else
                return true;
        }

        public static List<Usuario> GetUsuario()
        {
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            string query = "select * from usuarios";
                        MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;

            MySqlDataReader sqlDataReader = cmd.ExecuteReader();

            List<Usuario> usuarios = new List<Usuario>();
            while (sqlDataReader.Read())
            {
                usuarios.Add(new Usuario
                {
                    Nome = sqlDataReader.GetString("Nome"),
                    Telefone = sqlDataReader.GetString("Telefone"),

                });
            }
            return usuarios;
        }


    }
}
