using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace contasAPagar.Model
{
    public class ContaModel
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
        public string NomeCredor { get; set; }
        public DateTime? DataPagamento { get; set; }
    }
}
