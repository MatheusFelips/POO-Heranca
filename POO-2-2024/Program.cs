
using POO_2_2024.com.aluno.veiculos.entidades.carros.picape;
using POO_2_2024.com.aluno.veiculos.entidades.carros.sedan;
using POO_2_2024.com.aluno.veiculos.entidades.motos.motocross;
using POO_2_2024.com.aluno.veiculos.entidades.motos.scooter;
using POO_2_2024.TAD.Livros;

/*const int ELEMENTOS_VETOR = 5;
Livro[] vetorLivro = new Livro[ELEMENTOS_VETOR]; 

vetorLivro[0] = new Livro("O Universo numa casca de Noz", "Stephen Hawking", "Física", 2001);
vetorLivro[1] = new Livro("Cem Anos de Solidão", " Gabriel Garcia Matos", "Romance", 1967);
vetorLivro[2] = new Livro("Ariana, a Mulher", " Vinicius de Morais", "Poesia", 1936);
vetorLivro[3] = new Livro("Prosopopeia", "Bento Teixeira", "Poema", 1601);
vetorLivro[4] = new Livro("O guia do mochileiro das galáxias", " Douglas Adams", "Ficção", 1981);

Console.WriteLine("Livros cadastrados no sistema: ");
Console.WriteLine("------ ----------- -- --------");

for (int i = 0; i < ELEMENTOS_VETOR; i++)
{
    Console.WriteLine($"Nome do Livro: {vetorLivro[i].ObterTitulo()}");
    Console.WriteLine($"Autor do Livro: {vetorLivro[i].ObterAutor()}");
    Console.WriteLine($"Gênero do Livro: {vetorLivro[i].ObterGenero()}");
    Console.WriteLine($"Ano de Publicação do Livro: {vetorLivro[i].ObterAnoPublicacao()}");
    if (vetorLivro[i].EhBarroco(vetorLivro[i].ObterAnoPublicacao()))
    {
        Console.WriteLine("O estilo literário do livro é: Barroco!");
    }
    else if (vetorLivro[i].EhModernismo(vetorLivro[i].ObterAnoPublicacao()))
    {
        Console.WriteLine("O estilo literário do livro é: Modernista!");
    }
    else
    {
        Console.WriteLine("O estilo literário do livro é: Indefinido");
    }

    Console.WriteLine("============================");
}

Livro[] livrosOrdenados = Livro.OrdernarPorAnoPublicacao(vetorLivro);

Console.WriteLine("");
Console.WriteLine("Livros Ordenados por Ano de Publicação");
Console.WriteLine("------ --------- --- --- -- ----------");
Console.WriteLine("");

foreach (Livro livro in livrosOrdenados)
{
    Console.WriteLine($"Nome do Livro: {livro.ObterTitulo()}");
    Console.WriteLine($"Autor do Livro: {livro.ObterAutor()}");
    Console.WriteLine($"Gênero do Livro: {livro.ObterGenero()}");
    Console.WriteLine($"Ano de Publicação do Livro: {livro.ObterAnoPublicacao()}");
    if (livro.EhBarroco(livro.ObterAnoPublicacao()))
    {
        Console.WriteLine("O estilo literário do livro é: Barroco!");
    }
    else if (livro.EhModernismo(livro.ObterAnoPublicacao()))
    {
        Console.WriteLine("O estilo literário do livro é: Modernista!");
    }
    else
    {
        Console.WriteLine("O estilo literário do livro é: Indefinido");
    }

    Console.WriteLine("============================");
}

Console.WriteLine("");
Console.WriteLine("Buscas Realizadas por Autor");
Console.WriteLine("------ ---------- --- ----- ");
Console.WriteLine("");

Console.WriteLine("Pesquisa realizada por Autor: Bento");
Livro[] livrosPorAutor = Livro.PesquisarObraPorAutor(livrosOrdenados,"Bento");
Console.WriteLine(livrosPorAutor.Length);
if(livrosPorAutor.Length == 0){
    Console.WriteLine("Autor não Encontrado");
}
else
{
    foreach (Livro livro in livrosPorAutor)
    {
        Console.Write(livro.ObterAutor());
    }

}
Console.WriteLine("============================");

Console.WriteLine("Pesquisa realizada por Autor: ra");
Livro[] livrosPorAutor2 = Livro.PesquisarObraPorAutor(livrosOrdenados, "ra");
if (livrosPorAutor2.Length == 0)
{
    Console.WriteLine("Autor não Encontrado");
}
else
{
    foreach (Livro livro in livrosPorAutor2)
    {
        Console.Write(livro.ObterAutor());
    }

}
Console.WriteLine("============================");

Console.WriteLine("Pesquisa realizada por Autor: Rafael");
Livro[] livrosPorAutor3 = Livro.PesquisarObraPorAutor(livrosOrdenados, "Rafael");
if (livrosPorAutor3.Length == 0)
{
    Console.WriteLine("Autor não Encontrado");
}
else
{
    foreach (Livro livro in livrosPorAutor3)
    {
        Console.Write(livro.ObterAutor());
    }

}
Console.WriteLine("============================");*/

Console.WriteLine("PICAPE");
Picape picape = new Picape("12343", "BJD7611", 4, 1800);
picape.mostrar();

Console.WriteLine("===================");
Console.WriteLine("Sedan");
Sedan sedan = new Sedan("19832", "AU3278A", 3, 3);
sedan.mostrar();

Console.WriteLine("===================");
Console.WriteLine("Scooter");
Scooter scooter = new Scooter("17882", "789ACD2", true);
scooter.mostrar();

Console.WriteLine("===================");

Console.WriteLine("MotoCross");
Motocross motocross = new Motocross("1234","ABM2312",true);
motocross.mostrar();
