using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    /// <summary>
    /// instanciando o método UsuarioRepository, para obter ousuário e a senha no banco de dados.
    /// </summary>
    public class UsuarioRepository
    {
        public UsuarioEntity Obter(string usuario, string senha)
        {
            var sql = $"SELECT email, senha FROM usuarios " +
                $"WHERE email = '{usuario}' AND senha = '{senha}';";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);


            return resultado;

        }
        /// <summary>
        /// instanciando o método UsuarioEntity, para obter o email no banco de dados.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public UsuarioEntity ObterPorEmail(string email)
        {
            var sql = $"SELECT email, nome FROM usuarios WHERE email = '{email}'";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.QuerySingleOrDefault<UsuarioEntity>(sql);

            return resultado;

        }

        /// <summary>
        /// instanciando a classe AtualizarSenha, para atualizar uma nova senha no banco de dados.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="novaSenha"></param>
        /// <returns></returns>
        public bool AtualizarSenha(string email, string novaSenha)
{
            var sql = $"UPDATE usuarios " +
                      $"SET senha = '{novaSenha}' " +
                      $"WHERE email = '{email}'; ";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
    }
}
