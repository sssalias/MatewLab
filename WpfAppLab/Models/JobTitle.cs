using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfAppLab.Models
{
    internal class JobTitle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Title { get; set; }
        public required int Salary { get; set; }
        public required string Description { get; set; }
        public required string ResponseAbilities { get; set; }
        public required string Requirements { get; set; }


        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
