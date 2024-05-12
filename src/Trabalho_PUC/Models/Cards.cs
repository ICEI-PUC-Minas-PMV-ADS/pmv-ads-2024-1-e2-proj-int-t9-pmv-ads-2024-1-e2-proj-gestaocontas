using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trabalho_PUC.Models
{
    [Table("Cards")]
    public class Card
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Obrigatorio informar os ultimos 4 digitos do cartão")]
        [Display(Name ="4 Digistos")]
        public int Digitos { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Nome do cartão")]
        [Display(Name = "Nome do cartão")]
        public string? Nome { get; set; }
      
        [Required(ErrorMessage = "Obrigatorio informar a data de vencimento do cartão")]
        [Display(Name = "Data de vencimento")]
        public DateTime Vencimento { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar a Meta de Gastos do cartão")]
        [Display(Name = "Meta de gastos")]
        public int Meta { get; set; }
    }
}
