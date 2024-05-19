using System.ComponentModel.DataAnnotations;

namespace TaskManagement.DAL.Entities
{
    public class Tasks : AudiBase
    {
        [Display(Name = "Título")] //Para identificar el nombre mucho mas facil.
        [MaxLength(50, ErrorMessage ="El campo {0} debe tener máximo {1} caracteres.")] //Longitud maxima
        [Required(ErrorMessage = "Es campo {0} es obligatorio")] //Para que sea requerido
        public string Title { get; set; }

        [Display(Name = "Descripción de la tarea")] //Para identificar el nombre mucho mas facil.
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] //Longitud maxima
        public string? Description { get; set; }


        //Este atributo no se ingresa.
        [Display(Name = "Tarea completada")] //Para identificar el nombre mucho mas facil.
        [MaxLength(30, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] //Longitud maxima
        [Required(ErrorMessage = "Es campo {0} es obligatorio")] //Para que sea requerido
        public string IsCompleted { get; set; }


        [Display(Name = "Prioridad de la tarea")] //Para identificar el nombre mucho mas facil.
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres.")] //Longitud maxima
        [Required(ErrorMessage = "Es campo {0} es obligatorio")] //Para que sea requerido
        public string Priority { get; set; }


        //Las siguientes entidades no se si ponerlas ya que pueden ser parte de la auditoria.
    //    public DateTime DueDate { get; set; }
    //    public DateTime CreateDate { get; set; }
    //    public DateTime CompletionDate { get; set; }
    }

}
    