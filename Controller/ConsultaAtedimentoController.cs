using System;
using SistemaAtendimento.View;
using SistemaAtendimento.Repositories;

namespace SistemaAtendimento.Controller
{
    public class ConsultaAtendimentoController
    {
        private FrmConsultaAtendimento _frmConsultaAtendimento;
        private AtendimentoRepository _atendimentoRepository;

        public ConsultaAtendimentoController(FrmConsultaAtendimento view)
        {
            _frmConsultaAtendimento = view;
            _atendimentoRepository = new AtendimentoRepository();
        }

        public void ListarAtendimento(string termo = "", string condicao = "")
        {
            try
            {

            }
            catch (Exception ex)
            {
                // tratar ou exibir erro
            }
        }
    }
}
