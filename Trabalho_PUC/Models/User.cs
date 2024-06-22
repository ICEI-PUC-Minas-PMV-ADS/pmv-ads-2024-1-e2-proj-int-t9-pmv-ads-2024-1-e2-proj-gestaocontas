using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Trabalho_PUC.Models
{
   
        [Table("Users")]
        public class User
        {
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o nome")]
            public  string Nome { get; set; }


            [Required(ErrorMessage = "Obrigatório informar o senha")]
            [DataType(DataType.Password)]
            public  string Senha { get; set; }

            [Required(ErrorMessage = "Obrigatório informar o senha")]
            public Perfil Perfil { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage = "CPF inválido (digite o CPF da seguinte maneira xxx.xxx.xxx-xx)")]
        public string CPF { get; set; }
    }
        public enum Perfil
        {
            Admin,
            User
        }
   
}
