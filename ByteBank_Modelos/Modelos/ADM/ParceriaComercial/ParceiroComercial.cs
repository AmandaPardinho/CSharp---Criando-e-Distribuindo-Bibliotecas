using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBankAtendimento.Modelos.ADM.SistemaInterno;

namespace ByteBankAtendimento.Modelos.ADM.ParceriaComercial
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
