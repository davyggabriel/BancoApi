namespace BancoController.Models
{
    public class ContaDeMenor : Conta
    {
        public ContaDeMenor(int idConta, double saldo, Cliente titular) : base(idConta, saldo, titular)
        {      
         
        }
    }
}
