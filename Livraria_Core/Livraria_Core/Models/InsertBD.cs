using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria_Core.Models
{
    public class InsertBD
    {
        public static void Initialize(LivrariaDbContext context)
        {
            context.Database.EnsureCreated();
            // Procura por livros
            if (context.livros.Any())
            {
                return;   //O BD foi alimentado
            }
            var livros = new Livro[]
            {
              new Livro{Nome="Livro 1 - EF", Descricao="Descrição Livro 1", Autor="Macoratti", Cadastro = DateTime.Now, Inativo = false},
              new Livro{Nome="Livro 2 - MySQL", Descricao="Descrição Livro 2", Autor="Autor livro 2", Cadastro = DateTime.Now, Inativo = false},
            };
            foreach (Livro p in livros)
            {
                context.livros.Add(p);
            }
            context.SaveChanges();
        }
    }
}
