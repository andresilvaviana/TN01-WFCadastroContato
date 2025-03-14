using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01___WFCadastroContato
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        public void limparformulario()
        {
            txt_nome.Clear();
            txt_sobrenome.Clear();
            msk_dddtelefone.Clear();
            rdb_pessoal.Checked = false;
            rdb_comercial.Checked = false;
            rdb_recado.Checked = false;
            txt_email.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_salva_Click(object sender, EventArgs e)
        {
            string nome;
            if (txt_nome.Text == "")
            {
                MessageBox.Show("Nome não informado");
                return;
            }
            else
            {
                nome = txt_nome.Text;
            }

            string sobrenome;
            if (txt_sobrenome.Text == "")
            {
                MessageBox.Show("Sobrenome não informado");
                return;
            }
            else
            {
                sobrenome = txt_sobrenome.Text;
            }

            string telefone;
            if (msk_dddtelefone.Text == "")
            {
                MessageBox.Show("telefone não informado");
                return;
            }
            else
            {
                telefone = msk_dddtelefone.Text;
            }

            string email;
            if (txt_email.Text == "")
            {
                MessageBox.Show("email não informado");
                return;
            }
            else
            {
                email = txt_email.Text;
            }

            ETipoTelefone tipotelefone;

            if (rdb_pessoal.Checked)
            {
                tipotelefone = ETipoTelefone.Pessoal;
            }
            else if (rdb_comercial.Checked)
            {
                tipotelefone = ETipoTelefone.Comercial;
            }
            else if (rdb_recado.Checked)
            {
                tipotelefone = ETipoTelefone.Recado;
            }
            else
            {
                MessageBox.Show("Selecione um tipo de telefone");
                return;
            }
            
            string mensagem = "Cadastro realizado com sucesso!" + "\n" + "Nome:" + nome + "\n" +
                "Sobrenome: " + sobrenome + "\n" +
                "Telefone: " + telefone + "\n" +
                "Tipo de Telefone: " + tipotelefone + "\n" +
                "Email: " + email + "\n";

            Contato c1 = new Contato();
            c1.Nome = nome;
            c1.Sobrenome = sobrenome;
            c1.Email = email;
            c1.Codigo = 0;
            c1.TipoTelefone = tipotelefone;
            c1.DDD = msk_dddtelefone.Text.Substring(0, 2);
            c1.Telefone = msk_dddtelefone.Text.Substring(3);

            Contato.ListaContatos.Add(c1);


            MessageBox.Show( mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            limparformulario();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
