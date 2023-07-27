using Firebase.Auth;
using Firebase.Auth.Providers;
using Firebase.Auth.Repository;

namespace Criando_minha_autenticacao
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            var config = new FirebaseAuthConfig
            {
                ApiKey = "SUA KEY",

                AuthDomain = "SEU FIREBASE",
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()
                },
                UserRepository = new FileUserRepository("NossosDados")
            };
            var cliente = new FirebaseAuthClient(config);
            cliente.SignOut();
            Login login = new Login();
            Hide();
            login.Closed += fecharFormulario;
            login.Show();
        }
        private void fecharFormulario(object? enviado, EventArgs args)
        {
            Close();
        }
    }
}
