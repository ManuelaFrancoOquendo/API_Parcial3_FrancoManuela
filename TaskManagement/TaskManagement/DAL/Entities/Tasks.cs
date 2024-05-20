using System.ComponentModel.DataAnnotations;

namespace TaskManagement.DAL.Entities
{
    public class Tasks : AudiBase
    {
        [Display(Name = "Título")] //To identify the name much easier.
        [MaxLength(50, ErrorMessage ="El campo {0} debe tener máximo {1} caracteres.")] //Maximum length
        [Required(ErrorMessage = "Es campo {0} es obligatorio")] //   For it to be required
        public string Title { get; set; }

        [Display(Name = "Descripción de la tarea")] //        To identify the name much easier.
        
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] //        Maximum length
        public string? Description { get; set; }


        //This attribute is not entered.
        [Display(Name = "Tarea completada")] //        To identify the name much easier.
        
        [MaxLength(30, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] //        Maximum length
        [Required(ErrorMessage = "Es campo {0} es obligatorio")] //        For it to be required
        public string IsCompleted { get; set; }


        [Display(Name = "Prioridad de la tarea")] //To identify the name much easier.
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] //        Maximum length
        [Required(ErrorMessage = "Es campo {0} es obligatorio")] //        For it to be required
        public string Priority { get; set; }


        //I don't know whether to include the following entities since they may be part of the audit.
        //    public DateTime DueDate { get; set; }
        //    public DateTime CreateDate { get; set; }
        //    public DateTime CompletionDate { get; set; }
    }

}
    