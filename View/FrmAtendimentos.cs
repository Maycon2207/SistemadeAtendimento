using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAtendimento.View
{
    public partial class FrmAtendimentos : Form
    {
        public FrmAtendimentos()
        {
            InitializeComponent();
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            FrmConsultaAtendimento frmConsulta_Atendimento = new FrmConsultaAtendimento();
            frmConsulta_Atendimento.ShowDialog();
        }
    }
}
