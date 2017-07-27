using System;
using System.Collections.Generic;
using System.Linq;

namespace Negocio
{
    public class Usuario
    {
        private Persistencia.Usuario per = new Persistencia.Usuario();

        public List<Modelo.Usuario> Selecionar()
        {
            return per.Selecionar();
        }

        public void Inserir(Modelo.Usuario user)
        {
            if(user.login == "" || user.senha == "")
            {
                throw new ArgumentNullException();
            }
            // if fazer um para checar se já existe
            if (per.Selecionar().Where(r => r.login == user.login).Count() > 0 || user.login == "admin")
                throw new InvalidOperationException();          
            per.Inserir(user);
        }

        public void Atualizar(Modelo.Usuario user)
        {
            per.Atualizar(user);
        }

        public void Deletar(Modelo.Usuario user)
        {
            per.Deletar(user);
        }

    }
}
