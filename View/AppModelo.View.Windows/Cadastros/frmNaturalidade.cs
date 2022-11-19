using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNaturalidade : Form
    {
        private NaturalidadeController _naturalidadeController = new NaturalidadeController();
        public frmNaturalidade()
        {
            InitializeComponent();
            
            var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidade();
            gvNaturalidade.DataSource = listaDeNaturalidade;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var temNumero =
                Helpers.Componentes.ExisteNumeroNoTexto(txtDescricao.Text);

            if (temNumero)
            {
                errorProvider1.SetError(txtDescricao,
                    "Naturalidades geralmente não tem número");
                txtDescricao.Focus();
                return;
            }

            var controller = new NaturalidadeController();
            var descricaoMaiuscula = txtDescricao.Text.ToUpper();

            var resposta = controller.Cadastrar(descricaoMaiuscula, chkStatus.Checked);

            var dataSource = controller.ObterTodasNaturalidade();
            gvNaturalidade.DataSource = dataSource;

        }

        private void frmNaturalidade_Load(object sender, EventArgs e)
        {
            var controller = new NaturalidadeController();
            var dataSource = controller.ObterTodasNaturalidade();
            gvNaturalidade.DataSource = dataSource;

        }



        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Favor preencher o campo ID.");
            }
            
            else
            {
                var id = int.Parse(txtId.Text);
                var controller = new NaturalidadeController();
                var descricao = controller.Atualizar(id, txtDescricao.Text);
            }
            MessageBox.Show("Nacionalidades Atulizadas com sucesso");

            var listaDeNaturalidade = _naturalidadeController.ObterTodasNaturalidade();
            gvNaturalidade.DataSource = listaDeNaturalidade;

        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            var control = new NaturalidadeController();
            var removeu = control.Delete(txtDescricao.Text);
            if (removeu)
            {
                MessageBox.Show("Naturalidade excluída com sucesso!");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao excluir no banco de dados.");
            }
        }
    }
}
