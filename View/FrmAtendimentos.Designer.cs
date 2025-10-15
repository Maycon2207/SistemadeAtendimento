namespace SistemaAtendimento.View
{
    partial class FrmAtendimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAtendimentos));
            cbxNome = new GroupBox();
            btnNovo = new Button();
            imlIcones = new ImageList(components);
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnEditar = new Button();
            btnFinalizar = new Button();
            txtCodcliente = new TextBox();
            txtDataAbertura = new TextBox();
            txtObservacao = new TextBox();
            txtSituacaoAtedimento = new TextBox();
            comboBox1 = new ComboBox();
            lblObservacao = new Label();
            lblSistemaAtendimento = new Label();
            lblDataAbertura = new Label();
            lblNome = new Label();
            lblCod = new Label();
            cbxEtapasAtendimento = new GroupBox();
            lblObservacaoAtendimento = new Label();
            dgvEtapasAtendimento = new DataGridView();
            btnExcluirEtapa = new Button();
            btnAdicionarEtapa = new Button();
            txtObservacaoAtendimento = new TextBox();
            lblEtapaAtendimento = new Label();
            comboBox2 = new ComboBox();
            lblAtedimento = new Label();
            txtAtendimento = new TextBox();
            btnPesquisarCliente = new Button();
            cbxNome.SuspendLayout();
            cbxEtapasAtendimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).BeginInit();
            SuspendLayout();
            // 
            // cbxNome
            // 
            cbxNome.Controls.Add(btnNovo);
            cbxNome.Controls.Add(btnSalvar);
            cbxNome.Controls.Add(btnCancelar);
            cbxNome.Controls.Add(btnExcluir);
            cbxNome.Controls.Add(btnEditar);
            cbxNome.Controls.Add(btnFinalizar);
            cbxNome.Controls.Add(txtCodcliente);
            cbxNome.Controls.Add(txtDataAbertura);
            cbxNome.Controls.Add(txtObservacao);
            cbxNome.Controls.Add(txtSituacaoAtedimento);
            cbxNome.Controls.Add(comboBox1);
            cbxNome.Controls.Add(lblObservacao);
            cbxNome.Controls.Add(lblSistemaAtendimento);
            cbxNome.Controls.Add(lblDataAbertura);
            cbxNome.Controls.Add(lblNome);
            cbxNome.Controls.Add(lblCod);
            cbxNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxNome.Location = new Point(8, 56);
            cbxNome.Name = "cbxNome";
            cbxNome.Size = new Size(784, 288);
            cbxNome.TabIndex = 0;
            cbxNome.TabStop = false;
            cbxNome.Text = "Nome";
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 3;
            btnNovo.ImageList = imlIcones;
            btnNovo.Location = new Point(16, 240);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(83, 32);
            btnNovo.TabIndex = 24;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // imlIcones
            // 
            imlIcones.ColorDepth = ColorDepth.Depth32Bit;
            imlIcones.ImageStream = (ImageListStreamer)resources.GetObject("imlIcones.ImageStream");
            imlIcones.TransparentColor = Color.Transparent;
            imlIcones.Images.SetKeyName(0, "icone-cancelar.png");
            imlIcones.Images.SetKeyName(1, "icone-editar.png");
            imlIcones.Images.SetKeyName(2, "icone-excluir.png");
            imlIcones.Images.SetKeyName(3, "icone-novo.png");
            imlIcones.Images.SetKeyName(4, "icone-pesquisar.png");
            imlIcones.Images.SetKeyName(5, "icone-salvar.png");
            imlIcones.Images.SetKeyName(6, "icone - finalizar.png");
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 5;
            btnSalvar.ImageList = imlIcones;
            btnSalvar.Location = new Point(208, 240);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(83, 32);
            btnSalvar.TabIndex = 23;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imlIcones;
            btnCancelar.Location = new Point(408, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 32);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 2;
            btnExcluir.ImageList = imlIcones;
            btnExcluir.Location = new Point(304, 240);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(91, 32);
            btnExcluir.TabIndex = 21;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imlIcones;
            btnEditar.Location = new Point(112, 240);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(83, 32);
            btnEditar.TabIndex = 20;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFinalizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFinalizar.ImageKey = "icone - finalizar.png";
            btnFinalizar.ImageList = imlIcones;
            btnFinalizar.Location = new Point(656, 240);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(96, 32);
            btnFinalizar.TabIndex = 18;
            btnFinalizar.Text = "Finalizar";
            btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // txtCodcliente
            // 
            txtCodcliente.Font = new Font("Segoe UI Light", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodcliente.Location = new Point(8, 48);
            txtCodcliente.Name = "txtCodcliente";
            txtCodcliente.Size = new Size(112, 27);
            txtCodcliente.TabIndex = 13;
            // 
            // txtDataAbertura
            // 
            txtDataAbertura.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDataAbertura.Location = new Point(448, 48);
            txtDataAbertura.Name = "txtDataAbertura";
            txtDataAbertura.Size = new Size(295, 25);
            txtDataAbertura.TabIndex = 11;
            // 
            // txtObservacao
            // 
            txtObservacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtObservacao.Location = new Point(296, 104);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(360, 96);
            txtObservacao.TabIndex = 10;
            // 
            // txtSituacaoAtedimento
            // 
            txtSituacaoAtedimento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSituacaoAtedimento.Location = new Point(8, 120);
            txtSituacaoAtedimento.Name = "txtSituacaoAtedimento";
            txtSituacaoAtedimento.Size = new Size(240, 25);
            txtSituacaoAtedimento.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(160, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(232, 25);
            comboBox1.TabIndex = 8;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacao.Location = new Point(296, 88);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(72, 15);
            lblObservacao.TabIndex = 7;
            lblObservacao.Text = "Observação";
            // 
            // lblSistemaAtendimento
            // 
            lblSistemaAtendimento.AutoSize = true;
            lblSistemaAtendimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSistemaAtendimento.Location = new Point(8, 96);
            lblSistemaAtendimento.Name = "lblSistemaAtendimento";
            lblSistemaAtendimento.Size = new Size(148, 15);
            lblSistemaAtendimento.TabIndex = 3;
            lblSistemaAtendimento.Text = "Situação do Atendimento";
            // 
            // lblDataAbertura
            // 
            lblDataAbertura.AutoSize = true;
            lblDataAbertura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataAbertura.Location = new Point(488, 32);
            lblDataAbertura.Name = "lblDataAbertura";
            lblDataAbertura.Size = new Size(86, 15);
            lblDataAbertura.TabIndex = 4;
            lblDataAbertura.Text = "Data Abertura";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(160, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(41, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblCod
            // 
            lblCod.AutoSize = true;
            lblCod.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCod.Location = new Point(8, 32);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(73, 15);
            lblCod.TabIndex = 6;
            lblCod.Text = "Cód. Cliente";
            // 
            // cbxEtapasAtendimento
            // 
            cbxEtapasAtendimento.Controls.Add(lblObservacaoAtendimento);
            cbxEtapasAtendimento.Controls.Add(dgvEtapasAtendimento);
            cbxEtapasAtendimento.Controls.Add(btnExcluirEtapa);
            cbxEtapasAtendimento.Controls.Add(btnAdicionarEtapa);
            cbxEtapasAtendimento.Controls.Add(txtObservacaoAtendimento);
            cbxEtapasAtendimento.Controls.Add(lblEtapaAtendimento);
            cbxEtapasAtendimento.Controls.Add(comboBox2);
            cbxEtapasAtendimento.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbxEtapasAtendimento.Location = new Point(8, 368);
            cbxEtapasAtendimento.Name = "cbxEtapasAtendimento";
            cbxEtapasAtendimento.Size = new Size(776, 272);
            cbxEtapasAtendimento.TabIndex = 1;
            cbxEtapasAtendimento.TabStop = false;
            cbxEtapasAtendimento.Text = "Etapas do Atendimento";
            // 
            // lblObservacaoAtendimento
            // 
            lblObservacaoAtendimento.AutoSize = true;
            lblObservacaoAtendimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacaoAtendimento.Location = new Point(16, 80);
            lblObservacaoAtendimento.Name = "lblObservacaoAtendimento";
            lblObservacaoAtendimento.Size = new Size(72, 15);
            lblObservacaoAtendimento.TabIndex = 19;
            lblObservacaoAtendimento.Text = "Observação";
            // 
            // dgvEtapasAtendimento
            // 
            dgvEtapasAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEtapasAtendimento.Location = new Point(432, 32);
            dgvEtapasAtendimento.Name = "dgvEtapasAtendimento";
            dgvEtapasAtendimento.Size = new Size(328, 208);
            dgvEtapasAtendimento.TabIndex = 17;
            // 
            // btnExcluirEtapa
            // 
            btnExcluirEtapa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExcluirEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluirEtapa.ImageIndex = 2;
            btnExcluirEtapa.ImageList = imlIcones;
            btnExcluirEtapa.Location = new Point(168, 224);
            btnExcluirEtapa.Name = "btnExcluirEtapa";
            btnExcluirEtapa.Size = new Size(144, 32);
            btnExcluirEtapa.TabIndex = 16;
            btnExcluirEtapa.Text = "Excluir Etapa";
            btnExcluirEtapa.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarEtapa
            // 
            btnAdicionarEtapa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAdicionarEtapa.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionarEtapa.ImageIndex = 3;
            btnAdicionarEtapa.ImageList = imlIcones;
            btnAdicionarEtapa.Location = new Point(16, 224);
            btnAdicionarEtapa.Name = "btnAdicionarEtapa";
            btnAdicionarEtapa.Size = new Size(144, 32);
            btnAdicionarEtapa.TabIndex = 15;
            btnAdicionarEtapa.Text = "Adicionar Etapa";
            btnAdicionarEtapa.UseVisualStyleBackColor = true;
            // 
            // txtObservacaoAtendimento
            // 
            txtObservacaoAtendimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtObservacaoAtendimento.Location = new Point(16, 96);
            txtObservacaoAtendimento.Multiline = true;
            txtObservacaoAtendimento.Name = "txtObservacaoAtendimento";
            txtObservacaoAtendimento.Size = new Size(392, 112);
            txtObservacaoAtendimento.TabIndex = 14;
            // 
            // lblEtapaAtendimento
            // 
            lblEtapaAtendimento.AutoSize = true;
            lblEtapaAtendimento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEtapaAtendimento.Location = new Point(16, 32);
            lblEtapaAtendimento.Name = "lblEtapaAtendimento";
            lblEtapaAtendimento.Size = new Size(111, 15);
            lblEtapaAtendimento.TabIndex = 9;
            lblEtapaAtendimento.Text = "EtapaAtendimento";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(16, 48);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(392, 23);
            comboBox2.TabIndex = 9;
            // 
            // lblAtedimento
            // 
            lblAtedimento.AutoSize = true;
            lblAtedimento.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAtedimento.Location = new Point(528, 24);
            lblAtedimento.Name = "lblAtedimento";
            lblAtedimento.Size = new Size(117, 25);
            lblAtedimento.TabIndex = 2;
            lblAtedimento.Text = "Atedimento";
            // 
            // txtAtendimento
            // 
            txtAtendimento.Location = new Point(664, 24);
            txtAtendimento.Name = "txtAtendimento";
            txtAtendimento.Size = new Size(112, 23);
            txtAtendimento.TabIndex = 12;
            // 
            // btnPesquisarCliente
            // 
            btnPesquisarCliente.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPesquisarCliente.Location = new Point(24, 16);
            btnPesquisarCliente.Name = "btnPesquisarCliente";
            btnPesquisarCliente.Size = new Size(152, 23);
            btnPesquisarCliente.TabIndex = 19;
            btnPesquisarCliente.Text = "Pesquisar Cliente";
            btnPesquisarCliente.UseVisualStyleBackColor = true;
            btnPesquisarCliente.Click += btnPesquisarCliente_Click;
            // 
            // FrmAtendimentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 706);
            Controls.Add(btnPesquisarCliente);
            Controls.Add(txtAtendimento);
            Controls.Add(lblAtedimento);
            Controls.Add(cbxEtapasAtendimento);
            Controls.Add(cbxNome);
            Name = "FrmAtendimentos";
            Text = "Atendimentos";
            cbxNome.ResumeLayout(false);
            cbxNome.PerformLayout();
            cbxEtapasAtendimento.ResumeLayout(false);
            cbxEtapasAtendimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEtapasAtendimento).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox cbxNome;
        private GroupBox cbxEtapasAtendimento;
        private ComboBox comboBox1;
        private Label lblObservacao;
        private Label lblSistemaAtendimento;
        private Label lblDataAbertura;
        private Label lblNome;
        private Label lblCod;
        private Label lblEtapaAtendimento;
        private ComboBox comboBox2;
        private Label lblAtedimento;
        private Button btnFinalizar;
        private TextBox txtCodcliente;
        private TextBox txtDataAbertura;
        private TextBox txtObservacao;
        private TextBox txtSituacaoAtedimento;
        private DataGridView dgvEtapasAtendimento;
        private Button btnExcluirEtapa;
        private Button btnAdicionarEtapa;
        private TextBox txtObservacaoAtendimento;
        private TextBox txtAtendimento;
        private Label lblObservacaoAtendimento;
        private Button btnPesquisarCliente;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnEditar;
        private ImageList imlIcones;
        private Button btnNovo;
        private Button btnSalvar;
    }
}