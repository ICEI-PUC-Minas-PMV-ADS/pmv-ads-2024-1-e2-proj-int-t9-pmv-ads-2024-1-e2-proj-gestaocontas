
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trabalho_PUC.Models
{
    [Table("CardExpense")]
    public class CardExpenses
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar os ultimos 4 digitos do cartão")]
        [Display(Name = "4 Digistos")]
        public int Nome { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o Nome do cartão")]
        [Display(Name = "Nome do cartão")]
        public string? Local { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar a data de vencimento do cartão")]
        [Display(Name = "Data de vencimento")]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "Obrigatorio informar a Meta de Gastos do cartão")]
        [Display(Name = "Meta de gastos")]
        public int Valor { get; set; }
    }
}
