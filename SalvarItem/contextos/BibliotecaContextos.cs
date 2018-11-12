using SalvarItem.model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalvarItem.contextos
{
    public class BibliotecaContextos : DbContext
    {

        public BibliotecaContextos() : base(nameOrConnectionString: "biblioteca")
        {
            Database.SetInitializer<BibliotecaContextos>(new BibliotecaContextosInitializer());

        }
        public DbSet<Livro> Livros { get; set; }


        public class BibliotecaContextosInitializer : DropCreateDatabaseAlways<BibliotecaContextos>
        {

        }

    }
    }
