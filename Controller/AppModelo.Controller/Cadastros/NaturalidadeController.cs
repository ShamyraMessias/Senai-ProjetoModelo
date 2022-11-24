using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        /// <summary>
        /// Instanciando o método NaturalidadeRepository, para obter as Nacionalidades atualizadas quando desejar.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="descricao"></param>
        /// <returns>atualiza uma tabela naturalidade no repositório</returns>
        public bool Atualizar(int id, string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Atualizar(id, descricao);
            return resposta;
        }
        /// <summary>
        /// Instanciando o método NaturalidadeRepository, para criar uma nova Naturalidade.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns>Criação de uma nova NATURALIDADE no banco de dados</returns>
        public bool Cadastrar(string descricao, bool status)
        {
            var repositorio = new NaturalidadeRepository();

            var naturalidade = repositorio.ObterPorDescricao(descricao);
            if (naturalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao, status);
            return resposta;
        }
        /// <summary>
        /// Instanciando o método NacionalidadeRespository,para obter as Naturalidades.
        /// </summary>
        /// <returns>lista de todas as Naturalidades cadastrada no repository</returns>
        public List<NaturalidadeEntity> ObterTodasNaturalidade()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)resposta;
        }
        /// <summary>
        /// Instanciando o método NaturalidadeRespository, para deletar as Naturalidades desejada.
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns>retorna um repositório com a naturalidade excluída.</returns>
        public bool Delete(string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Delete(descricao);
            return resposta;
        }
    }
}