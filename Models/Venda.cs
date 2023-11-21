using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Farmacia_2.Models
{
    [Table("Vendas")]
    public class Venda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = " ID: ")]
        public int id { get; set; }

        [Required(ErrorMessage = "Nome do farmaceutico obrigatório...")]
        [Display(Name = " Nome do Farmaceutico: ")]
        public string nomefarmaceutico { get; set; }

        [Required(ErrorMessage = "Nome do produto obrigatório...")]
        [Display(Name = " Nome do Produto: ")]
        public string nomeproduto { get; set; }

        [Required(ErrorMessage = "Nome do Cliente obrigatório...")]
        [Display(Name = " Nome do Cliente: ")]
        public string nomecliente { get; set; }

        [Required(ErrorMessage = "Quantiade da venda obrigatório...")]
        [Display(Name = " Quantidade: ")]
        public int qntd { get; set; }

    }
}
