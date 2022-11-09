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
        public bool Cadastrar(string nome, DateTime dataNascimento, bool sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, string text, int nacionalidade, int naturalidade)
        {
            var repositorio = new FuncionariosRepository();
            var resposta = repositorio.Inserir(nome, dataNascimento, sexo, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, nacionalidade, naturalidade);
            return resposta;
        }

        public object Cadastrar(string text1, DateTime dataNascimento, bool @checked, string text2, string text3, string text4, string text5, string text6, int numero, string text7, string text8, string text9, string text10, int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}