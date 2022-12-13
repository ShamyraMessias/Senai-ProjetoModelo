using AppModelo.Controller.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppModelo.View.Windows.Cadastros
{
    public partial class frmListadeFuncionarios : Form
    {
        private FuncionarioController _funcionarioController = new FuncionarioController();

        public frmListadeFuncionarios()
        {
            InitializeComponent();

            FuncionarioController _controller = new FuncionarioController();
            var listaDeFuncionarios = _controller.ObterTodosFuncionarios();


        }

        private void frmListadeFuncionarios_Load(object sender, EventArgs e)
        {

        }
    }
}
