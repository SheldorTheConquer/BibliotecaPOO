using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Usuario
    {
        
        private string arquivo = "Usuario.json";

        public List<Modelo.Usuario> Selecionar()
        {
            return FileJson<Modelo.Usuario>.Selecionar(arquivo);
        }
        public void Inserir(Modelo.Usuario u)
        {
            FileJson<Modelo.Usuario>.Inserir(arquivo, u);
        }
        public void Atualizar(Modelo.Usuario u)
        {
            FileJson<Modelo.Usuario>.Atualizar(arquivo, u);
        }
        public void Deletar(Modelo.Usuario u)
        {
            FileJson<Modelo.Usuario>.Deletar(arquivo, u);
        }
    }
}
