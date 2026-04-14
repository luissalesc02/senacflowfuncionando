using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace senacflowfuncionando
{
    public partial class loginadmincadas : Form
    {
        public loginadmincadas()
        {
            InitializeComponent();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            a.loginadmin = txtadmin.Text;
            a.senhaadmin = hashhelper.gerarhash(txtsenhaamin.Text);

            adminrepository repo = new adminrepository();
            repo.inserir(a);


            MessageBox.Show("Usuário cadastrado com sucesso!");
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string login = txtadmin.Text;
            string senhaHash = hashhelper.gerarhash(txtsenhaamin.Text);
            adminrepository repo = new adminrepository();
            admin a = repo.obterporloginesenha(login, senhaHash);

            if (a != null)
            {
                MessageBox.Show($"Login bem-sucedido! Bem-vindo, {a.loginadmin}.");
                horario_limpeza telahoralimp = new horario_limpeza(a.loginadmin);
                telahoralimp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
        }

        private void loginadmincadas_Load(object sender, EventArgs e)
        {

        }

        private void btnsenha_Click(object sender, EventArgs e)
        {
            if (txtsenhaamin.PasswordChar == '*')
            {
                txtsenhaamin.PasswordChar = '\0'; 
                btnsenha.Text = "Ocultar";
            }
            else
            {
                txtsenhaamin.PasswordChar = '*'; 
                btnsenha.Text = "Mostrar";
            }
        }
    }
}
