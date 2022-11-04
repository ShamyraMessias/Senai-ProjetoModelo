using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Entities
{
    public class FuncionarioEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string data_de_nascimento { get; set; }
        public bool Sexo { get; set; }
        public string cpf { get; set; }
        public int id_nacionalidade { get; set; }
        public int id_naturalidade { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string telefone_contato { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string uf { get; set; }

    }
}
