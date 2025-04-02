using System.Security.Cryptography.X509Certificates;

namespace Prova_Prática___Windows_Forms
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
            AtualizarLista();
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            Usuario novoUsuario = new Usuario()
            {
                Nome = txtNome.Text,
                Telefone = txtTelefone.Text
            };

            
            bool telefoneExiste = Database.VerificarUsuarioExistente(novoUsuario.Telefone);
            if (telefoneExiste)
            {
                MessageBox.Show("O telefone informado já está cadastrado.");
                return; 
            }

            
            bool sucesso = Database.SalvarUsuario(novoUsuario);
            if (sucesso)
            {
                MessageBox.Show("Usuário salvo com sucesso!");
                LimparCampos();
                AtualizarLista();
            }
            else
            {
                MessageBox.Show("Erro ao salvar o usuário.");
            }
        }

        public void AtualizarLista()
        {
            Lista.Items.Clear();
            List<Usuario> usuarios = Database.GetUsuario();
            foreach (Usuario usuario in usuarios)
            {
                ListViewItem registro = new ListViewItem(usuario.Nome);
                registro.SubItems.Add(usuario.Telefone);
                Lista.Items.Add(registro);
            }
        }
    }
}