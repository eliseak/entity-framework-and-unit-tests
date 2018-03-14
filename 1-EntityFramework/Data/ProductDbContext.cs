using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ProductDbContext : DbContext
    {
        // Mapeamento
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Loja> Lojas { get; set; }

        public ProductDbContext() : base("Name=ProductDb") // Passa por parâmetro o nome da connectionString
        {
            // Inicializa tabela no banco 
            Database.SetInitializer<ProductDbContext>(new CreateDatabaseIfNotExists<ProductDbContext>());
            Database.Initialize(false);
        }
        
    }
}
