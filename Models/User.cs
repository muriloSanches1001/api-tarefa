using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_tarefa.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "User name")]
        [Required]
        public int name { get; set;}

        [Display(Name = "User email")]
        [Required]
        public string email { get; set;}

        [Display(Name = "User password")]
        [Required]
        public string password { get; set;}

        public ICollection<SchoolTask> schoolTasks { get; set; }
    }
}
