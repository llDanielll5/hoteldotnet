using System.Text;
using hoteldotnet.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new("Daniel", "Mota");
Pessoa p2 = new("Gabrielli", "Dourado");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new("Premium", 3, 30);

//Cria uma nova reserva, passando a suíte e os hóspedes
//gerar exceção caso a quantidade de hóspedes for maior que a capacidade da suíte

Reserva reserva = new(10); //se reserva for >= 10 ganhar 10% de desconto
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor das diárias: {reserva.CalcularValorDiaria()}");
