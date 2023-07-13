using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required]
        public string Nombre { get; set; } = String.Empty;
        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = String.Empty;
        [Required]
        public string DescripcionLarga { get; set; } = String.Empty;
        [Required]
        public string PublicoObjetivo { get; set; } = String.Empty;
        [Required]
        public string Objetivos { get; set; } = String.Empty;
        [Required]
        public string Requisitos { get; set; } = String.Empty;

        public enum NivelEnum
        {
            Basico,
            Intermedio,
            Avanzado
        };

        [Required, EnumDataType(typeof(NivelEnum))]
        public NivelEnum Nivel { get; set; }
    }
}
