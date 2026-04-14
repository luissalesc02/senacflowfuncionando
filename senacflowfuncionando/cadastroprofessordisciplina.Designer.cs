namespace senacflowfuncionando
{
    partial class cadastroprofessordisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNomeProfessor = new TextBox();
            cmbDisciplina = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btncadastra = new Button();
            btnvoltar = new Button();
            dgvProfessores = new DataGridView();
            btnexluirp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProfessores).BeginInit();
            SuspendLayout();
            // 
            // txtNomeProfessor
            // 
            txtNomeProfessor.Location = new Point(92, 109);
            txtNomeProfessor.Name = "txtNomeProfessor";
            txtNomeProfessor.Size = new Size(175, 23);
            txtNomeProfessor.TabIndex = 0;
            // 
            // cmbDisciplina
            // 
            cmbDisciplina.FormattingEnabled = true;
            cmbDisciplina.Items.AddRange(new object[] { "Beleza", "Bem-estar", "Comércio", "Comunicação", "Design", "Educação", "Eventos", "Gastronomia", "Gestão", "Hospedagem", "Idiomas", "Informática (TI)", "Meio Ambiente", "Moda", "Saúde", "Segurança", "Turismo" });
            cmbDisciplina.Location = new Point(95, 163);
            cmbDisciplina.Name = "cmbDisciplina";
            cmbDisciplina.Size = new Size(172, 23);
            cmbDisciplina.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 9);
            label1.Name = "label1";
            label1.Size = new Size(414, 37);
            label1.TabIndex = 2;
            label1.Text = "Cadastro de Professor E Disciplina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label2.Location = new Point(12, 109);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 3;
            label2.Text = "Professor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 4;
            label3.Text = "Disciplina";
            // 
            // btncadastra
            // 
            btncadastra.Location = new Point(82, 246);
            btncadastra.Name = "btncadastra";
            btncadastra.Size = new Size(143, 35);
            btncadastra.TabIndex = 5;
            btncadastra.Text = "cadastrar";
            btncadastra.UseVisualStyleBackColor = true;
            btncadastra.Click += btncadastra_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(82, 350);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(143, 32);
            btnvoltar.TabIndex = 7;
            btnvoltar.Text = "Voltar ";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // dgvProfessores
            // 
            dgvProfessores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfessores.Location = new Point(308, 109);
            dgvProfessores.Name = "dgvProfessores";
            dgvProfessores.Size = new Size(480, 329);
            dgvProfessores.TabIndex = 8;
            dgvProfessores.CellContentClick += dgvProfessores_CellContentClick;
            // 
            // btnexluirp
            // 
            btnexluirp.Location = new Point(82, 300);
            btnexluirp.Name = "btnexluirp";
            btnexluirp.Size = new Size(143, 30);
            btnexluirp.TabIndex = 9;
            btnexluirp.Text = "Exluir";
            btnexluirp.UseVisualStyleBackColor = true;
            btnexluirp.Click += btnexluirp_Click;
            // 
            // cadastroprofessordisciplina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnexluirp);
            Controls.Add(dgvProfessores);
            Controls.Add(btnvoltar);
            Controls.Add(btncadastra);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbDisciplina);
            Controls.Add(txtNomeProfessor);
            Name = "cadastroprofessordisciplina";
            Text = "cadastroprofessordisciplina";
            Load += cadastroprofessordisciplina_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProfessores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeProfessor;
        private ComboBox cmbDisciplina;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btncadastra;
        private Button btnvoltar;
        private DataGridView dgvProfessores;
        private Button btnexluirp;
    }
}