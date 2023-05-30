using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAtendimento.Modelos.Conta
{
    public class ContaCorrente : IComparable<ContaCorrente>
    {
        private int _numero_agencia;
        private string _conta;
        private double saldo;
        
        public Cliente Titular { get; set; }
        
        public string Nome_Agencia { get; set; }
        
        public int Numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }

        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    saldo = value;
                }
            }
        }

        public static int TotalDeContasCriadas { get; set; }

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        public int CompareTo(ContaCorrente? outro)
        {
            if (outro == null)
            {
                return 1;
            }
            else
            {
                return this.Numero_agencia.CompareTo(outro.Numero_agencia);
            }
        }

        public ContaCorrente()
        {

        }

        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
            Titular = new Cliente();
            TotalDeContasCriadas += 1;
        }

        public ContaCorrente(int numero_agencia)
        {
            Numero_agencia = numero_agencia;
            Conta = Guid.NewGuid().ToString().Substring(0, 8);
            Titular = new Cliente();
            TotalDeContasCriadas += 1;
        }

        public override string ToString()
        {
            return $"=== DADOS DA CONTA ===\nNúmero da Conta : {this.Conta} \nNúmero da Agência: {this.Numero_agencia} \nSaldo da Conta: {this.Saldo} \nTitular da Conta: {this.Titular.Nome} \nCPF do Titular: {this.Titular.Cpf} \nProfissão do Titular: {this.Titular.Profissao}\n\n";
        }
    }
}
