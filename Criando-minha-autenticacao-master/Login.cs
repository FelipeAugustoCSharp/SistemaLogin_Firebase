namespace Criando_minha_autenticacao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            Hide();
            cadastro.Closed += fecharFormulario;
            cadastro.Show();

        }
        private void fecharFormulario(object? enviado, EventArgs args)
        {
            Close();
        }
    }
}