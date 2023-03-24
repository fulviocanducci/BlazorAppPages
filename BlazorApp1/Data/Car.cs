using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data
{
   [Table("cars")]
   public class Car
   {
      [Key()]
      public long Id { get; set; }

      [Required(ErrorMessage = "Digite o nome do carro.")]
      [MaxLength(100, ErrorMessage = "Máximo 100 caracteres.")]
      public string Name { get; set; } = string.Empty;
   }
}
