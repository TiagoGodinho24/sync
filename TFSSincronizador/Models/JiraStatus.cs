using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TFSSincronizador.Models
{
    public class JiraStatus 
    {
        [Key]  
        public int JiraStatusId { get; set; }

        [Required]
        public string JiraStatusName { get; set; }
    }
}
