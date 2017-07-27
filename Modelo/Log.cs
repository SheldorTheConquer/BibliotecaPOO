using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Log : IId
    {
        public int Id { get; set; }
        public DateTime data { get; set; }
        public string usuario { get; set; }


    }
}
