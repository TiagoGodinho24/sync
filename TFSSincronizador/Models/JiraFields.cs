using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TFSSincronizador.Models
{
    public class JiraFields 
    {
        [Key]
        public int JiraFieldsId { get; set; }

        [Required]
        public string JiraFieldsName { get; set; }
    }
}
