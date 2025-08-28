namespace SistemaAtendimento.View
{
    partial class frmCadastroEtapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroEtapa));
            btnNovo = new Button();
            cbmDAdosEtapa = new GroupBox();
            lblcodigo = new Label();
            imageList1 = new ImageList(components);
            txtSenha = new TextBox();
            txtNome = new TextBox();
            txtOrdem = new TextBox();
            lblNome = new Label();
            lblOrdem = new Label();
            txtPesquisar = new TextBox();
            btnCancela = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnPesquisar = new Button();
            lblPesquisa = new Label();
            lblSituacao = new Label();
            panel1 = new Panel();
            rdbAtivo = new RadioButton();
            rdbInativo = new RadioButton();
            cbxListaEtapas = new GroupBox();
            dataGridView1 = new DataGridView();
            cbmDAdosEtapa.SuspendLayout();
            panel1.SuspendLayout();
            cbxListaEtapas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 2;
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(16, 240);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // cbmDAdosEtapa
            // 
            cbmDAdosEtapa.Controls.Add(panel1);
            cbmDAdosEtapa.Controls.Add(lblSituacao);
            cbmDAdosEtapa.Controls.Add(lblOrdem);
            cbmDAdosEtapa.Controls.Add(lblNome);
            cbmDAdosEtapa.Controls.Add(txtOrdem);
            cbmDAdosEtapa.Controls.Add(txtNome);
            cbmDAdosEtapa.Controls.Add(txtSenha);
            cbmDAdosEtapa.Controls.Add(lblcodigo);
            cbmDAdosEtapa.Location = new Point(8, 16);
            cbmDAdosEtapa.Name = "cbmDAdosEtapa";
            cbmDAdosEtapa.Size = new Size(776, 160);
            cbmDAdosEtapa.TabIndex = 1;
            cbmDAdosEtapa.TabStop = false;
            cbmDAdosEtapa.Text = "Dados da Etapa";
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Location = new Point(16, 32);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(46, 15);
            lblcodigo.TabIndex = 3;
            lblcodigo.Text = "Código";
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
            // txtSenha
            // 
            txtSenha.Location = new Point(16, 48);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(104, 23);
            txtSenha.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(152, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(408, 23);
            txtNome.TabIndex = 7;
            // 
            // txtOrdem
            // 
            txtOrdem.Location = new Point(16, 112);
            txtOrdem.Name = "txtOrdem";
            txtOrdem.Size = new Size(128, 23);
            txtOrdem.TabIndex = 8;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(160, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(38, 15);
            lblNome.TabIndex = 9;
            lblNome.Text = "nome";
            // 
            // lblOrdem
            // 
            lblOrdem.AutoSize = true;
            lblOrdem.Location = new Point(24, 96);
            lblOrdem.Name = "lblOrdem";
            lblOrdem.Size = new Size(44, 15);
            lblOrdem.TabIndex = 10;
            lblOrdem.Text = "Ordem";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(472, 240);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(104, 23);
            txtPesquisar.TabIndex = 11;
            // 
            // btnCancela
            // 
            btnCancela.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancela.ImageKey = "icone-cancelar.png";
            btnCancela.ImageList = imageList1;
            btnCancela.Location = new Point(368, 240);
            btnCancela.Name = "btnCancela";
            btnCancela.Size = new Size(75, 23);
            btnCancela.TabIndex = 12;
            btnCancela.Text = "Cancelar";
            btnCancela.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 5;
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(280, 240);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageKey = "icone-salvar.png";
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(192, 240);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.ImageKey = "icone-edite.png";
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(104, 240);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageKey = "icone-procurar.png";
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(592, 240);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(48, 23);
            btnPesquisar.TabIndex = 16;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblPesquisa
            // 
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new Point(480, 224);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(57, 15);
            lblPesquisa.TabIndex = 11;
            lblPesquisa.Text = "Pesquisar";
            // 
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(200, 96);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 17;
            lblSituacao.Text = "Situação";
            // 
            // panel1
            // 
            panel1.Controls.Add(rdbInativo);
            panel1.Controls.Add(rdbAtivo);
            panel1.Location = new Point(200, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 32);
            panel1.TabIndex = 17;
            // 
            // rdbAtivo
            // 
            rdbAtivo.AutoSize = true;
            rdbAtivo.Location = new Point(8, 8);
            rdbAtivo.Name = "rdbAtivo";
            rdbAtivo.Size = new Size(51, 19);
            rdbAtivo.TabIndex = 0;
            rdbAtivo.TabStop = true;
            rdbAtivo.Text = "ativo";
            rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            rdbInativo.AutoSize = true;
            rdbInativo.Location = new Point(72, 8);
            rdbInativo.Name = "rdbInativo";
            rdbInativo.Size = new Size(61, 19);
            rdbInativo.TabIndex = 18;
            rdbInativo.TabStop = true;
            rdbInativo.Text = "Inativo";
            rdbInativo.UseVisualStyleBackColor = true;
            // 
            // cbxListaEtapas
            // 
            cbxListaEtapas.Controls.Add(dataGridView1);
            cbxListaEtapas.Location = new Point(16, 288);
            cbxListaEtapas.Name = "cbxListaEtapas";
            cbxListaEtapas.Size = new Size(776, 152);
            cbxListaEtapas.TabIndex = 17;
            cbxListaEtapas.TabStop = false;
            cbxListaEtapas.Text = "Lista de Etapas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(752, 118);
            dataGridView1.TabIndex = 0;
            // 
            // frmCadastroEtapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbxListaEtapas);
            Controls.Add(lblPesquisa);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancela);
            Controls.Add(txtPesquisar);
            Controls.Add(cbmDAdosEtapa);
            Controls.Add(btnNovo);
            Name = "frmCadastroEtapa";
            Text = "Cadastro de Etapas";
            cbmDAdosEtapa.ResumeLayout(false);
            cbmDAdosEtapa.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            cbxListaEtapas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNovo;
        private GroupBox cbmDAdosEtapa;
        private Label lblcodigo;
        private ImageList imageList1;
        private TextBox txtOrdem;
        private TextBox txtNome;
        private TextBox txtSenha;
        private RadioButton rdbInativo;
        private Panel panel1;
        private RadioButton rdbAtivo;
        private Label lblSituacao;
        private Label lblOrdem;
        private Label lblNome;
        private TextBox txtPesquisar;
        private Button btnCancela;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnPesquisar;
        private Label lblPesquisa;
        private GroupBox cbxListaEtapas;
        private DataGridView dataGridView1;
    }
}