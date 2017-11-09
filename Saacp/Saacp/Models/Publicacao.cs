using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saacp.Models
{
    public class Publicacao
    {
        public int CodPublicaco { get; set; }
        public int CodGrupo { get; set; }
        public int Cod_Pessoa { get; set; }
        public byte Foto { get; set; }
        public string Texto { get; set; }
    }
}
