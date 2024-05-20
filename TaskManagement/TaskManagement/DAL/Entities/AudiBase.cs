using System.ComponentModel.DataAnnotations;

namespace TaskManagement.DAL.Entities
{
    public class AudiBase
    {
        [Key]
        [Required]
        public virtual Guid Id { get; set; } //This will be the PK of all the tables, always.IDS are long, highly secure, alphanumeric

        public virtual DateTime CreatedDate { get; set; } //to save new with its creation date.

        public virtual DateTime DueDate { get; set; } //to save any record that was modified with its Expiration date

        public virtual DateTime? CompletionDate { get; set; } //Task completion date   
    }
}
