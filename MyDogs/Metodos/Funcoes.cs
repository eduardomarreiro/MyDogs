using MyDogs.petshops;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDogs.Metodos
{
    public class Funcoes
    {
        MeuCaninoFeliz MeuCaninoFeliz = new MeuCaninoFeliz();
        VaiRex VaiRex = new VaiRex();
        ChowChawgas ChowChawgas = new ChowChawgas();

        public string DiaDaSemana()
        {
            Console.WriteLine("Por favor digite uma data no formato dd/MM/yyyy");
            var digito = Console.ReadLine();

            var data = Convert.ToDateTime(digito);
            var fds = data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
            if (fds == true)
            {
                var FimDeSemana = $"A data escolhida  {data.ToString("dddd, dd MMMM")} é um dia de fim de semana.";
                Console.WriteLine(FimDeSemana);
                return FimDeSemana;
            }
            else
            {
                var DiaUtil = $"A data escolhida é {data.ToString("dddd, dd, MMMM")} é um dia de semana";
                Console.WriteLine(DiaUtil);
                return DiaUtil;
            }
        }

        public string MenorDistancia()
        {
            var DistanciaMeuCaninoFelix = MeuCaninoFeliz.Distancia;
            var DistanciaVaiRex = VaiRex.Distancia;
            var DistanciaChowChagas = ChowChawgas.Distancia;

            if (DistanciaChowChagas < DistanciaVaiRex && DistanciaChowChagas < DistanciaMeuCaninoFelix)
            {
                return "Chow Chagas é o petshop mais perto";
            }
            else if (DistanciaVaiRex < DistanciaChowChagas && DistanciaVaiRex < DistanciaMeuCaninoFelix)
            {
                return "Vai Rex é o petshop mais perto";
            }
            else
            {
                return "O petshoo mais perto é Meu Canino Feliz";
            }
        }

        public void LocalMaisBarato(/*string Dia, int QtdDogPequeno, int QtdDogGrande*/)
        {
            Console.WriteLine("Por favor digite uma data no formato dd/MM/yyyy");
            var Dia = Console.ReadLine();
            var data = Convert.ToDateTime(Dia);

            Console.WriteLine("Por favor digite a quantidade de cachorros pequenos");
            var QtdDogPequeno = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Por favor digite a quantidade de cachorros grandes");
            var QtdDogGrande = Int32.Parse(Console.ReadLine());
            
            var fds = data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday;
            if (fds == true)
            {
                var orcamento1 = new Orcamento();
                var orcamento2 = new Orcamento();
                var orcamento3 = new Orcamento();

                orcamento1.Nome = "Meu canino";
                orcamento1.Preco = (QtdDogPequeno * MeuCaninoFeliz.DogPequenoFds) + (QtdDogGrande * MeuCaninoFeliz.DogGrandeFds);

                orcamento2.Nome = "Vai Rex";
                orcamento2.Preco = (QtdDogPequeno * VaiRex.DogPequenoFds) + (QtdDogGrande * VaiRex.DogGrandeFds);

                orcamento3.Nome = "Chow Chagas";
                orcamento3.Preco = (QtdDogPequeno * ChowChawgas.DogPequenoFds) + (QtdDogGrande * ChowChawgas.DogGrandeFds);

                List<Orcamento> lista = new List<Orcamento>()
                {
                    orcamento1,
                    orcamento2,
                    orcamento3
                };
                lista.Select(x => x.Preco);
                lista.Select(x => x.Nome);
                lista.OrderBy(x => x.Preco);
                
                Console.WriteLine("O menor preço está no " + lista.First());
            }
            else
            {
                var orcamento1 = new Orcamento();
                var orcamento2 = new Orcamento();
                var orcamento3 = new Orcamento();

                orcamento1.Nome = "Meu Canino";
                orcamento1.Preco = (QtdDogGrande * MeuCaninoFeliz.DogPequenoSemana) + (QtdDogGrande * MeuCaninoFeliz.DogGrandeSemana);

                orcamento2.Nome = "Vai Rex";
                orcamento2.Preco = (QtdDogGrande * VaiRex.DogPequenoSemana) + (QtdDogGrande * VaiRex.DogGrandeSemana);

                orcamento3.Nome = "Chow Chagas";
                orcamento3.Preco = (QtdDogGrande * ChowChawgas.DogPequenoSemana) + (QtdDogGrande * ChowChawgas.DogGrendeSemana);

                List<Orcamento> lista = new List<Orcamento>()
                {
                    orcamento1,
                    orcamento2,
                    orcamento3
                };

                lista.Select(x => x.Preco);
                lista.Select(x => x.Nome);
                lista.OrderBy(x => x.Preco);

                Console.WriteLine("O menor preço está no " + lista.First());
            }

        }
    }
}
