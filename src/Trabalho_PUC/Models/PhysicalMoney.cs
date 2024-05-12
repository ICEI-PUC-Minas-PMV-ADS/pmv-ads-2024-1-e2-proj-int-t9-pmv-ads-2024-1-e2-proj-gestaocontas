using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trabalho_PUC.Models
{

    
        [Table("PhysicalMoneys")]
    public class PhysicalMoney
    {
            [KeyAttribute]
            [Required(ErrorMessage = "obrigatorio informar o numero")]
            public int Id { get; set; }
            [Required(ErrorMessage = "obrigatorio informar o numero")]
            public int Valor { get; set; }
            public string Nome { get; set; }
            [Display(Name = "Tipo de gasto")]
            public string Tipogasto { get; set; }
        }

    
}
