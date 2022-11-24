using AppModelo.Model.Domain.Wrappers;
using AppModelo.Model.Infra.Services;

namespace AppModelo.Controller.External
{
    public class ViaCepController
    {
        //Retorna a classe ViaCepWrapper , instancia o método ViaCepService para obter o CEP.
        public ViaCepWrapper Obter(string cep)
        {
            var service = new ViaCepService();

            var viaCep = service.ObterDaApi(cep);
           
            return viaCep;
        }
    }
}
