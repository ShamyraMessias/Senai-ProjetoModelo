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
        public bool btnSalvar(int id, string nome, DateTime data_de_nascimento, bool sexo, string cpf, int id_nacionalidade, int id_naturalidade, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio);
        {

            var repositorio = new NacionalidadeEntity();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
           
        }
    }
}
