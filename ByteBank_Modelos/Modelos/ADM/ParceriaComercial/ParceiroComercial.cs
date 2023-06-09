﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank_Modelos.Modelos.ADM.Utilitario;
using ByteBankAtendimento.Modelos.ADM.SistemaInterno;

namespace ByteBankAtendimento.Modelos.ADM.ParceriaComercial
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        internal AutenticacaoUtil Autenticador { get; set; }

        public bool Autenticar(string senha)
        {
            return this.Autenticador.ValidarSenha(this.Senha, senha);
        }
    }
}
