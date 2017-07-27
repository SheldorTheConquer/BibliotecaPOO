using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Log
    {

        private Persistencia.Log log = new Persistencia.Log();

        public List<Modelo.Log> Selecionar()
        {
            return log.Selecionar();
        }

        public void Inserir(Modelo.Log lo)
        {
            log.Inserir(lo);
        }

        public void Atualizar(Modelo.Log lo)
        {
            log.Atualizar(lo);
        }

        public void Deletar(Modelo.Log lo)
        {
            log.Deletar(lo);
        }
    }
}
