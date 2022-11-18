using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NacionalidadeController
    {
        public bool Atualizar(int id, string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(id, descricao);
            return resposta;
        }

        public static object Remover(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Delete(descricao);
            return resposta; ;
        }

        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }

        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }

        public object Delete(string text)
        {
            throw new NotImplementedException();
        }
    }
}
