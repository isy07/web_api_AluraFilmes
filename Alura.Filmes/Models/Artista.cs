using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Alura.Filmes.Models;

internal class Artista
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public List<Filme> FilmesAtuados { get; set; }

    public int QuantidadeDeFilmes => FilmesAtuados.Count;


    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>();
    }
    public void AdicionarFilme(Filme filme)
    {
        FilmesAtuados.Add(filme);
        if (!filme.Elencos.Contains(this)) filme.AdicionarElenco(this);
    }

    public void MostrarFilmesAtuados()
    {
        if(FilmesAtuados.Count == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado para {Nome}");
        }
        else
        {
            Console.WriteLine($"Filmes de {Nome}: ");
            foreach(var filme in FilmesAtuados)
            {
                Console.WriteLine($"Filmes de: {filme.Titulo}");
                
            }
        }
    }
}

// CLASSE ARTISTA COMPLETAMENTE ERRADA E NAO FUNCIONA
