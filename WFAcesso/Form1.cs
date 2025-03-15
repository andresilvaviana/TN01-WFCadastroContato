using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WFAcesso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormLogin_Load();
           
        }

        private void FormLogin_Load()
        {
            Usuario
            
            us = new Usuario();
            us.Codigo = 1;
            us.Login = "admin";
            us.Senha = "admin";
            us.DataCadastro = Convert.ToDateTime("01/01/2000");
            Usuario.ListaUsuario.Add(us);

            us = new Usuario();
            us.Codigo = 2;
            us.Login = "user";
            us.Senha = "user";
            us.DataCadastro = Convert.ToDateTime("01/01/2010");
            Usuario.ListaUsuario.Add(us);

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            foreach (Usuario us in Usuario.ListaUsuario)
            {
                if (us.Login == txt_usuario.Text)
                {
                    if (us.Senha == txt_senha.Text)
                    {
                        MessageBox.Show(
                            "Usuario Autenticado com Sucesso!",
                            "Sucesso!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );
                        return;
                    }
                }

            }

            MessageBox.Show("Usuario Não Autenticado!",
                            "Erro!", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            return;
        }

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_senha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogar_Click(sender, e);
            }
        }
    }
}
