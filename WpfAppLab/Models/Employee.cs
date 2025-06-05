using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfAppLab.Models
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string FullName { get; set; }
        public required int Age { get; set; }
        public required string Gender { get; set; }
        public required string Address { get; set; }
        public required int Phone { get; set; }
        public required int Passport { get; set; }

        public int JobTitleId { get; set; }
        public virtual JobTitle? JobTitle { get; set; }

    }
}
