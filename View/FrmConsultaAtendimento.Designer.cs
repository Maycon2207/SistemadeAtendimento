namespace SistemaAtendimento.View
{
    partial class Consulta_Atendimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta_Atendimento));
            dgvConsultaAtendimento = new DataGridView();
            btnPesquisar = new Button();
            txtPesquisa = new TextBox();
            cbxFiltro = new ComboBox();
            imageList1 = new ImageList(components);
            grbFiltro = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).BeginInit();
            grbFiltro.SuspendLayout();
            SuspendLayout();
            // 
            // dgvConsultaAtendimento
            // 
            dgvConsultaAtendimento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaAtendimento.Location = new Point(16, 96);
            dgvConsultaAtendimento.Name = "dgvConsultaAtendimento";
            dgvConsultaAtendimento.Size = new Size(768, 344);
            dgvConsultaAtendimento.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            btnPesquisar.ImageAlign = ContentAlignment.MiddleLeft;
            btnPesquisar.ImageKey = "icone-pesquisar.png";
            btnPesquisar.ImageList = imageList1;
            btnPesquisar.Location = new Point(608, 24);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(128, 23);
            btnPesquisar.TabIndex = 1;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(224, 24);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(368, 23);
            txtPesquisa.TabIndex = 3;
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Codigo Atendimento", "Nome Cliente", "CPF/CNPJ" });
            cbxFiltro.Location = new Point(16, 24);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(192, 23);
            cbxFiltro.TabIndex = 4;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "icone-pesquisar.png");
            // 
            // grbFiltro
            // 
            grbFiltro.Controls.Add(cbxFiltro);
            grbFiltro.Controls.Add(btnPesquisar);
            grbFiltro.Controls.Add(txtPesquisa);
            grbFiltro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbFiltro.Location = new Point(8, 8);
            grbFiltro.Name = "grbFiltro";
            grbFiltro.Size = new Size(784, 72);
            grbFiltro.TabIndex = 6;
            grbFiltro.TabStop = false;
            grbFiltro.Text = "Filtrar  por:";
            // 
            // Consulta_Atendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(grbFiltro);
            Controls.Add(dgvConsultaAtendimento);
            Name = "Consulta_Atendimento";
            Text = "Consulta de Atendimento";
            ((System.ComponentModel.ISupportInitialize)dgvConsultaAtendimento).EndInit();
            grbFiltro.ResumeLayout(false);
            grbFiltro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConsultaAtendimento;
        private Button btnPesquisar;
        private TextBox txtPesquisa;
        private ComboBox cbxFiltro;
        private ImageList imageList1;
        private GroupBox grbFiltro;
    }
}