namespace SistemadeAtendimentos
{
    partial class FrmCadastroClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroClientes));
            grbDadosCliente = new GroupBox();
            cbxEstado = new ComboBox();
            panelSituacao = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSitucao = new Label();
            lblEstado = new Label();
            lblCidade = new Label();
            lblComplemento = new Label();
            lblBairro = new Label();
            lblNumero = new Label();
            lblEndereco = new Label();
            lblCep = new Label();
            lblCpfCnpj = new Label();
            txtCidade = new TextBox();
            txtComplemento = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            txtEndereco = new TextBox();
            txtCep = new TextBox();
            TxtCpfCnpj = new TextBox();
            panelTipoPessoa = new Panel();
            rdbJuridica = new RadioButton();
            rdbFisica = new RadioButton();
            lblTipoPessoa = new Label();
            txtCelular = new TextBox();
            lblCelular = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtNome = new TextBox();
            lblTelefone = new Label();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnNovo = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            txtPesqusiar = new TextBox();
            btnPesquisar = new Button();
            grbListaClientes = new GroupBox();
            dgbClientes = new DataGridView();
            imlIcones = new ImageList(components);
            lblPesquisar = new Label();
            grbDadosCliente.SuspendLayout();
            panelSituacao.SuspendLayout();
            panelTipoPessoa.SuspendLayout();
            grbListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgbClientes).BeginInit();
            SuspendLayout();
            // 
            // grbDadosCliente
            // 
            grbDadosCliente.Controls.Add(cbxEstado);
            grbDadosCliente.Controls.Add(panelSituacao);
            grbDadosCliente.Controls.Add(lblSitucao);
            grbDadosCliente.Controls.Add(lblEstado);
            grbDadosCliente.Controls.Add(lblCidade);
            grbDadosCliente.Controls.Add(lblComplemento);
            grbDadosCliente.Controls.Add(lblBairro);
            grbDadosCliente.Controls.Add(lblNumero);
            grbDadosCliente.Controls.Add(lblEndereco);
            grbDadosCliente.Controls.Add(lblCep);
            grbDadosCliente.Controls.Add(lblCpfCnpj);
            grbDadosCliente.Controls.Add(txtCidade);
            grbDadosCliente.Controls.Add(txtComplemento);
            grbDadosCliente.Controls.Add(txtBairro);
            grbDadosCliente.Controls.Add(txtNumero);
            grbDadosCliente.Controls.Add(txtEndereco);
            grbDadosCliente.Controls.Add(txtCep);
            grbDadosCliente.Controls.Add(TxtCpfCnpj);
            grbDadosCliente.Controls.Add(panelTipoPessoa);
            grbDadosCliente.Controls.Add(lblTipoPessoa);
            grbDadosCliente.Controls.Add(txtCelular);
            grbDadosCliente.Controls.Add(lblCelular);
            grbDadosCliente.Controls.Add(lblEmail);
            grbDadosCliente.Controls.Add(txtEmail);
            grbDadosCliente.Controls.Add(txtTelefone);
            grbDadosCliente.Controls.Add(txtNome);
            grbDadosCliente.Controls.Add(lblTelefone);
            grbDadosCliente.Controls.Add(lblNome);
            grbDadosCliente.Controls.Add(txtCodigo);
            grbDadosCliente.Controls.Add(lblCodigo);
            grbDadosCliente.Location = new Point(8, 8);
            grbDadosCliente.Name = "grbDadosCliente";
            grbDadosCliente.Size = new Size(712, 320);
            grbDadosCliente.TabIndex = 0;
            grbDadosCliente.TabStop = false;
            grbDadosCliente.Text = "Dados do Cliente ";
            grbDadosCliente.Enter += grbDadosCliente_Enter;
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PR", "PB", "PA", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SE", "SP", "TO" });
            cbxEstado.Location = new Point(8, 272);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 23);
            cbxEstado.TabIndex = 13;
            // 
            // panelSituacao
            // 
            panelSituacao.Controls.Add(rdbInativo);
            panelSituacao.Controls.Add(rdbAtivo);
            panelSituacao.Location = new Point(160, 264);
            panelSituacao.Name = "panelSituacao";
            panelSituacao.Size = new Size(152, 32);
            panelSituacao.TabIndex = 14;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(72, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 2;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(8, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(53, 19);
            rdbAtivo.TabIndex = 1;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "Ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // lblSitucao
            // 
            lblSitucao.AutoSize = true;
            lblSitucao.Location = new Point(168, 248);
            lblSitucao.Name = "lblSitucao";
            lblSitucao.Size = new Size(52, 15);
            lblSitucao.TabIndex = 11;
            lblSitucao.Text = "Situação";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(8, 248);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 25;
            lblEstado.Text = "Estado";
            // 
            // lblCidade
            // 
            lblCidade.AutoSize = true;
            lblCidade.Location = new Point(328, 200);
            lblCidade.Name = "lblCidade";
            lblCidade.Size = new Size(44, 15);
            lblCidade.TabIndex = 24;
            lblCidade.Text = "Cidade";
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Location = new Point(152, 200);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(84, 15);
            lblComplemento.TabIndex = 23;
            lblComplemento.Text = "Complemento";
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Location = new Point(8, 200);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(38, 15);
            lblBairro.TabIndex = 22;
            lblBairro.Text = "Bairro";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(480, 144);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 21;
            lblNumero.Text = "Número";
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Location = new Point(152, 144);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(56, 15);
            lblEndereco.TabIndex = 20;
            lblEndereco.Text = "Endereço";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Location = new Point(8, 144);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(28, 15);
            lblCep.TabIndex = 19;
            lblCep.Text = "CEP";
            // 
            // lblCpfCnpj
            // 
            lblCpfCnpj.AutoSize = true;
            lblCpfCnpj.Location = new Point(480, 88);
            lblCpfCnpj.Name = "lblCpfCnpj";
            lblCpfCnpj.Size = new Size(60, 15);
            lblCpfCnpj.TabIndex = 18;
            lblCpfCnpj.Text = "CPF/CNPJ";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(328, 216);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(136, 23);
            txtCidade.TabIndex = 12;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(152, 216);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(160, 23);
            txtComplemento.TabIndex = 11;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(8, 216);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(128, 23);
            txtBairro.TabIndex = 10;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(480, 160);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(80, 23);
            txtNumero.TabIndex = 9;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(152, 160);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(312, 23);
            txtEndereco.TabIndex = 8;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(8, 160);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(128, 23);
            txtCep.TabIndex = 7;
            // 
            // TxtCpfCnpj
            // 
            TxtCpfCnpj.Location = new Point(480, 104);
            TxtCpfCnpj.Name = "TxtCpfCnpj";
            TxtCpfCnpj.Size = new Size(200, 23);
            TxtCpfCnpj.TabIndex = 6;
            // 
            // panelTipoPessoa
            // 
            panelTipoPessoa.Controls.Add(rdbJuridica);
            panelTipoPessoa.Controls.Add(rdbFisica);
            panelTipoPessoa.Location = new Point(312, 104);
            panelTipoPessoa.Name = "panelTipoPessoa";
            panelTipoPessoa.Size = new Size(152, 32);
            panelTipoPessoa.TabIndex = 5;
            // 
            // rdbJuridica
            // 
            rdbJuridica.AutoSize = true;
            rdbJuridica.Location = new Point(72, 8);
            rdbJuridica.Name = "rdbJuridica";
            rdbJuridica.Size = new Size(65, 19);
            rdbJuridica.TabIndex = 1;
            rdbJuridica.TabStop = true;
            rdbJuridica.Text = "Jurídica";
            rdbJuridica.UseVisualStyleBackColor = true;
            // 
            // rdbFisica
            // 
            rdbFisica.AutoSize = true;
            rdbFisica.Location = new Point(8, 8);
            rdbFisica.Name = "rdbFisica";
            rdbFisica.Size = new Size(54, 19);
            rdbFisica.TabIndex = 0;
            rdbFisica.TabStop = true;
            rdbFisica.Text = "Física";
            rdbFisica.UseVisualStyleBackColor = true;
            // 
            // lblTipoPessoa
            // 
            lblTipoPessoa.AutoSize = true;
            lblTipoPessoa.Location = new Point(312, 88);
            lblTipoPessoa.Name = "lblTipoPessoa";
            lblTipoPessoa.Size = new Size(69, 15);
            lblTipoPessoa.TabIndex = 9;
            lblTipoPessoa.Text = "Tipo Pessoa";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(152, 104);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(144, 23);
            txtCelular.TabIndex = 4;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(152, 88);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(44, 15);
            lblCelular.TabIndex = 7;
            lblCelular.Text = "Celular";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(416, 32);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(416, 48);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(8, 104);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(128, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(152, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 23);
            txtNome.TabIndex = 1;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(8, 88);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(51, 15);
            lblTelefone.TabIndex = 6;
            lblTelefone.Text = "Telefone";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(152, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(8, 48);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(128, 23);
            txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(8, 32);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codígo";
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 2;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(8, 344);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(88, 32);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(96, 344);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(80, 32);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 4;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(176, 344);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 31);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 5;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(264, 344);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(88, 32);
            btnExcluir.TabIndex = 18;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(352, 344);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 31);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtPesqusiar
            // 
            txtPesqusiar.Location = new Point(464, 344);
            txtPesqusiar.Name = "txtPesqusiar";
            txtPesqusiar.Size = new Size(136, 23);
            txtPesqusiar.TabIndex = 20;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.ImageIndex = 3;
            btnPesquisar.ImageList = imlIcones;
            btnPesquisar.Location = new Point(616, 344);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(32, 24);
            btnPesquisar.TabIndex = 21;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // grbListaClientes
            // 
            grbListaClientes.Controls.Add(dgbClientes);
            grbListaClientes.Location = new Point(8, 384);
            grbListaClientes.Name = "grbListaClientes";
            grbListaClientes.Size = new Size(712, 200);
            grbListaClientes.TabIndex = 30;
            grbListaClientes.TabStop = false;
            grbListaClientes.Text = "Lista de Clientes";
            // 
            // dgbClientes
            // 
            dgbClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgbClientes.Location = new Point(0, 24);
            dgbClientes.Name = "dgbClientes";
            dgbClientes.Size = new Size(712, 160);
            dgbClientes.TabIndex = 0;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(1, "icone-edite.png");
            imlIcones.Images.SetKeyName(2, "icone-novo.png");
            imlIcones.Images.SetKeyName(3, "icone-procurar.png");
            imlIcones.Images.SetKeyName(4, "icone-salvar.png");
            imlIcones.Images.SetKeyName(5, "icon-excluir.png");
            // 
            // lblPesquisar
            // 
            lblPesquisar.AutoSize = true;
            lblPesquisar.Location = new Point(464, 328);
            lblPesquisar.Name = "lblPesquisar";
            lblPesquisar.Size = new Size(57, 15);
            lblPesquisar.TabIndex = 28;
            lblPesquisar.Text = "Pesquisar";
            // 
            // FrmCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 569);
            Controls.Add(grbListaClientes);
            Controls.Add(btnPesquisar);
            Controls.Add(lblPesquisar);
            Controls.Add(txtPesqusiar);
            Controls.Add(btnCancelar);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(grbDadosCliente);
            Name = "FrmCadastroClientes";
            Text = "Cadastro de Clientes";
            grbDadosCliente.ResumeLayout(false);
            grbDadosCliente.PerformLayout();
            panelSituacao.ResumeLayout(false);
            panelSituacao.PerformLayout();
            panelTipoPessoa.ResumeLayout(false);
            panelTipoPessoa.PerformLayout();
            grbListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgbClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbDadosCliente;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtCelular;
        private TextBox txtTelefone;
        private Label lblCelular;
        private Label lblEmail;
        private Label lblTelefone;
        private Panel panelTipoPessoa;
        private Label lblTipoPessoa;
        private RadioButton rdbJuridica;
        private RadioButton rdbFisica;
        private TextBox txtCidade;
        private TextBox txtComplemento;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private TextBox txtEndereco;
        private TextBox txtCep;
        private TextBox TxtCpfCnpj;
        private Label lblCidade;
        private Label lblComplemento;
        private Label lblBairro;
        private Label lblNumero;
        private Label lblEndereco;
        private Label lblCep;
        private Label lblCpfCnpj;
        private Label lblEstado;
        private Panel panelSituacao;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblSitucao;
        private ComboBox cbxEstado;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private TextBox txtPesqusiar;
        private Button btnPesquisar;
        private GroupBox grbListaClientes;
        private DataGridView dgbClientes;
        private ImageList imlIcones;
        private Label lblPesquisar;
    }
}