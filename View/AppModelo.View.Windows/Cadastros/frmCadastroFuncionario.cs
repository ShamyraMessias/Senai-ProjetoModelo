using AppModelo.Controller.External;
using AppModelo.Model.Domain.Validators;
using AppModelo.View.Windows.Helpers;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmCadastroFuncionario : Form
    {
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            Componentes.FormatarCamposObrigatorios(this);
        }

        private void btnPesquisarCep_Click(object sender, System.EventArgs e)
        {
            //Crio a instancia do Controllador
            var cepController = new ViaCepController();

            //Recebo os dados do metodo obter para o endereço
            var endereco = cepController.Obter(txtEnderecoCep.Text);

            txtEnderecoBairro.Text = endereco.Bairro;
            txtEnderecoLogradouro.Text = endereco.Logradouro;
            txtEnderecoMunicipio.Text = endereco.Localidade;
            txtEnderecoUf.Text = endereco.Uf;
        }

        private void txtNome_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(txtNome.Text.Length < 6)
            {
                errorProvider.SetError(txtNome, "Digite seu nome completo");
                return;
            }
            
            foreach(var letra in txtNome.Text)
            {
                if(char.IsNumber(letra))
                {
                    errorProvider.SetError(txtNome, "Seu nome parece estar errado");
                    return;
                }
                errorProvider.Clear();
            }

        }

        private void txtCpf_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var cpf = txtCpf.Text;
            var cpfEhValido = Validadores.ValidarCPF(cpf);
           
            if(cpfEhValido is false)
            {
                errorProvider.SetError(txtCpf, "CPF Inválido");
                return;
            }
            errorProvider.Clear();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }


        // DATA DE NASCIMENTO
        DateTime.Now.AddDays(1);
    }
}
