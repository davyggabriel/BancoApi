namespace BancoController.Models
{
    public class Conta
    {
        public int IdConta { get; set; }
        public double Saldo { get; set; }

        public Cliente Titular { get; set; }

        public Conta(int idConta, double saldo, Cliente titular)
        {
            IdConta = idConta;
            Saldo = saldo;
            Titular = titular;
        }
    }
}
