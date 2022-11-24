using System.Text.RegularExpressions;

namespace AppModelo.Model.Domain.Validators
{
    /// <summary>
    /// Instanciando a classe validadores e validando o  Email para o banco de dados.
    /// </summary>
    public static partial class Validadores
    {
        public static bool EmailEValido(string inputEmail)
        {
            var strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                           @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            var re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
    }
}
