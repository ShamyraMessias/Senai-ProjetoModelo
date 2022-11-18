using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        public bool Atualizar(int id, string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Atualizar(id, descricao);
            return resposta;
        }
        public bool Cadastrar(string descricao, bool status)
        {
            var repositorio = new NaturalidadeRepository();

            var naturalidade = repositorio.ObterPorDescricao(descricao);
            if (naturalidade is not null) return false;

            var resposta = repositorio.Inserir(descricao, status);
            return resposta;
        }

        public List<NaturalidadeEntity> ObterTodasNaturalidade()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)resposta;
        }

        public bool Delete(string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Delete(descricao);
            return resposta;
        }
    }
}