using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WpfAppLab.Models
{
    internal class Provider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
        public required int Phone {  get; set; }
        public required int FirstProduceProductId { get; set; }
        public required int SecondProduceProductId { get; set; }
        public required int ThirdProduceProductId { get; set; }
    }
}
