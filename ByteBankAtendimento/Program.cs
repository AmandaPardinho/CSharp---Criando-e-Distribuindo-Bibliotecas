using bytebank_ATENDIMENTO.bytebank.Atendimento;
using ByteBankAtendimento.Modelos.ADM.Funcionarios;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

new ByteBank_Atendimento().AtendimentoCliente();

public class Estagiario : Funcionario
{
    public Estagiario(double salario, string cpf) : base(salario, cpf)
    {
    }

    public override void AumentarSalario()
    {
        throw new NotImplementedException();
    }

    protected override double getBonificacao()
    {
        throw new NotImplementedException();
    }
}
