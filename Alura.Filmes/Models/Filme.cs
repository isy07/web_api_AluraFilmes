using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Filmes.Models;

internal class Filme
{
    public Filme(string titulo, int duracao, List<Artista> elenco)
    {
        if (elenco == null)
        {
            Elencos = new List<Artista>();
        }
        else
        {
          Elencos = elenco;
            foreach(var artista in elenco)
            {
                artista.AdicionarFilme(this);
            }
        }

        Titulo = titulo;
        Duracao = duracao;
    }

    public string Titulo { get; set; }
    public int Duracao { get; set; }
    public List<Artista> Elencos { get; set; } = new();

    public void AdicionarElenco(Artista artista)
    {
        Elencos.Add(artista);
        if (!artista.FilmesAtuados.Contains(this))
        {
            artista.AdicionarFilme(this);
        }
        Console.WriteLine($"{artista} adicionado ao elenco.");
    }

    public void ListarElenco()
    {
        if(Elencos.Count == 0)
        {
            Console.WriteLine("Elenco vazio");
        }
        else
        {
            Console.WriteLine("\nElenco");
            foreach(var artista in Elencos)
            {
                Console.WriteLine($"{artista.Nome}");
            }
        }
    }
}