namespace SistemaAtendimento.View
{
    partial class frmCadastroUsuario
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroUsuario));
            btnNovo = new Button();
            imageList1 = new ImageList(components);
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            cbxPesquisar = new ComboBox();
            lblpesquisar = new Label();
            grbDadosUsuario = new GroupBox();
            lbl = new Label();
            lblNome = new Label();
            lblCodigo = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            cbxPerfil = new ComboBox();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            grbListaUsuarios = new GroupBox();
            dataGridView1 = new DataGridView();
            grbDadosUsuario.SuspendLayout();
            grbListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 2;
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(24, 216);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 3;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-cancelar.png");
            imageList1.Images.SetKeyName(1, "icone-edite.png");
            imageList1.Images.SetKeyName(2, "icone-novo.png");
            imageList1.Images.SetKeyName(3, "icone-procurar.png");
            imageList1.Images.SetKeyName(4, "icone-salvar.png");
            imageList1.Images.SetKeyName(5, "icon-excluir.png");
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(344, 216);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 24);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 5;
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(264, 216);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 4;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(184, 216);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleRight;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(104, 216);
            btnEditar.Name = "btnEditar";
            btnEditar.RightToLeft = RightToLeft.Yes;
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageKey = "icone-procurar.png";
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(696, 216);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 8;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // cbxPesquisar
            // 
            cbxPesquisar.FormattingEnabled = true;
            cbxPesquisar.Location = new Point(504, 216);
            cbxPesquisar.Name = "cbxPesquisar";
            cbxPesquisar.Size = new Size(184, 23);
            cbxPesquisar.TabIndex = 9;
            // 
            // lblpesquisar
            // 
            lblpesquisar.AutoSize = true;
            lblpesquisar.Location = new Point(504, 200);
            lblpesquisar.Name = "lblpesquisar";
            lblpesquisar.Size = new Size(57, 15);
            lblpesquisar.TabIndex = 9;
            lblpesquisar.Text = "Pesquisar";
            // 
            // grbDadosUsuario
            // 
            grbDadosUsuario.Controls.Add(lbl);
            grbDadosUsuario.Controls.Add(lblNome);
            grbDadosUsuario.Controls.Add(lblCodigo);
            grbDadosUsuario.Controls.Add(txtSenha);
            grbDadosUsuario.Controls.Add(lblSenha);
            grbDadosUsuario.Controls.Add(cbxPerfil);
            grbDadosUsuario.Controls.Add(txtCodigo);
            grbDadosUsuario.Controls.Add(txtNome);
            grbDadosUsuario.Location = new Point(16, 16);
            grbDadosUsuario.Name = "grbDadosUsuario";
            grbDadosUsuario.Size = new Size(776, 152);
            grbDadosUsuario.TabIndex = 12;
            grbDadosUsuario.TabStop = false;
            grbDadosUsuario.Text = "Dados do Usuario";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(336, 88);
            lbl.Name = "lbl";
            lbl.Size = new Size(34, 15);
            lbl.TabIndex = 8;
            lbl.Text = "Perfil";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(160, 24);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(31, 23);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(23, 103);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(264, 23);
            txtSenha.TabIndex = 5;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(32, 88);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 7;
            lblSenha.Text = "Senha";
            // 
            // cbxPerfil
            // 
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Location = new Point(335, 103);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(264, 23);
            cbxPerfil.TabIndex = 3;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(31, 39);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(159, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(576, 23);
            txtNome.TabIndex = 4;
            // 
            // grbListaUsuarios
            // 
            grbListaUsuarios.Controls.Add(dataGridView1);
            grbListaUsuarios.Location = new Point(16, 280);
            grbListaUsuarios.Name = "grbListaUsuarios";
            grbListaUsuarios.Size = new Size(776, 152);
            grbListaUsuarios.TabIndex = 13;
            grbListaUsuarios.TabStop = false;
            grbListaUsuarios.Text = "Lista so Usuario";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 128);
            dataGridView1.TabIndex = 0;
            // 
            // frmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbListaUsuarios);
            Controls.Add(grbDadosUsuario);
            Controls.Add(lblpesquisar);
            Controls.Add(cbxPesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnNovo);
            Name = "frmCadastroUsuario";
            Text = "Cadastro de Usuarios";
            Load += frmCadastroUsuario_Load;
            grbDadosUsuario.ResumeLayout(false);
            grbDadosUsuario.PerformLayout();
            grbListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel grbCadastroUsario;
        private Button btnNovo;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnPesquisar;
        private ComboBox cbxPesquisar;
        private Label lblpesquisar;
        private DataGridView dataGridView1;
        private Panel panel3;
        private GroupBox grbDadosUsuario;
        private Label lbl;
        private Label lblNome;
        private Label lblCodigo;
        private TextBox txtSenha;
        private Label lblSenha;
        private ComboBox cbxPerfil;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private ImageList imageList1;
        private GroupBox grbListaUsuarios;
    }
}