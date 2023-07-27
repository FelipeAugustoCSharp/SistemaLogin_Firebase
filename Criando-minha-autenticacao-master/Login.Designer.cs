namespace Criando_minha_autenticacao
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbllSenha = new LinkLabel();
            btnEntrar = new Button();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(89, 49);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "abobora@gmail.com";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(89, 91);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PlaceholderText = "Abobora 123";
            txtSenha.Size = new Size(100, 23);
            txtSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 31);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite o seu e-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 75);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Digite sua senha";
            // 
            // lbllSenha
            // 
            lbllSenha.AutoSize = true;
            lbllSenha.Location = new Point(89, 117);
            lbllSenha.Name = "lbllSenha";
            lbllSenha.Size = new Size(118, 15);
            lbllSenha.TabIndex = 3;
            lbllSenha.TabStop = true;
            lbllSenha.Text = "Esqueci minha senha";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(89, 135);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(106, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(89, 164);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(106, 23);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastro";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(lbllSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label label1;
        private Label label2;
        private LinkLabel lbllSenha;
        private Button btnEntrar;
        private Button btnCadastrar;
    }
}