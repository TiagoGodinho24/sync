using System.ComponentModel.DataAnnotations;

namespace TFSSincronizador.Models
{
    
    public class Profile
    {
        [Key]
        public int ProfileId { get; set; }
        [Required(ErrorMessage = "O nome do Perfil deve ser preenchido")]
        [Display(Name = "Nome do Perfil")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter o tamanho minimo {2} Tamanho máximo de {1} caracteres")]
        public string ProfileName { get; set; }
        public string Status    { get; set; }

        [Required(ErrorMessage = "A sincronização deve ser preenchida")]
        [Display(Name = "SyncDirection")]
        [StringLength(80)]
        public string SyncDirection { get; set; }

        [Required(ErrorMessage = "O nome do Perfil deve ser preenchido")]
        [Display(Name = "Nome do Projeto")]
        [StringLength(80)]
        public string JProject { get; set; }

        [Required(ErrorMessage = "O nome do Perfil deve ser preenchido")]
        [Display(Name = "Nome da Collection")]
        [StringLength(80)]
        public string TFSCollection { get; set; }

        [Required(ErrorMessage = "O nome do Perfil deve ser preenchido")]
        [Display(Name = "Nome do Projeto")]
        [StringLength(80)]
        public string TFSProject { get; set; }

        public ICollection<MappingField> MappingFields { get; set; }
        public ICollection<MappingStatus> MappingStatuses { get; set; }
        public ICollection<MappingType> MappingTypes { get; set; }

    }
}
