using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia_2.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = " ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Nome do produto obrigatório...")]
        [StringLength(50)]
        [Display(Name = " Nome: ")]
        public string nome { get; set; }

        [Display(Name = " Estoque: ")]
        [Required (ErrorMessage = "Campo estoque obrigatório...")]
        [Range(1,1000, ErrorMessage = "Esta quantia ultrapassa o nosso estoque")]
        public int estoque { get; set; }

        [Display(Name = " Valor: ")]
        [Required(ErrorMessage = "Valor do produto obrigatório...")]
        public int valor { get; set; }
    }
}
