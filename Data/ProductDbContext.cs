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
        public DbSet<Produto> Produtos { get; set; }

        public ProductDbContext() : base("Name=ProductDb") // Passa por parâmetro o nome da connectionString
        {
            // Inicializa tabela no banco 
            Database.SetInitializer<ProductDbContext>(new CreateDatabaseIfNotExists<ProductDbContext>());
        }
        
    }
}
