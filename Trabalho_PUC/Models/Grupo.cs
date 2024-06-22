using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho_PUC.Models
{
    [Table("Grupos")]
    public class Grupo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome do grupo!")]
        [Display(Name = "Nome do grupo")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data!")]
        public DateTime Data {  get; set; }

        [Required(ErrorMessage = "Obrigatório informar o participante/s!")]
        [Display(Name = "Membros")]
        public string Participantes { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o recebedor!")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor!")]
        public decimal Valor { get; set; }
    }
}
