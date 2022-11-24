using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Domain.Wrappers
{
    /// <summary>
    /// Validando a classe EntidadeBase e as mensagem de erro e sucesso no banco de dados.
    /// </summary>
    public abstract class EntidadeBase
    {
        public string Erro { get; set; }
        public bool Sucesso { get; set; }
    }
}
