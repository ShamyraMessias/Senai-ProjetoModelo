using AppModelo.Controller.Cadastros;
using System;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmNacionalidades : Form
    {
        private NacionalidadeController _nacionalidadeController = new NacionalidadeController();
        public frmNacionalidades()
        {
            InitializeComponent();

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var salvou = _nacionalidadeController.Cadastrar(txtDescricao.Text);
            if (salvou)
            {
                MessageBox.Show("Nacionalidade incluída com sucesso");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao salvar no banco de dados");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var control = new NacionalidadeController();
            var removeu = control.Delete(txtDescricao.Text);
            if ((bool)removeu)
            {
                MessageBox.Show("Nacionalidade excluída com sucesso!");
                txtDescricao.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Houve um erro ao excluir no banco de dados.");
            }
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Favor preencher o campo ID.");
            }
            
            else
            {
                var id = int.Parse(txtId.Text);
                var controller = new NacionalidadeController();
                var descricao = controller.Atualizar(id, txtDescricao.Text);
            }

            MessageBox.Show("Nacionalidades Atulizadas com sucesso");

            var listaDeNacionalidades = _nacionalidadeController.ObterTodasNacionalidades();
            gvNacionalidades.DataSource = listaDeNacionalidades;
        }
    }
}
