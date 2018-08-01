using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria_Core.Models
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Cadastro { get; set; } = DateTime.Now;
        public bool Inativo { get; set; } = false;
    }
}
