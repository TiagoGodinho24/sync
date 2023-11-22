using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TFSSincronizador.Models
{
    public class TFSStatus 
    {
        [Key]
        public int TFSStatusId { get; set; }

        [Required]
        public string TFSStatusName { get; set; }

    }
}
