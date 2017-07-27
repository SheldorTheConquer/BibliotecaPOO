using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario : IId
    {
        public int Id { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        
    }
}
