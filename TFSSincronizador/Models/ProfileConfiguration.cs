using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSSincronizador.Models
{
    public class ProfileConfiguration 
    {
        [Key]
        public int ConfigId { get; set; }


        [ForeignKey("Profile")]
        public int MappingFieldProfile { get; set; }

        public string JiraURL { get; set; } 
        public string Email { get; set; }
        public string APIToken { get; set; }
        public string Project { get; set; }
        public string CustomField { get; set; }

        public string TFSUrl { get; set; }
        public string Name { get; set; }
        public string PassWord { get; set; }
        public string Domain { get; set; }
        public string Collection { get; set; }
        public string TFSProject { get; set; }
        public string TFSCustom { get; set; }

        public Profile Profile { get; set; }
    }
}
