using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSSincronizador.Models
{

    public class MappingType
    {
        [Key]
        public int MappingTypeId { get; set; }

        [ForeignKey("Profile")]
        public int MappingTypeProfile { get; set; }

        [ForeignKey("TFSType")]
        public int TFSTypeId { get; set; }
        public TFSType TFSType { get; set; }

        [ForeignKey("JiraType")]
        public int JiraTypeId { get; set; }
        public JiraType JiraType { get; set; }

        public Profile Profile { get; set; }
    }
}
