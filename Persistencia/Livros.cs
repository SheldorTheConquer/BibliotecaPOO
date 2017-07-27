using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Livros
    {
        private string arquivo = "Livros.json";

        public List<Modelo.Livros> Selecionar()
        {
            return FileJson<Modelo.Livros>.Selecionar(arquivo);
        }
        public void Inserir(Modelo.Livros l)
        {
            FileJson<Modelo.Livros>.Inserir(arquivo, l);
        }
        public void Atualizar(Modelo.Livros l)
        {
            FileJson<Modelo.Livros>.Atualizar(arquivo, l);
        }
        public void Deletar(Modelo.Livros l)
        {
            FileJson<Modelo.Livros>.Deletar(arquivo, l);
        }
    }
}
