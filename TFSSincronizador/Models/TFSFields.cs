using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TFSSincronizador.Models
{
    public class TFSFields 
    {
        [Key]
        public int TFSFieldsId { get; set; }

        [Required]
        public string TFSFieldsName { get; set; }

    }
}
