using Alura.Filmes.Models;

Artista artista1 = new Artista("Isabela Costa", 23);
Artista artista2 = new Artista("Juliana Correia", 30);
Artista artista3 = new Artista("Mariana Banana", 35);
Artista artista4 = new Artista("Jhone Lima", 22);

List<Artista> elenco = new List<Artista> { artista1, artista2};

List<Artista> elenco2 = new List<Artista> { artista3, artista4 };

Filme filme1 = new Filme("Barata morta", 150, elenco);

Filme filme2 = new Filme("O retorno da barata", 123, elenco2);

filme1.ListarElenco();
filme2.ListarElenco();








//List<Filme>listaDeFilmes = new List<Filme>();
//// Criando uma lista de elenco para um filme
//List<string> elencoDoFilme1 = new List<string>();
//elencoDoFilme1.Add("Daniel Rudcluff");
//elencoDoFilme1.Add("Emma Watson");
//elencoDoFilme1.Add("Ruppert Grint");

//Filme filme1 = new Filme("Harry Potter", 120, elencoDoFilme1);


//List<string> elencoDoFilme2 = new List<string>();
//elencoDoFilme2.Add("Maria Filomena");
//elencoDoFilme2.Add("José Bezerra");
//elencoDoFilme2.Add("Luana Lua");


//Filme filme2 = new Filme("Narnia", 180, elencoDoFilme2);

//List<string> elencoDoFilme3 = new List<string>();
//elencoDoFilme3.Add("Lucia Oliveira");
//elencoDoFilme3.Add("Joao Cordeiro");
//elencoDoFilme3.Add("Jhone Lima");


//Filme filme3 = new Filme("Piratas do Brasil", 200, elencoDoFilme3);

//List<string> elencoDoFilme4 = new List<string>();
//elencoDoFilme4.Add("Isabella Costa");
//elencoDoFilme4.Add("Layse Prado");
//elencoDoFilme4.Add("Scooby Lima");


//Filme filme4 = new Filme("Desenvolvedor Triste", 150, elencoDoFilme4);

//List<string> elencoDoFilme5 = new List<string>();
//elencoDoFilme5.Add("Elizabeth Lisa ");
//elencoDoFilme5.Add("Adriana Doi");
//elencoDoFilme5.Add("Jack Potter");


//Filme filme5 = new Filme("Parede Verde", 130, elencoDoFilme5);

//List<Filme>filmesFavoritos = new List<Filme>();
//filmesFavoritos.Add(filme1);
//filmesFavoritos.Add(filme2);
//filmesFavoritos.Add(filme3);
//filmesFavoritos.Add(filme4);
//filmesFavoritos.Add(filme5);


//foreach (Filme filme in filmesFavoritos)
//{
//    Console.WriteLine($"\nFilme:{filme.Titulo}");
//    Console.WriteLine($"Duração:{filme.Duracao}");
//    Console.WriteLine($"Elenco:");

//    foreach (var elenco in filme.Elencos)
//    {
//        Console.WriteLine(elenco);
//    }
//}

