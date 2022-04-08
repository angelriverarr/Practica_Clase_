using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica01.Models
{
    public class Estudiantes
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Required]
        public int id { get; set; }
        public string? name { get; set; }
        public string? lastName { get; set; }

    }
}
