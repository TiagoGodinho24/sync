using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TFSSincronizador.Models
{

    public class MappingStatus
    {
        [Key]
        public int MappingStatusId { get; set; }

        [ForeignKey("Profile")]
        public int MappingStatusProfile { get; set; }

        [ForeignKey("TFSStatus")]
        public int TFSStatusId { get; set; }
        public TFSStatus TFSStatus { get; set; }

        [ForeignKey("JiraStatus")]
        public int JiraStatusId { get; set; }
        public JiraStatus JiraStatus { get; set; }

        public Profile Profile { get; set; }
    }
}
