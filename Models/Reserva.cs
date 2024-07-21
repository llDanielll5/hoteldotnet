using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hoteldotnet.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException(
                    "A quantidade de hóspedes é maior que a capacidade da Suíte!"
                );
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            //dias reservados X suite.valordiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            //se reserva maior ou igual 10 dar 10% desconto
            if (DiasReservados >= 10)
            {
                decimal desconto = valor * 10 / 100;
                decimal total = valor - desconto;
                return total;
            }

            return valor;
        }
    }
}
