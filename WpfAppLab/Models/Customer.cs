using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WpfAppLab.Models
{
    internal class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required int Phone {  get; set; }
        public required int FirstTakeProductId { get; set; }
        public required int SecondTakeProductId { get; set; }
        public required int ThirdTakeProductId { get; set; }
    }
}
