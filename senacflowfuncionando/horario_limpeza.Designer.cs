namespace senacflowfuncionando
{
    partial class horario_limpeza
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnexcel = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            mtbhoratermino = new MaskedTextBox();
            mtbhorainicio = new MaskedTextBox();
            dtpData = new DateTimePicker();
            btnexluir = new Button();
            btneditar = new Button();
            btnlistar = new Button();
            btninserir = new Button();
            cmbSala = new ComboBox();
            cmbProfessor = new ComboBox();
            dgvHorarios = new DataGridView();
            tabPage2 = new TabPage();
            btnencerrar = new Button();
            btninserirl = new Button();
            btnecluirl = new Button();
            btneditarl = new Button();
            btnlistarl = new Button();
            btnexportarl = new Button();
            dgvlimpeza = new DataGridView();
            mtbhoral = new MaskedTextBox();
            dtplimpeza = new DateTimePicker();
            cmblocallimp = new ComboBox();
            txtresponsavel = new TextBox();
            cmbstatus = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlimpeza).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 494);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnexcel);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(mtbhoratermino);
            tabPage1.Controls.Add(mtbhorainicio);
            tabPage1.Controls.Add(dtpData);
            tabPage1.Controls.Add(btnexluir);
            tabPage1.Controls.Add(btneditar);
            tabPage1.Controls.Add(btnlistar);
            tabPage1.Controls.Add(btninserir);
            tabPage1.Controls.Add(cmbSala);
            tabPage1.Controls.Add(cmbProfessor);
            tabPage1.Controls.Add(dgvHorarios);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 466);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Horario Dos Professores";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnexcel
            // 
            btnexcel.Location = new Point(614, 345);
            btnexcel.Name = "btnexcel";
            btnexcel.Size = new Size(138, 39);
            btnexcel.TabIndex = 16;
            btnexcel.Text = "Exportar para Excel";
            btnexcel.UseVisualStyleBackColor = true;
            btnexcel.Click += btnexcel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(463, 345);
            button1.Name = "button1";
            button1.Size = new Size(148, 41);
            button1.TabIndex = 15;
            button1.Text = "cadastar professor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label5.Location = new Point(3, 402);
            label5.Name = "label5";
            label5.Size = new Size(47, 21);
            label5.TabIndex = 14;
            label5.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label4.Location = new Point(3, 363);
            label4.Name = "label4";
            label4.Size = new Size(133, 21);
            label4.TabIndex = 13;
            label4.Text = "Hora De Termino:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label3.Location = new Point(8, 326);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 12;
            label3.Text = "Hora De Inicio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic);
            label2.Location = new Point(12, 290);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 11;
            label2.Text = "Sala:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 246);
            label1.Name = "label1";
            label1.Size = new Size(77, 21);
            label1.TabIndex = 10;
            label1.Text = "Professor:";
            // 
            // mtbhoratermino
            // 
            mtbhoratermino.Location = new Point(141, 363);
            mtbhoratermino.Mask = "90:00";
            mtbhoratermino.Name = "mtbhoratermino";
            mtbhoratermino.Size = new Size(100, 23);
            mtbhoratermino.TabIndex = 9;
            mtbhoratermino.ValidatingType = typeof(DateTime);
            // 
            // mtbhorainicio
            // 
            mtbhorainicio.Location = new Point(122, 326);
            mtbhorainicio.Mask = "90:00";
            mtbhorainicio.Name = "mtbhorainicio";
            mtbhorainicio.Size = new Size(100, 23);
            mtbhorainicio.TabIndex = 8;
            mtbhorainicio.ValidatingType = typeof(DateTime);
            // 
            // dtpData
            // 
            dtpData.Location = new Point(56, 402);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(200, 23);
            dtpData.TabIndex = 7;
            // 
            // btnexluir
            // 
            btnexluir.Location = new Point(614, 246);
            btnexluir.Name = "btnexluir";
            btnexluir.Size = new Size(145, 41);
            btnexluir.TabIndex = 6;
            btnexluir.Text = "Excluir";
            btnexluir.UseVisualStyleBackColor = true;
            btnexluir.Click += btnexluir_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(463, 293);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(145, 41);
            btneditar.TabIndex = 5;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = true;
            btneditar.Click += btneditar_Click;
            // 
            // btnlistar
            // 
            btnlistar.Location = new Point(614, 293);
            btnlistar.Name = "btnlistar";
            btnlistar.Size = new Size(145, 41);
            btnlistar.TabIndex = 4;
            btnlistar.Text = "Listar";
            btnlistar.UseVisualStyleBackColor = true;
            btnlistar.Click += btnlistar_Click;
            // 
            // btninserir
            // 
            btninserir.Location = new Point(463, 246);
            btninserir.Name = "btninserir";
            btninserir.Size = new Size(145, 41);
            btninserir.TabIndex = 3;
            btninserir.Text = "Inserir";
            btninserir.UseVisualStyleBackColor = true;
            btninserir.Click += btninserir_Click;
            // 
            // cmbSala
            // 
            cmbSala.FormattingEnabled = true;
            cmbSala.Location = new Point(61, 290);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(121, 23);
            cmbSala.TabIndex = 2;
            // 
            // cmbProfessor
            // 
            cmbProfessor.FormattingEnabled = true;
            cmbProfessor.Location = new Point(95, 246);
            cmbProfessor.Name = "cmbProfessor";
            cmbProfessor.Size = new Size(121, 23);
            cmbProfessor.TabIndex = 1;
            // 
            // dgvHorarios
            // 
            dgvHorarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHorarios.Location = new Point(12, 6);
            dgvHorarios.Name = "dgvHorarios";
            dgvHorarios.Size = new Size(756, 226);
            dgvHorarios.TabIndex = 0;
            dgvHorarios.CellContentClick += dgvHorarios_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbstatus);
            tabPage2.Controls.Add(txtresponsavel);
            tabPage2.Controls.Add(cmblocallimp);
            tabPage2.Controls.Add(dtplimpeza);
            tabPage2.Controls.Add(mtbhoral);
            tabPage2.Controls.Add(dgvlimpeza);
            tabPage2.Controls.Add(btnexportarl);
            tabPage2.Controls.Add(btnlistarl);
            tabPage2.Controls.Add(btneditarl);
            tabPage2.Controls.Add(btnecluirl);
            tabPage2.Controls.Add(btninserirl);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 466);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Limpeza";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnencerrar
            // 
            btnencerrar.Location = new Point(300, 497);
            btnencerrar.Name = "btnencerrar";
            btnencerrar.Size = new Size(146, 36);
            btnencerrar.TabIndex = 1;
            btnencerrar.Text = "Encerrar Sistema";
            btnencerrar.UseVisualStyleBackColor = true;
            btnencerrar.Click += btnencerrar_Click;
            // 
            // btninserirl
            // 
            btninserirl.Location = new Point(413, 237);
            btninserirl.Name = "btninserirl";
            btninserirl.Size = new Size(75, 23);
            btninserirl.TabIndex = 0;
            btninserirl.Text = "inserir";
            btninserirl.UseVisualStyleBackColor = true;
            // 
            // btnecluirl
            // 
            btnecluirl.Location = new Point(547, 236);
            btnecluirl.Name = "btnecluirl";
            btnecluirl.Size = new Size(75, 23);
            btnecluirl.TabIndex = 1;
            btnecluirl.Text = "exluir";
            btnecluirl.UseVisualStyleBackColor = true;
            // 
            // btneditarl
            // 
            btneditarl.Location = new Point(436, 295);
            btneditarl.Name = "btneditarl";
            btneditarl.Size = new Size(75, 23);
            btneditarl.TabIndex = 2;
            btneditarl.Text = "editar";
            btneditarl.UseVisualStyleBackColor = true;
            // 
            // btnlistarl
            // 
            btnlistarl.Location = new Point(617, 355);
            btnlistarl.Name = "btnlistarl";
            btnlistarl.Size = new Size(83, 23);
            btnlistarl.TabIndex = 3;
            btnlistarl.Text = "listar";
            btnlistarl.UseVisualStyleBackColor = true;
            // 
            // btnexportarl
            // 
            btnexportarl.Location = new Point(532, 395);
            btnexportarl.Name = "btnexportarl";
            btnexportarl.Size = new Size(168, 23);
            btnexportarl.TabIndex = 4;
            btnexportarl.Text = "Exportar Excel";
            btnexportarl.UseVisualStyleBackColor = true;
            // 
            // dgvlimpeza
            // 
            dgvlimpeza.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvlimpeza.Location = new Point(8, 50);
            dgvlimpeza.Name = "dgvlimpeza";
            dgvlimpeza.Size = new Size(240, 150);
            dgvlimpeza.TabIndex = 5;
            // 
            // mtbhoral
            // 
            mtbhoral.Location = new Point(128, 265);
            mtbhoral.Name = "mtbhoral";
            mtbhoral.Size = new Size(100, 23);
            mtbhoral.TabIndex = 6;
            // 
            // dtplimpeza
            // 
            dtplimpeza.Location = new Point(105, 348);
            dtplimpeza.Name = "dtplimpeza";
            dtplimpeza.Size = new Size(200, 23);
            dtplimpeza.TabIndex = 7;
            // 
            // cmblocallimp
            // 
            cmblocallimp.FormattingEnabled = true;
            cmblocallimp.Location = new Point(132, 315);
            cmblocallimp.Name = "cmblocallimp";
            cmblocallimp.Size = new Size(121, 23);
            cmblocallimp.TabIndex = 8;
            // 
            // txtresponsavel
            // 
            txtresponsavel.Location = new Point(156, 217);
            txtresponsavel.Name = "txtresponsavel";
            txtresponsavel.Size = new Size(100, 23);
            txtresponsavel.TabIndex = 9;
            // 
            // cmbstatus
            // 
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Items.AddRange(new object[] { "pendente", "em_andamento", "concluida", "cancelada" });
            cmbstatus.Location = new Point(154, 400);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(121, 23);
            cmbstatus.TabIndex = 10;
            // 
            // horario_limpeza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(btnencerrar);
            Controls.Add(tabControl1);
            Name = "horario_limpeza";
            Text = "horario_limpeza";
            Load += horario_limpeza_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHorarios).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvlimpeza).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvHorarios;
        private Button btnexluir;
        private Button btneditar;
        private Button btnlistar;
        private Button btninserir;
        private ComboBox cmbSala;
        private ComboBox cmbProfessor;
        private MaskedTextBox mtbhorainicio;
        private DateTimePicker dtpData;
        private MaskedTextBox mtbhoratermino;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Button btnexcel;
        private Button btnencerrar;
        private MaskedTextBox mtbhoral;
        private DataGridView dgvlimpeza;
        private Button btnexportarl;
        private Button btnlistarl;
        private Button btneditarl;
        private Button btnecluirl;
        private Button btninserirl;
        private ComboBox cmbstatus;
        private TextBox txtresponsavel;
        private ComboBox cmblocallimp;
        private DateTimePicker dtplimpeza;
    }
}