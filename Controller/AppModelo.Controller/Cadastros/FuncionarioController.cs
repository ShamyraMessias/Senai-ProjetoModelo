using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Controller.Cadastros
{
    public class FuncionarioController
    {
        /// <summary>
        /// Instanciando o método funcionárioRespository e puxando todos os parametros.
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="dataNascimento"></param>
        /// <param name="sexo"></param>
        /// <param name="email"></param>
        /// <param name="telefone"></param>
        /// <param name="telefone_contato"></param>
        /// <param name="cep"></param>
        /// <param name="logradouro"></param>
        /// <param name="numero"></param>
        /// <param name="complemento"></param>
        /// <param name="bairro"></param>
        /// <param name="municipio"></param>
        /// <param name="uf"></param>
        /// <param name="nacionalidades"></param>
        /// <param name="naturalidade"></param>
        /// <returns>lista de todos os parametros cadastrados</returns>
        public bool Cadastrar(string nome, DateTime dataNascimento, bool sexo, string cpf, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidades, int naturalidade)
        {
            if (Cadastrar != null)
            {
                var repositorio = new FuncionariosRepository();
                var resposta = repositorio.Inserir(nome, dataNascimento, sexo, cpf, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, nacionalidades, naturalidade);
                return resposta;
            }
            throw new NotImplementedException();

        }

        public List<FuncionariosEntity> ObterTodosFuncionarios()
        {
            var repositorio = new FuncionariosRepository();
            var resposta = repositorio.ObterTodos();
            return (List<FuncionariosEntity>)resposta;
        }
    }
}