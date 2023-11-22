using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TFSSincronizador.Models
{
    public class JiraType 
    {
        [Key]
        public int JiraTypeId { get; set; }
        [Required]
        public string JiraTypeName { get; set; }
    }
}
