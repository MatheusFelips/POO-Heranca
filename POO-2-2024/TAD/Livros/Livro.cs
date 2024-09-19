using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_2_2024.TAD.Livros
{
    public class Livro
    {
        private string titulo;
        private string autor;
        private string genero;
        private int anoPublicacao;
        

        public Livro()
        {
            
        }

        public Livro(string _titulo, string _autor, string _genero, int _anoPublicacao)
        {
            titulo = _titulo;
            autor = _autor;
            genero = _genero;
            anoPublicacao = _anoPublicacao;
        }

       public string ObterTitulo()
        {
            return titulo;
        }
        public string ObterAutor()
        {
            return autor;
        }
        public string ObterGenero()
        {
            return genero;
        }
        public int ObterAnoPublicacao()
        {
            return anoPublicacao;
        }

        public bool EhModernismo(int _anoPublicacao)
        {
            if (_anoPublicacao >= 1930 && _anoPublicacao <= 1945) return true;
            
            return false;

        }
        public bool EhBarroco(int _anoPublicacao)
        {
            if (_anoPublicacao >= 1601 && _anoPublicacao <= 1768) return true;

            return false;

        }

        public static Livro[] OrdernarPorAnoPublicacao(Livro[] livros)
        {
            var livrosOrdenados =  livros.OrderBy(livro => livro.anoPublicacao).ToArray();

            return livrosOrdenados;
        }

        public static Livro[] PesquisarObraPorAutor(Livro[] livros, string _autor)
        {
            var livrosPorAutor = Array.FindAll(livros, livro => livro.ObterAutor().ToLower() == _autor.ToLower()).ToArray();

            return livrosPorAutor;
            //return Array.FindAll(livros, livro => livro.autor.Equals(_autor, StringComparison.OrdinalIgnoreCase));
        }

    }
} 
    
