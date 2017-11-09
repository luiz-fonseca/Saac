using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saacp.Models
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public byte Foto { get; set; }
        public DateTime DtNasci { get; set; }
        public bool Sexo {get; set;}
        public string Endereco { get; set; } 

    }
}
