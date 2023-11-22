using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSSincronizador.Models
{

    public class MappingField
    {
        [Key]
        public int MappingFieldId { get; set; }

        [ForeignKey("Profile")]
        public int MappingFieldProfile { get; set; }

        [ForeignKey("TFSField")]
        public int TFSFieldId { get; set; }
        public TFSFields TFSFields { get; set; }

        [ForeignKey("JiraField")]

        public int JiraFieldId { get; set; }
        public JiraFields JiraFields { get; set; }

        public Profile Profile { get; set; }

    }
}
