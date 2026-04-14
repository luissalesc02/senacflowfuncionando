using Microsoft.VisualBasic.Logging;
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
    public partial class cadastroprofessordisciplina : Form
    {
        private string usuarioLogado;
        public cadastroprofessordisciplina(string login)
        {
            usuarioLogado = login;
            InitializeComponent();
        }

        private void btncadastra_Click(object sender, EventArgs e)
        {
            Professor p = new Professor();
            p.NomeCompleto = txtNomeProfessor.Text;
            p.IdDisciplina = Convert.ToInt32(cmbDisciplina.SelectedValue);

            Professors dao = new Professors();
            dao.Inserir(p);

            MessageBox.Show("Professor cadastrado com sucesso!");



        }

        private void cadastroprofessordisciplina_Load(object sender, EventArgs e)
        {
            Disciplinas disc = new Disciplinas();
            cmbDisciplina.DataSource = disc.Listar();
            cmbDisciplina.DisplayMember = "nome_disciplina";
            cmbDisciplina.ValueMember = "id_disciplina";
            Professors dao = new Professors();
            dgvProfessores.DataSource = dao.Listar();


            dgvProfessores.Columns["id_professor"].HeaderText = "ID";
            dgvProfessores.Columns["nome_completo"].HeaderText = "Professor";
            dgvProfessores.Columns["nome_disciplina"].HeaderText = "Disciplina";


        }

        private void btndisc_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            horario_limpeza telahoralimpeza = new horario_limpeza(usuarioLogado);
            telahoralimpeza.Show();
            this.Hide();
        }

        private void btnexluirprof_Click(object sender, EventArgs e)
        {

        }

        private void dgvProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnexluirprof_Click_1(object sender, EventArgs e)
        {

        }

        private void btnexluirprof_Click_2(object sender, EventArgs e)
        {

        }

        private void btnexluirp_Click(object sender, EventArgs e)
        {
            if (dgvProfessores.SelectedRows.Count > 0)
            {
                
                int id = Convert.ToInt32(dgvProfessores.SelectedRows[0].Cells[0].Value);
               

                Professors dao = new Professors();
                dao.Excluir(id);

                MessageBox.Show("Professor excluído com sucesso!");

                dgvProfessores.DataSource = dao.Listar();
            }
            else
            {
                MessageBox.Show("Selecione um professor para excluir.");
            }
        }
    }
}
