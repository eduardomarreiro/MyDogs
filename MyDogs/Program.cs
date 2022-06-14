// See https://aka.ms/new-console-template for more information

using MyDogs.Metodos;
using MyDogs.petshops;
using System.Collections;

var funcoes = new Funcoes();

//funcoes.LocalMaisBarato();

var orcamento1 = new Orcamento();
var orcamento2 = new Orcamento();
var orcamento3 = new Orcamento();

orcamento1.Nome = "Meu Canino";
orcamento1.Preco = 40;

orcamento2.Nome = "Vai Rex";
orcamento2.Preco = 35;

orcamento3.Nome = "Chow Chagas";
orcamento3.Preco = 80;

var lista = new List<Orcamento>()
{
    orcamento1,
    orcamento2,
    orcamento3
};

var item = lista.OrderBy(x => x.Preco).ToList();

Console.WriteLine(String.Join(Environment.NewLine, item));
