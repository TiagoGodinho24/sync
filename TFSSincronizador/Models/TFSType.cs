using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace TFSSincronizador.Models
{
    public class TFSType
    {
        [Key]
        public int TFSTypeId { get; set; }

        [Required]
        public string TFSTypeName { get; set; }

    }

}
