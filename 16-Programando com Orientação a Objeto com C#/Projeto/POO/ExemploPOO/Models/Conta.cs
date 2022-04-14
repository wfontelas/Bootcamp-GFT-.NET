public abstract class Conta
{
    protected double Saldo;
    public abstract void Creditar(double valor); //Metodo Abstrato é obrigado a sobrescrever na classe filha que herdou da classe abstrata
    public void ExibirSaldo()
    {
        System.Console.WriteLine("Seu saldo é: R$ " + Saldo);
    }

    



}