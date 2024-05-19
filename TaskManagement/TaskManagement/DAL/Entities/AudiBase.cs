using System.ComponentModel.DataAnnotations;

namespace TaskManagement.DAL.Entities
{
    public class AudiBase
    {
        [Key]
        [Required]
        public virtual Guid Id { get; set; } // Esta sera el PK de todas las tablas, siemore. son los IDS largos, altamente seguro, alfanumericos 
        
        public virtual DateTime CreatedDate { get; set; } // para guardar nuevo con su fecha de creacion.
        
        public virtual DateTime DueDate { get; set; } // para guardar todo registro que se modifico con su fecha de Vencimiento.

        public virtual DateTime CompletionDate { get; set; } //Fecha de finalizacion de la tarea   
    }
}
