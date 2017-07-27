using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Log
    {

        private string arquivo = "Log.json";

        public List<Modelo.Log> Selecionar()
        {
            return FileJson<Modelo.Log>.Selecionar(arquivo);
        }
        public void Inserir(Modelo.Log o)
        {
            FileJson<Modelo.Log>.Inserir(arquivo, o);
        }
        public void Atualizar(Modelo.Log o)
        {
            FileJson<Modelo.Log>.Atualizar(arquivo, o);
        }
        public void Deletar(Modelo.Log o)
        {
            FileJson<Modelo.Log>.Deletar(arquivo, o);
        }
    }
}
