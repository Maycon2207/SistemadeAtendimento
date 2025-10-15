namespace SistemaAtendimento.View
{
    partial class FrmCadastroUsuario
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
            grbListaClientes = new GroupBox();
            dgvUsuarios = new DataGridView();
            btnPesquisar = new Button();
            txtPesquisar = new TextBox();
            lblPesquisar = new Label();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnNovo = new Button();
            grbDadosCliente = new GroupBox();
            lblPerfil = new Label();
            cbxPerfil = new ComboBox();
            txtTelefone = new TextBox();
            lblSenha = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            grbDadosCliente.SuspendLayout();
            SuspendLayout();
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(dgvUsuarios);
            grbListaClientes.Location = new Point(11, 243);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(788, 225);
            grbListaClientes.TabIndex = 51;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Usuários";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(9, 22);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(764, 188);
            dgvUsuarios.TabIndex = 0;

            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(709, 198);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 49;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(470, 198);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(233, 23);
            txtPesquisar.TabIndex = 48;
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(470, 180);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 50;
            lblPesquisar.Text = "Pesquisar";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(340, 197);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 47;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(259, 197);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 46;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(178, 197);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 45;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(92, 197);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 44;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(11, 197);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 43;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(lblPerfil);
            grbDadosCliente.Controls.Add(cbxPerfil);
            grbDadosCliente.Controls.Add(txtTelefone);
            grbDadosCliente.Controls.Add(lblSenha);
            grbDadosCliente.Controls.Add(txtNome);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(txtCodigo);
            grbDadosCliente.Controls.Add(lblCodigo);
            grbDadosCliente.Location = new Point(12, 12);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(787, 158);
            grbDadosCliente.TabIndex = 42;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Usuário";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Location = new Point(328, 78);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(34, 15);
            lblPerfil.TabIndex = 27;
            lblPerfil.Text = "Perfil";
            // 
            // cbxPerfil
            // 
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PR", "PB", "PA", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SE", "SP", "TO" });
            cbxPerfil.Location = new Point(328, 99);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(245, 23);
            cbxPerfil.TabIndex = 13;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(21, 99);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(280, 23);
            txtTelefone.TabIndex = 3;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(21, 81);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(151, 43);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(621, 23);
            txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(151, 25);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(21, 43);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(21, 25);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 489);
            Controls.Add(grbListaClientes);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosCliente);
            Name = "FrmCadastroUsuario";
            Text = "Cadastro de Usuários";
            grbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbListaClientes;
        private DataGridView dgvUsuarios;
        private Button btnPesquisar;
        private TextBox txtPesquisar;
        private Label lblPesquisar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnNovo;
        private GroupBox grbDadosCliente;
        private Label lblPerfil;
        private ComboBox cbxPerfil;
        private TextBox txtTelefone;
        private Label lblSenha;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtCodigo;
        private Label lblCodigo;
    }
}