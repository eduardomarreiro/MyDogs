using MyDogs.petshops;
using System;
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
                var precoMeuCanino = (QtdDogPequeno * MeuCaninoFeliz.DogPequenoFds) + (QtdDogGrande * MeuCaninoFeliz.DogGrandeFds);
                var precoVaiRex = (QtdDogPequeno * VaiRex.DogPequenoFds) + (QtdDogGrande * VaiRex.DogGrandeFds);
                var precoChowChagas = (QtdDogPequeno * ChowChawgas.DogPequenoFds) + (QtdDogGrande * ChowChawgas.DogGrandeFds);

                List<int> listaDePrecos = new List<int>();

                listaDePrecos.Add(precoMeuCanino);
                listaDePrecos.Add(precoVaiRex);
                listaDePrecos.Add(precoChowChagas);
                listaDePrecos.Sort();


                var menorPreco = $"{listaDePrecos.First()}";
                //return menorPreco;
                Console.WriteLine(menorPreco);
            }
            else
            {
                var precoMeuCanino = $" meu canino {(QtdDogGrande * MeuCaninoFeliz.DogPequenoSemana) + (QtdDogGrande * MeuCaninoFeliz.DogGrandeSemana)}";
                var precoVaiRex = $"vai rex {(QtdDogGrande * VaiRex.DogPequenoSemana) + (QtdDogGrande * VaiRex.DogGrandeSemana)}";
                var precoChowChagas = $"chow chagas {(QtdDogGrande * ChowChawgas.DogPequenoSemana) + (QtdDogGrande * ChowChawgas.DogGrendeSemana)}";

                List<string> listaDePrecos = new List<string>();

                listaDePrecos.Add(precoMeuCanino);
                listaDePrecos.Add(precoVaiRex);
                listaDePrecos.Add(precoChowChagas);
                listaDePrecos.Sort();

                var menorPreco = $"{listaDePrecos.First()}";
                //var petshopMaisBarato = $"{listaDePrecos.Select().min}";

                //return menorPreco;
                Console.WriteLine($"O menor preço é do pet shop{menorPreco}");

                //return $"{menorPreco}";
            }

        }
    }
}
