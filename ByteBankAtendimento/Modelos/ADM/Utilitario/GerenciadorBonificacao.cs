using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankAtendimento.Modelos.ADM.Funcionarios;

namespace ByteBankAtendimento.Modelos.ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.getBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
