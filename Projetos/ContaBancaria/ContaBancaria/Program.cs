namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao banco da etec MCM!");

            //Instanciar a classe da Conta e criar um objeto dela
            Conta conta = new Conta();

            conta.consulta_saldo();

            conta.depositar(1000.35);
            conta.consulta_saldo();

            conta.sacar(500);
            consulta.saldo();
          
        }
    }
}