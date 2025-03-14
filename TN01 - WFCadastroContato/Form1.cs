namespace TN01___WFCadastroContato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCadastro form = new FormCadastro();
            form.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mnu_sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Cadastro de Contatos\nVersão 1.0\nDesenvolvido por: ASV.Cia",
                "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnu_listagem_Click(object sender, EventArgs e)
        {
            FormListagem form = new FormListagem();
            form.ShowDialog();
        }

        private void mnu_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
