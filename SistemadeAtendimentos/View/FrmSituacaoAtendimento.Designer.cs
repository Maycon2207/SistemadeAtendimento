namespace SistemaAtendimento.View
{
    partial class FrmSituacaoAtendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSituacaoAtendimento));
            grbListaEtapas = new GroupBox();
            dataGridView1 = new DataGridView();
            grbDadosEtapas = new GroupBox();
            lblNome = new Label();
            lblCodigo = new Label();
            txtCor = new TextBox();
            lblCor = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            lblpesquisar = new Label();
            btnPesquisar = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnNovo = new Button();
            panel1 = new Panel();
            rdbInativo = new RadioButton();
            rdbAtivo = new RadioButton();
            lblSituacao = new Label();
            textBox1 = new TextBox();
            imageList1 = new ImageList(components);
            grbListaEtapas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grbDadosEtapas.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grbListaEtapas
            // 
            grbListaEtapas.Controls.Add(dataGridView1);
            grbListaEtapas.Location = new Point(12, 281);
            grbListaEtapas.Name = "grbListaEtapas";
            grbListaEtapas.Size = new Size(776, 152);
            grbListaEtapas.TabIndex = 23;
            grbListaEtapas.TabStop = false;
            grbListaEtapas.Text = "Lista de Etapas";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 128);
            dataGridView1.TabIndex = 0;
            // 
            // grbDadosEtapas
            // 
            grbDadosEtapas.Controls.Add(panel1);
            grbDadosEtapas.Controls.Add(lblSituacao);
            grbDadosEtapas.Controls.Add(lblNome);
            grbDadosEtapas.Controls.Add(lblCodigo);
            grbDadosEtapas.Controls.Add(txtCor);
            grbDadosEtapas.Controls.Add(lblCor);
            grbDadosEtapas.Controls.Add(txtCodigo);
            grbDadosEtapas.Controls.Add(txtNome);
            grbDadosEtapas.Location = new Point(12, 17);
            grbDadosEtapas.Name = "grbDadosEtapas";
            grbDadosEtapas.Size = new Size(776, 152);
            grbDadosEtapas.TabIndex = 22;
            grbDadosEtapas.TabStop = false;
            grbDadosEtapas.Text = "Dados da Etapas";
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
            lblCodigo.Location = new Point(24, 24);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // txtCor
            // 
            txtCor.Location = new Point(23, 103);
            txtCor.Name = "txtCor";
            txtCor.Size = new Size(264, 23);
            txtCor.TabIndex = 5;
            // 
            // lblCor
            // 
            lblCor.AutoSize = true;
            lblCor.Location = new Point(40, 88);
            lblCor.Name = "lblCor";
            lblCor.Size = new Size(26, 15);
            lblCor.TabIndex = 7;
            lblCor.Text = "Cor";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(16, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(144, 40);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(576, 23);
            txtNome.TabIndex = 4;
            // 
            // lblpesquisar
            // 
            lblpesquisar.AutoSize = true;
            lblpesquisar.Location = new Point(500, 201);
            lblpesquisar.Name = "lblpesquisar";
            lblpesquisar.Size = new Size(57, 15);
            lblpesquisar.TabIndex = 20;
            lblpesquisar.Text = "Pesquisar";
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageKey = "icone-procurar.png";
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(692, 217);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 19;
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.ImageAlign = ContentAlignment.MiddleRight;
            btnEditar.ImageIndex = 1;
            btnEditar.ImageList = imageList1;
            btnEditar.Location = new Point(100, 217);
            btnEditar.Name = "btnEditar";
            btnEditar.RightToLeft = RightToLeft.Yes;
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalvar.ImageIndex = 4;
            btnSalvar.ImageList = imageList1;
            btnSalvar.Location = new Point(180, 217);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 17;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.ImageIndex = 5;
            btnExcluir.ImageList = imageList1;
            btnExcluir.Location = new Point(260, 217);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.ImageIndex = 0;
            btnCancelar.ImageList = imageList1;
            btnCancelar.Location = new Point(340, 217);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 24);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNovo.ImageIndex = 2;
            btnNovo.ImageList = imageList1;
            btnNovo.Location = new Point(20, 217);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 14;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdbInativo);
            panel1.Controls.Add(rdbAtivo);
            panel1.Location = new Point(320, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 32);
            panel1.TabIndex = 18;
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
            // lblSituacao
            // 
            lblSituacao.AutoSize = true;
            lblSituacao.Location = new Point(320, 80);
            lblSituacao.Name = "lblSituacao";
            lblSituacao.Size = new Size(52, 15);
            lblSituacao.TabIndex = 19;
            lblSituacao.Text = "Situação";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(496, 216);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 23);
            textBox1.TabIndex = 20;
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
            // FrmSituacaoAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(grbListaEtapas);
            Controls.Add(grbDadosEtapas);
            Controls.Add(lblpesquisar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnNovo);
            Name = "FrmSituacaoAtendimento";
            Text = "Cadastro Status Atendimentos";
            grbListaEtapas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grbDadosEtapas.ResumeLayout(false);
            grbDadosEtapas.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbListaEtapas;
        private DataGridView dataGridView1;
        private GroupBox grbDadosEtapas;
        private Label lblNome;
        private Label lblCodigo;
        private TextBox txtCor;
        private Label lblCor;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private Label lblpesquisar;
        private Button btnPesquisar;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnNovo;
        private Panel panel1;
        private RadioButton rdbInativo;
        private RadioButton rdbAtivo;
        private Label lblSituacao;
        private ImageList imageList1;
        private TextBox textBox1;
    }
}