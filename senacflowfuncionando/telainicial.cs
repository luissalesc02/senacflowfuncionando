namespace senacflowfuncionando
{
    public partial class telainicial : Form
    {
        public telainicial()
        {
            InitializeComponent();
        }

        private void btnadministrador_Click(object sender, EventArgs e)
        {
            loginadmincadas telaadmin = new loginadmincadas();
            telaadmin.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mapasenac telamapa = new mapasenac();
            telamapa.Show();
            this.Hide();
        }
    }
}
