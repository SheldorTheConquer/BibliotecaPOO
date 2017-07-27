using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Livros : IId
    {
        public int Id { get; set; }
        public string titulo { get; set; }
        public string editora { get; set; }
        public int unidades { get; set; }

    }
}
