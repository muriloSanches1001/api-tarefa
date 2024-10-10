using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_tarefa.Models
{
    [Table("school_tasks")]
    public class SchoolTask
    {

        [Key]
        public int Id { get; set; }

        [Display(Name = "School Task description")]
        [Required]
        public string description { get; set; }

        [Display(Name = "School Task expected date")]
        [Required]
        public DateTime expectedDate { get; set; }

        [Display(Name = "School Task completion date")]
        [Required]
        public DateTime completionDate { get; set; }

        [ForeignKey("fk_user")]
        [Display(Name = "User id")]
        [Required]
        public int fk_user { get; set; }

        public User user { get; set; }
    }
}
