using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    public class FuncionariosRepository
    {
        public bool Inserir(string nome, DateTime data_nascimento, bool sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidades, int naturalidade)
        {
            var dataConvertida = data_nascimento.ToString("yyyy-MM-dd");

            var sql = $"INSERT INTO funcionarios (nome, data_nascimento, sexo, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf,nacionalidades, naturalidade) VALUES ('{nome}', '{dataConvertida}', {sexo}, '{email}', '{telefone}', '{telefone_contato}', '{cep}', '{logradouro}', {numero}, '{complemento}', '{bairro}', '{municipio}', '{uf}', {nacionalidades}, {naturalidade})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }

    }
}
