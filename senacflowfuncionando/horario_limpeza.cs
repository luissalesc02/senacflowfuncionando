using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace senacflowfuncionando
{
    public partial class horario_limpeza : Form
    {
        private string usuarioLogado;
        public horario_limpeza(string login)
        {
            usuarioLogado = login;
            InitializeComponent();
        }

        private void horario_limpeza_Load(object sender, EventArgs e)
        {
            var conn = new ConexaoBD().AbrirConexao();
            MySqlDataAdapter daProf = new MySqlDataAdapter("SELECT id_professor, nome_completo FROM Professor", conn);
            DataTable dtProf = new DataTable();
            daProf.Fill(dtProf);
            cmbProfessor.DataSource = dtProf;
            cmbProfessor.DisplayMember = "nome_completo";
            cmbProfessor.ValueMember = "id_professor";

            // Carregar Salas
            MySqlDataAdapter daSala = new MySqlDataAdapter("SELECT id_sala, nome_codigo FROM Sala", conn);
            DataTable dtSala = new DataTable();
            daSala.Fill(dtSala);
            cmbSala.DataSource = dtSala;
            cmbSala.DisplayMember = "nome_codigo";
            cmbSala.ValueMember = "id_sala";

            new ConexaoBD().FecharConexao(conn);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            Horario h = new Horario();
            h.IdProfessor = Convert.ToInt32(cmbProfessor.SelectedValue);
            h.IdSala = Convert.ToInt32(cmbSala.SelectedValue);
            h.DataAtual = dtpData.Value; 
            h.HoraInicio = mtbhorainicio.Text; 
            h.HoraTermino = mtbhoratermino.Text;

            HorarioDAO dao = new HorarioDAO();
            dao.Inserir(h);

            MessageBox.Show("Horário inserido com sucesso!");

        }

        private void dgvHorarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHorarios.CurrentRow != null)
            {
                cmbProfessor.Text = dgvHorarios.CurrentRow.Cells["Professor"].Value.ToString();
                cmbSala.Text = dgvHorarios.CurrentRow.Cells["Sala"].Value.ToString();
                dtpData.Value = Convert.ToDateTime(dgvHorarios.CurrentRow.Cells["data_atual"].Value);
                mtbhorainicio.Text = dgvHorarios.CurrentRow.Cells["hora_inicio"].Value.ToString();
                mtbhoratermino.Text = dgvHorarios.CurrentRow.Cells["hora_termino"].Value.ToString();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (dgvHorarios.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvHorarios.SelectedRows[0].Cells["id_horario"].Value);

                Horario h = new Horario
                {
                    IdHorario = id,
                    IdProfessor = Convert.ToInt32(cmbProfessor.SelectedValue),
                    IdSala = Convert.ToInt32(cmbSala.SelectedValue),
                    DataAtual = dtpData.Value, 
                    HoraInicio = mtbhorainicio.Text, 
                    HoraTermino = mtbhoratermino.Text
                };

                HorarioDAO dao = new HorarioDAO();
                dao.Editar(h);

                MessageBox.Show("Horário atualizado com sucesso!");
                dgvHorarios.DataSource = dao.Listar(); 
            }
            else
            {
                MessageBox.Show("Selecione um horário para editar.");
            }
        }

        private void btnlistar_Click(object sender, EventArgs e)
        {
            HorarioDAO dao = new HorarioDAO();
            dgvHorarios.DataSource = dao.Listar();
        }

        private void btnexluir_Click(object sender, EventArgs e)
        {
            if (dgvHorarios.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvHorarios.CurrentRow.Cells["id_horario"].Value);

                HorarioDAO dao = new HorarioDAO(); 
                dao.Excluir(id);
                dgvHorarios.DataSource = dao.Listar();
            }
            else
            {
                MessageBox.Show("Selecione um horário para excluir.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastroprofessordisciplina telacadas = new cadastroprofessordisciplina(usuarioLogado);
            telacadas.Show();
            this.Hide();
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
              
                var worksheet = workbook.Worksheets.Add("Horarios");

              
                for (int i = 0; i < dgvHorarios.Columns.Count; i++)
                {
                    worksheet.Cell(1, i + 1).Value = dgvHorarios.Columns[i].HeaderText;
                }

              
                for (int r = 0; r < dgvHorarios.Rows.Count; r++)
                {
                    for (int c = 0; c < dgvHorarios.Columns.Count; c++)
                    {
                        worksheet.Cell(r + 2, c + 1).Value = dgvHorarios.Rows[r].Cells[c].Value?.ToString();
                    }
                }

               
                SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(sfd.FileName);
                    MessageBox.Show("Cadastro exportado com sucesso!");
                }
            }
        }

        private void btnencerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("deseja realmente sair?", "confirmação",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
               
                MessageBox.Show("Administrador  Encerrou o Sistema Senac Flow" );
              
                loginadmincadas telaadmin = new loginadmincadas();
                telaadmin.Show();
                this.Hide();

            }
        }
    }
}
