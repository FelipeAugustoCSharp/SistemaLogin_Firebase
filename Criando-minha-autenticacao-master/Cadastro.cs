using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;

namespace Criando_minha_autenticacao
{
    public partial class Cadastro : Form
    {
        FirebaseAuth auth = FirebaseAuth.DefaultInstance;
        public Cadastro()
        {
            InitializeComponent();
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("auth.json")
            });
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            Hide();
            login.Closed += fecharFormulario;
            login.Show();

        }

        private void fecharFormulario(object? enviado, EventArgs args)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {      
            if(txtSenha.Text != txtConfirmar.Text)
            {
                MessageBox.Show("As senhas não batem, favor revisar");
                return;
            }
            if (txtSenha.Text.Length <= 8)
            {
                MessageBox.Show("Digite uma senha com no minimo 8");
                return;
            }
            try
            {
                var usuario = FirebaseAuth.DefaultInstance.CreateUserAsync(new UserRecordArgs()
                {
                    Email = txtEmail.Text,
                    Password = txtSenha.Text,
                }).Result;
                MessageBox.Show(usuario.Uid);
                MessageBox.Show(usuario.EmailVerified.ToString());

                Principal principal = new Principal();
                Hide();
                principal.Closed += fecharFormulario;
                principal.Show();
            }
            catch(Exception ex)
            {
                if (ex.Message.Contains("The user with the provided email already exists (EMAIL_EXISTS)"))
                {
                    MessageBox.Show("Já existe o e-mail cadastrado");
                }
                else
                {
                    //É extremamente importante que o sistema tenha logs
                    MessageBox.Show("Erro: " + ex.Message);
                    //Clipboard.SetText(ex.Message);
                }
            }
        }
    }
}
