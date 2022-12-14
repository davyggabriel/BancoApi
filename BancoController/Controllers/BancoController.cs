using BancoController.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.WebEncoders.Testing;
using System.Globalization;

namespace BancoController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BancoController : ControllerBase
    {
        public static List<Conta> contas = new List<Conta>();

        [HttpPost("Cadastrar")]
        public void Cadastrar([FromBody] Conta novaConta)
        {
            contas.Add(new Conta(novaConta.IdConta, novaConta.Saldo));
        }

        [HttpGet("Listar")]
        public List<Conta> Listar()
        {
            return contas;
        }

        [HttpGet("BuscaPorId/{id}")]
        public Conta BuscarPorID(int id)
        {
            return contas.Where(conta => conta.IdConta == id).FirstOrDefault();
        }

        [HttpPut("Editar/{id}/{valor}")]
        public void Editar(int id, double valor)
        {
            for (int i = 0; i < contas.Count; i++)
            {
                if (id == contas.ToArray()[i].IdConta)
                {
                    contas.ToArray()[i].IdConta = id;
                    contas.ToArray()[i].Saldo = valor;
                }
            }
        }

        [HttpPut("Sacar/{id}/{valorSaque}")]
        public void Sacar(int id, double valorSaque)
        {
            var conta = contas.FirstOrDefault(c => c.IdConta == id);
            conta.Saldo -= valorSaque;
        }

        [HttpPut("Depositar/{id}/{valorDeposito}")]
        public void Depositar(int id, double valorDeposito)
        {
            contas.ForEach(conta => 
            {
                if (conta.IdConta == id)
                {
                    conta.Saldo += valorDeposito;
                }
            });
        }

        [HttpDelete("Deletar/{id}")]
        public void Deletar(int id)
        {
            for (int i = 0; i < contas.Count; i++)
            {
                if (contas.ToArray()[i].IdConta == id)
                {
                    contas.Remove(contas.ToArray()[i]);
                }
            }
        }

        //oi
    }
}
