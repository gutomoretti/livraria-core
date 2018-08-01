using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria_Core.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Autor { get; set; }
        public DateTime Cadastro { get; set; } = DateTime.Now;
        public bool Inativo { get; set; } = false;

        public virtual Genero Genero { get; set; }
    }
}
