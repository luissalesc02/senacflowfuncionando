namespace senacflowfuncionando
{
    partial class loginadmincadas
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
            label1 = new Label();
            label2 = new Label();
            txtadmin = new TextBox();
            txtsenhaamin = new TextBox();
            btnnovo = new Button();
            btnlogin = new Button();
            btnsenha = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 52);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 156);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // txtadmin
            // 
            txtadmin.Location = new Point(224, 87);
            txtadmin.Name = "txtadmin";
            txtadmin.Size = new Size(252, 23);
            txtadmin.TabIndex = 2;
            // 
            // txtsenhaamin
            // 
            txtsenhaamin.Location = new Point(224, 205);
            txtsenhaamin.Name = "txtsenhaamin";
            txtsenhaamin.PasswordChar = '*';
            txtsenhaamin.Size = new Size(252, 23);
            txtsenhaamin.TabIndex = 3;
            // 
            // btnnovo
            // 
            btnnovo.Location = new Point(224, 331);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(75, 23);
            btnnovo.TabIndex = 4;
            btnnovo.Text = "NOVO";
            btnnovo.UseVisualStyleBackColor = true;
            btnnovo.Click += btnnovo_Click;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(401, 331);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnsenha
            // 
            btnsenha.Location = new Point(482, 204);
            btnsenha.Name = "btnsenha";
            btnsenha.Size = new Size(103, 23);
            btnsenha.TabIndex = 6;
            btnsenha.Text = "mostrarsenha";
            btnsenha.UseVisualStyleBackColor = true;
            btnsenha.Click += btnsenha_Click;
            // 
            // loginadmincadas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnsenha);
            Controls.Add(btnlogin);
            Controls.Add(btnnovo);
            Controls.Add(txtsenhaamin);
            Controls.Add(txtadmin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "loginadmincadas";
            Text = "loginadmincadas";
            Load += loginadmincadas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtadmin;
        private TextBox txtsenhaamin;
        private Button btnnovo;
        private Button btnlogin;
        private Button btnsenha;
    }
}