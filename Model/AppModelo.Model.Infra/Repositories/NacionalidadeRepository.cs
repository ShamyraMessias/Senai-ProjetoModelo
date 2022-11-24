using AppModelo.Model.Domain.Entities;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System;

namespace AppModelo.Model.Infra.Repositories
{
    public class NacionalidadeRepository
    {   
        //CRUD - create - read   - update - delete
        //       insert - select - update - delete  
      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns></returns>
        public bool Inserir(string descricao)
        {
            //string interpolation
            var sql = $"INSERT INTO nacionalidades (descricao) VALUES ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public bool Atualizar ( int id, string descricao) 
        {
            var sql = $"UPDATE nacionalidades SET descricao = ('{descricao}') WHERE id = ('{id}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public bool Delete(string descricao) 
        {
            var sql = $"DELETE FROM nacionalidades WHERE (descricao) = ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public IEnumerable<NacionalidadeEntity> ObterTodos()
        {
            var sql = "SELECT id, descricao FROM nacionalidades ORDER BY descricao DESC";
            
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            
            var resultado = conexaoBd.Query<NacionalidadeEntity>(sql);

            return resultado;
        }
        public NacionalidadeEntity ObterPorId() 
        {
            return new NacionalidadeEntity();
        }

      
    }
}
