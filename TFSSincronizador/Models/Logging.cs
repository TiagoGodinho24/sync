using System.ComponentModel.DataAnnotations;

namespace TFSSincronizador.Models
{
    public class Logging
    {
        [Key]
        public int LogId { get; set; } 
        [Required]
        [Display(Name ="Log Name")]
        public string LogName { get; set; }
    }
}
