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

        public void LocalMaisBarato()
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

                if (precoMeuCanino < precoVaiRex && precoMeuCanino < precoChowChagas)
                {
                    Console.WriteLine($"O menor preço está no petshop Meu Canino Feliz, o preço é R${precoMeuCanino},00");
                }
                else if (precoVaiRex < precoMeuCanino && precoVaiRex < precoChowChagas)
                {
                    Console.WriteLine($"O menor preço está no petshop Vai Rex, o preço é R${precoVaiRex},00");
                }
                else if (precoChowChagas < precoVaiRex && precoChowChagas < precoMeuCanino)
                {
                    Console.WriteLine($"O menor preço está no petshop Chow Chagas, o preço é R${precoChowChagas},00");
                }

                // CRITERIO DE DESEMPATE

                else if((precoMeuCanino == precoVaiRex) && precoMeuCanino == precoChowChagas)
                {
                    Console.WriteLine($"todos petshops estão com o mesmo preço, R${precoChowChagas},00 sugerimos que leve seus cães no Chow Chagas por ser mais perto");
                }
                else if ((precoMeuCanino == precoVaiRex) && precoVaiRex < precoChowChagas)
                {
                    Console.WriteLine($"Os petshops Meu Canino Feliz e Vai Rex estão com o mesmo preço, R${precoVaiRex},00 sugerimos que leve seus cães no Vai Rex por ser mais perto");
                }
                else if ((precoVaiRex == precoChowChagas) && precoChowChagas < precoMeuCanino)
                {
                    Console.WriteLine($"Os petshops Vai Rex e Chow Chagas estão com o mesmo preço, R${precoChowChagas},00 sugerimos que leve seus cães no Chow Chagas por ser mais perto");
                }
                else if ((precoMeuCanino == precoChowChagas) && precoChowChagas < precoVaiRex)
                {
                    Console.WriteLine($"Os petshops Meu Canino Feliz e Chow Chagas estão com o mesmo preço, R${precoChowChagas},00 sugerimos que leve seus cães no Chow Chagas por ser mais perto");
                }
            }
            else
            {

                var precoMeuCanino = (QtdDogPequeno * MeuCaninoFeliz.DogPequenoSemana) + (QtdDogGrande * MeuCaninoFeliz.DogGrandeSemana);

                var precoVaiRex = (QtdDogPequeno * VaiRex.DogPequenoSemana) + (QtdDogGrande * VaiRex.DogGrandeSemana);

                var precoChowChagas = (QtdDogPequeno * ChowChawgas.DogPequenoSemana) + (QtdDogGrande * ChowChawgas.DogGrendeSemana);

                if (precoMeuCanino < precoVaiRex && precoMeuCanino < precoChowChagas)
                {
                    Console.WriteLine($"O menor preço está no petshop Meu Canino Feliz, o preço é R${precoMeuCanino},00");
                }
                else if (precoVaiRex < precoMeuCanino && precoVaiRex < precoChowChagas)
                {
                    Console.WriteLine($"O menor preço está no petshop Vai Rex, o preço é R${precoVaiRex},00");
                }
                else if (precoChowChagas < precoVaiRex && precoChowChagas < precoMeuCanino)
                {
                    Console.WriteLine($"O menor preço está no petshop Chow Chagas, o preço é R${precoChowChagas},00");
                }

                // CRITERIO DE SEMPATE

                else if ((precoMeuCanino == precoVaiRex) && precoMeuCanino == precoChowChagas)
                {
                    Console.WriteLine($"todos petshops estão com o mesmo preço, R${precoChowChagas},00 sugerimos que leve seus cães no Chow Chagas por ser mais perto");
                }
                else if ((precoMeuCanino == precoVaiRex) && precoVaiRex < precoChowChagas)
                {
                    Console.WriteLine($"Os petshops Meu Canino Feliz e Vai Rex estão com o mesmo preço, R${precoVaiRex},00 sugerimos que leve seus cães no Vai Rex por ser mais perto");
                }
                else if ((precoVaiRex == precoChowChagas) && precoChowChagas < precoMeuCanino)
                {
                    Console.WriteLine($"Os petshops Vai Rex e Chow Chagas estão com o mesmo preço, R${precoChowChagas},00 sugerimos que leve seus cães no Chow Chagas por ser mais perto");
                }
                else if ((precoMeuCanino == precoChowChagas) && precoChowChagas < precoVaiRex)
                {
                    Console.WriteLine($"Os petshops Meu Canino Feliz e Chow Chagas estão com o mesmo preço, R${precoChowChagas},00 sugerimos que leve seus cães no Chow Chagas por ser mais perto");
                }
            }
        }
    }
}
