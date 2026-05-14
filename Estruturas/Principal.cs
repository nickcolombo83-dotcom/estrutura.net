namespace Estruturas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            string usuario = "admin";
            string senha = "Tente123@";

            if (usuario == txtUsuario.Text & senha == txtSenha.Text)
            {
                frmCadastro cadastro = new frmCadastro();
                cadastro.FormBorderStyle = FormBorderStyle.None;
                cadastro.Bounds = Screen.PrimaryScreen.Bounds;
                cadastro.TopMost = true;
                cadastro.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!!", "Verificação",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
                );
                txtUsuario.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();
            txtUsuario.Focus();
        }        
    }
}
