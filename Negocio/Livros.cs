using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Livros
    {

        private Persistencia.Livros livro = new Persistencia.Livros();

        public List<Modelo.Livros> Selecionar()
        {
            return livro.Selecionar();
        }

        public void Inserir(Modelo.Livros book)
        {
            if (book.titulo == "" || book.editora == "" || book.unidades <= 0)
            {
                throw new ArgumentNullException();
            }

            /*if (book.unidades == 0)
            {
                throw new NumArgumentNullException();
            }*/
            
            if (livro.Selecionar().Where(r => r.titulo == book.titulo).Count() > 0)
                throw new InvalidOperationException();  
            
                
            livro.Inserir(book);
        }

        public void Atualizar(Modelo.Livros book)
        {
            livro.Atualizar(book);
        }

        public void Deletar(Modelo.Livros book)
        {
            livro.Deletar(book);
        }
    }
}
