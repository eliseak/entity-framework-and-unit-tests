using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    [Table ("Loja")] //Data notation: especifica o nome da tabela
    public class Loja
    {
        public Loja()
        {
            Produtos = new List<Produto>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(200)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(2000)]
        public string Descricao { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }
    }
}
