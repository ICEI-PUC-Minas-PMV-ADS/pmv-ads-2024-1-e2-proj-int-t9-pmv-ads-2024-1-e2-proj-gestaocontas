using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho_PUC.Models
{
    [Table("Boletos")]
    public class Boletos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        [Display (Name ="Nome do Boleto")]
        public string NomeBoleto { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data de vencimento!")]
        [Display(Name = "Data de Vencimento")]
        public string DataVencimento { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo!")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Valor!")]

        public int Valor { get; set; }


    }
}
