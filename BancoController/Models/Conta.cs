namespace BancoController.Models
{
    public class Conta
    {
        public int IdConta { get; set; }
        public double Saldo { get; set; }

        public Cliente Titular;

        public Conta(int idConta, double saldo)
        {
            IdConta = idConta;
            Saldo = saldo;
        }
    }
}
