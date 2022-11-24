using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        /// <summary>
        /// Instanciando o método NacionalidadeRepository, para obter as Nacionalidades atualizadas quando desejar.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns>atualiza uma tabela nacionalidade no repositório</returns>
        public bool Atualizar(int id, string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(id, descricao);
            return resposta;
        }

        /// <summary>
        /// Instanciando o método NacionalidadeRespository, para criar uma nova Nacionalidade.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>Criação de uma nova NACIONALIDADE no banco de dados </returns>
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }
        /// <summary>
        /// Instanciando o método NacionalidadeRespository,para obter as Nacionalidades.
        /// </summary>
        /// <returns>lista de todas as Nacionalidades cadastrada no repository</returns>
        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }
        /// <summary>
        /// Instanciando o método NacionalidadeRespository, para deletar as Nacionalidades desejada.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>retorna um repositório com a nacionalidade excluída.</returns>
        public object Delete(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Delete(descricao);
            return resposta; 
        }
    }
}
